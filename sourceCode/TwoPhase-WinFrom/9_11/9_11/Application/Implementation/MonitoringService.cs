using _9_11.Application.Abstractions;
using _9_11.Domain.Entities;
using _9_11.Domain.Enums;
using _9_11.Domain.Events;
using _9_11.Domain.Interfaces;
using _9_11.Infrastructure.Modbus;
using _9_11.Infrastructure.Simulation;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _9_11.Application.Implementation
{
    internal class MonitoringService : IMonitoringService
    {
        private ModbusRtuClient? _modbusRtuClient;
        private RegisterMap? _registerMap;

        public event EventHandler<TempReadEventArgs>? TempRead;        

        private readonly System.Windows.Forms.Timer Timer = new() { Interval = 500 };
        private readonly System.Windows.Forms.Timer TimerSimulated = new() { Interval = 500 };

        public MonitoringService() {
            Timer.Tick += async (object? sender, EventArgs e) => {
                if (_modbusRtuClient == null)
                    return;
                    //throw new ArgumentNullException(nameof(_modbusRtuClient));

                ITemperatureProvider temperatureProvider = new TemperatureProvider(_modbusRtuClient);
                DeviceTempRecord deviceTempRecord= await temperatureProvider.ReadCurrentAsync();
                TempRead?.Invoke(this, new TempReadEventArgs(deviceTempRecord));
            };

            int sumulatedTemp = 0;
            TimerSimulated.Tick += async (object? sender, EventArgs e) => {
                if (_modbusRtuClient == null)
                    return;
                sumulatedTemp %= sumulatedTemp + 5;
                ISimulatedTemperatureProvider simulatedTemperatureProvider = new SimulatedTemperatureProvider(_modbusRtuClient);
                await simulatedTemperatureProvider.WriteCurrentAsync((ushort)sumulatedTemp);                
            };
        }

        public async Task DeviceStartAsync()
        {
            if (_registerMap == null ||
                _registerMap.RawData[RegisterMap.DeviceStatusIndex] == (ushort)DeviceState.Running)
                return;

            var client = _modbusRtuClient;
            if (client != null)
            {
                await client.WriteMultipleRegistersAsync(
                    RegisterMap.SlaveAddress,
                    RegisterMap.DeviceStatusIndex,
                    new ushort[] { (ushort)DeviceState.Running }
                );
                Timer.Start();
            }
        }

        public async Task DeviceStopAsync()
        {
            if (_registerMap == null ||
                _registerMap.RawData[RegisterMap.DeviceStatusIndex] == (ushort)DeviceState.Standby)
                return;

            var client = _modbusRtuClient;
            if (client != null)
            {
                await client.WriteMultipleRegistersAsync(
                    RegisterMap.SlaveAddress,
                    RegisterMap.DeviceStatusIndex,
                    new ushort[] { (ushort)DeviceState.Standby }
                );
            }
        }

        public async Task GetConnectAsync()
        {
            if (_modbusRtuClient != null)
                return;

            try
            {
                _modbusRtuClient = ModbusRtuClient.Instance;
                _registerMap = new RegisterMap(await _modbusRtuClient.ReadHoldingRegistersAsync(
                    RegisterMap.SlaveAddress,
                    RegisterMap.ReadStart,
                    RegisterMap.ReadCount
                ));
            }
            catch (Exception)
            {
                _modbusRtuClient?.Dispose();
                _modbusRtuClient = null;
            }
        }

        public async Task LostConnectAsync()
        {
            _modbusRtuClient?.Dispose();
            _modbusRtuClient = null;
        }

        public async Task SetTemperatureAsync(double temperature)
        {
            if (_registerMap == null ||
                _registerMap.RawData[RegisterMap.DeviceStatusIndex] == (ushort)DeviceState.Running)
                return;

            _registerMap.RawData[RegisterMap.SetTempIndex] = (ushort)(temperature / RegisterMap.TempScale);

            var client = _modbusRtuClient;
            if (client != null)
            {
                await client.WriteMultipleRegistersAsync(
                    RegisterMap.SlaveAddress,
                    RegisterMap.SetTempIndex, // 写入 SetTempIndex 更合理（根据语义）
                    new ushort[] { _registerMap.RawData[RegisterMap.SetTempIndex] }
                );
            }
        }
    }
}
