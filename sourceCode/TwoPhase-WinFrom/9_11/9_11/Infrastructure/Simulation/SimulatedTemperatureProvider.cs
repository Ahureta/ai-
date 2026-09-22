using _9_11.Domain.Entities;
using _9_11.Domain.Interfaces;
using _9_11.Infrastructure.Modbus;
using System;
using System.Collections.Generic;
using System.Text;

namespace _9_11.Infrastructure.Simulation
{
    public class SimulatedTemperatureProvider : ISimulatedTemperatureProvider
    {
        private readonly IModbusClient _modbusRtuClient;
        private readonly System.Windows.Forms.Timer _timerSimulated;    //定时写入模拟温度

        public event EventHandler<DeviceTempRecord>? DataReceived;
        public event EventHandler<Exception>? ErrorOccurred;

        public void Start() => _timerSimulated.Start();
        public void Stop() => _timerSimulated.Stop();
        public SimulatedTemperatureProvider(IModbusClient modbusRtuClient, int intervalMs = 500)
        {
            _modbusRtuClient = modbusRtuClient ?? throw new ArgumentNullException(nameof(modbusRtuClient));
            if (!_modbusRtuClient.IsConnected)
                throw new ArgumentNullException(nameof(modbusRtuClient));

            _timerSimulated = new() { Interval = intervalMs };
            _timerSimulated.Tick += TimerSimulated_Tick;
        }

        //定时写入模拟温度
        double _t = 0;
        private async void TimerSimulated_Tick(object? sender, EventArgs e)
        {
            if (_modbusRtuClient == null || !_modbusRtuClient.IsConnected)
                return;

            // 模拟温度在 50~150 之间正弦波动
            _t += 0.1;
            var sumulatedTemp = 100 + 50 * Math.Sin(_t);

            //Console.WriteLine("模拟写入温度："+ sumulatedTemp);
            ISimulatedTemperatureProvider simulatedTemperatureProvider = new SimulatedTemperatureProvider(_modbusRtuClient);
            await simulatedTemperatureProvider.LoopWriteCurrentAsync((ushort)sumulatedTemp);
        }

        public async Task LoopWriteCurrentAsync(ushort temp)
        {
            // 每秒升/降，返回模拟数据
            await _modbusRtuClient.WriteMultipleRegistersAsync(
                RegisterMap.SlaveAddress,
                RegisterMap.RealTempIndex,                    
                [temp]
            );
        }
    }
}
