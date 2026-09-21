using _9_11.Application.Abstractions;
using _9_11.Domain.Entities;
using _9_11.Domain.Enums;
using _9_11.Domain.Events;
using _9_11.Domain.Interfaces;
using _9_11.Infrastructure.Modbus;
using _9_11.Infrastructure.Repositories;
using _9_11.Infrastructure.Simulation;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _9_11.Application.Implementation
{
    internal class MonitoringService : IMonitoringService
    {
        //串口
        private ModbusRtuClient? _modbusRtuClient;
        private RegisterMap? _registerMap;
        //UI委托
        public event EventHandler<TempReadEventArgs>? TempRead;
        //定时器
        private readonly System.Windows.Forms.Timer Timer = new() { Interval = 500 };           //定时读取温度
        private readonly System.Windows.Forms.Timer TimerSimulated = new() { Interval = 500 };  //定时写入模拟温度
        //数据库
        private readonly Channel<DeviceTempRecord> _dataChannel;
        private readonly ITempRecordRepository _repository = new MySqlTempRepository();  // 写数据库的
        private readonly int _batchSize = 50;               // 满50条写一次
        private readonly TimeSpan _flushInterval = TimeSpan.FromSeconds(10); // 或10秒写一次
        //消费者
        private Task? _consumerTask;
        private bool _disposed;

        public MonitoringService()
        {
            _dataChannel = Channel.CreateBounded<DeviceTempRecord>(new BoundedChannelOptions(1000)
            {
                FullMode = BoundedChannelFullMode.DropOldest  // 满了丢最旧的，保内存
            });

            // 启动后台消费者
            _consumerTask = Task.Run(ConsumeAndFlushAsync);


            //定时读取温度
            // ===== 生产者：Timer Tick =====
            Timer.Tick += async (object? sender, EventArgs e) =>
            {
                if (_modbusRtuClient == null || !_modbusRtuClient.IsConnected)
                    return;

                //读取当前温度
                ITemperatureProvider temperatureProvider = new TemperatureProvider(_modbusRtuClient);
                DeviceTempRecord deviceTempRecord = await temperatureProvider.ReadCurrentAsync();

                Console.WriteLine("模拟读取温度："+ deviceTempRecord);

                TempRead?.Invoke(this, new TempReadEventArgs(deviceTempRecord));

                //// 1. 通知 UI（UI 自己限长）
                //TempRead?.Invoke(this, new TempReadEventArgs(record));

                // 2. 写入 Channel 等待批量落库（不阻塞 Timer）
                await _dataChannel.Writer.WriteAsync(deviceTempRecord);
            };

            //定时写入模拟温度
            double _t = 0;
            TimerSimulated.Tick += async (object? sender, EventArgs e) =>
            {
                if (_modbusRtuClient == null || !_modbusRtuClient.IsConnected)                                    
                    return;
                
                // 模拟温度在 50~150 之间正弦波动
                _t += 0.1;
                var sumulatedTemp = 100 + 50 * Math.Sin(_t);

                //Console.WriteLine("模拟写入温度："+ sumulatedTemp);
                ISimulatedTemperatureProvider simulatedTemperatureProvider = new SimulatedTemperatureProvider(_modbusRtuClient);
                await simulatedTemperatureProvider.WriteCurrentAsync((ushort)sumulatedTemp);
            };
        }

        // ===== 消费者：批量写库 =====
        private async Task ConsumeAndFlushAsync()
        {
            var batch = new List<DeviceTempRecord>(_batchSize);
            var timer = Stopwatch.StartNew();

            await foreach (var record in _dataChannel.Reader.ReadAllAsync())
            {
                batch.Add(record);

                // 条件1：攒够一批
                // 条件2：或者超时（防止低频时数据一直不写）
                if (batch.Count >= _batchSize || timer.Elapsed >= _flushInterval)
                {
                    try
                    {
                        await _repository.FlushBatchAsync(batch);
                        batch.Clear();
                        timer.Restart();
                    }
                    catch (OperationCanceledException)
                    {
                        // CancellationToken 触发时走到这里（正常退出路径）
                    }
                    catch (Exception)
                    {
                        // 写库失败：可以重试、写本地文件、或者记日志
                        //_logger?.LogError(ex, "批量写库失败，{Count} 条数据丢失", batch.Count);
                        batch.Clear(); // 生产环境通常丢（保活），或者存本地文件重试
                    }

                    // ← ReadAllAsync 结束后（Complete 或 Cancel），收尾写剩余数据
                    if (batch.Count > 0)
                    {
                        await _repository.FlushBatchAsync(batch);
                    }
                }
            }
        }

        public async Task DeviceStartAsync()
        {
            if (_registerMap == null)
                throw new ArgumentNullException(nameof(_registerMap));

            if (_registerMap.RawData[RegisterMap.DeviceStatusIndex] == (ushort)DeviceState.Running)
                return;

            if (_modbusRtuClient == null)
                throw new ArgumentNullException(nameof(_modbusRtuClient));

            await _modbusRtuClient.WriteMultipleRegistersAsync(
                RegisterMap.SlaveAddress,
                RegisterMap.DeviceStatusIndex,
                [(ushort)DeviceState.Running]
            );

            _registerMap.RawData[RegisterMap.DeviceStatusIndex] = (ushort)DeviceState.Running;

            TimerSimulated.Start();
            Timer.Start();
        }

        public async Task DeviceStopAsync()
        {
            if (_registerMap == null ||
                _registerMap.RawData[RegisterMap.DeviceStatusIndex] == (ushort)DeviceState.Standby)
                return;
            
            if (_modbusRtuClient == null)
                throw new InvalidOperationException("设备未连接");

            TimerSimulated.Stop();
            Timer.Stop();
            
            await _modbusRtuClient.WriteMultipleRegistersAsync(
                RegisterMap.SlaveAddress,
                RegisterMap.DeviceStatusIndex,
                [(ushort)DeviceState.Standby]
            );            

            _registerMap.RawData[RegisterMap.DeviceStatusIndex] = (ushort)DeviceState.Standby;
        }

        public async Task GetConnectAsync()
        {
            if (_modbusRtuClient != null)
                throw new InvalidOperationException("设备已连接，请先断开后再试");

            try
            {
                _modbusRtuClient = new ModbusRtuClient();
                _modbusRtuClient.Connect();
                _registerMap = new RegisterMap(await _modbusRtuClient.ReadHoldingRegistersAsync(
                    RegisterMap.SlaveAddress,
                    RegisterMap.ReadStart,
                    RegisterMap.ReadCount
                ));
            }
            catch (Exception ex)
            {
                // 1. 清理资源（必须做）
                _modbusRtuClient?.Dispose();
                _modbusRtuClient = null;
                _registerMap = null;

                throw new Exception($"设备连接失败：{ex.Message}", ex);
            }
        }

        public async Task LostConnectAsync()
        {
            await DeviceStopAsync();
            _modbusRtuClient?.Dispose();
            _modbusRtuClient = null;
        }

        public async Task SetTemperatureAsync(double temperature)
        {
            if (_registerMap == null)
                throw new ArgumentNullException(nameof(_registerMap));
            if (_registerMap.RawData[RegisterMap.DeviceStatusIndex] == (ushort)DeviceState.Running)
                return;

            _registerMap.RawData[RegisterMap.SetTempIndex] = (ushort)(temperature / RegisterMap.TempScale);
            
            if (_modbusRtuClient == null)
                throw new ArgumentNullException(nameof(_registerMap));
            
            await _modbusRtuClient.WriteMultipleRegistersAsync(
                RegisterMap.SlaveAddress,
                RegisterMap.SetTempIndex, // 写入 SetTempIndex 更合理（根据语义）
                [_registerMap.RawData[RegisterMap.SetTempIndex]]
            );            
        }
    }
}
