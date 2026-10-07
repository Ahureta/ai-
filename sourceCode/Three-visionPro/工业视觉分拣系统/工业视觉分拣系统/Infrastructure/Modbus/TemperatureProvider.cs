using _9_11.Domain.Entities;
using _9_11.Domain.Events;
using _9_11.Domain.Interfaces;
using _9_11.Infrastructure.Simulation;
using System;
using System.Collections.Generic;
using System.Text;

namespace _9_11.Infrastructure.Modbus
{
    internal class TemperatureProvider : ITemperatureProvider
    {
        private readonly IModbusClient _modbusRtuClient;

        //定时器
        private readonly System.Windows.Forms.Timer _timer;   //定时读取温度        

        //数据抛出
        public event EventHandler<DeviceTempRecord>? DataReceived;
        public event EventHandler<Exception>? ErrorOccurred;

        public void Start() => _timer.Start();
        public void Stop() => _timer.Stop();

        public TemperatureProvider(IModbusClient modbusRtuClient,int intervalMs = 500)
        {
            _modbusRtuClient = modbusRtuClient ?? throw new ArgumentNullException(nameof(modbusRtuClient));
            if (!_modbusRtuClient.IsConnected)
                throw new ArgumentNullException(nameof(modbusRtuClient));

            _timer = new() { Interval = intervalMs };
            _timer.Tick += Timer_Tick;
        }

        private async void Timer_Tick(object? sender, EventArgs e)
        {
            // ===== 生产者：Timer Tick =====            
            DeviceTempRecord deviceTempRecord = await LoopReadCurrentAsync();
            //Console.WriteLine("模拟读取温度：" + deviceTempRecord);
            try
            {
                DataReceived?.Invoke(this, deviceTempRecord);  // ← 只管抛数据，不管谁接
            }
            catch (Exception ex)
            {
                ErrorOccurred?.Invoke(this, ex);
            }

            //读取当前温度            
            //DeviceTempRecord deviceTempRecord = await LoopReadCurrentAsync();


            //DataReceived?.Invoke(this, deviceTempRecord);  // ← 只管抛数据，不管谁接
            //TempRead?.Invoke(this, new TempReadEventArgs(deviceTempRecord));

            //// 1. 通知 UI（UI 自己限长）
            //TempRead?.Invoke(this, new TempReadEventArgs(record));

            // 2. 写入 Channel 等待批量落库（不阻塞 Timer）
            //await _dataChannel.Writer.WriteAsync(deviceTempRecord);
        }



        public async Task<DeviceTempRecord> LoopReadCurrentAsync()
        {
            // 读保持寄存器 0~3，解析成 DeviceTempRecord
            var data = await _modbusRtuClient.ReadHoldingRegistersAsync(RegisterMap.SlaveAddress, RegisterMap.ReadStart, RegisterMap.ReadCount);
            return new DeviceTempRecord(data);
        }
    }
}
