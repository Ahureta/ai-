using _9_11.Application.Abstractions;
using _9_11.Domain.Entities;
using _9_11.Domain.Enums;
using _9_11.Infrastructure.Modbus;
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

        public async Task DeviceStartAsync()
        {
            if (_registerMap == null ||
                _registerMap.RawData[RegisterMap.DeviceStatusIndex] == (ushort)DeviceState.Running)
                return;

            _modbusRtuClient?.WriteMultipleRegistersAsync(
                RegisterMap.SlaveAddress,
                RegisterMap.DeviceStatusIndex,
                [(ushort)DeviceState.Running]
            );            
        }

        public async Task DeviceStopAsync()
        {
            if (_registerMap == null ||
                _registerMap.RawData[RegisterMap.DeviceStatusIndex] == (ushort)DeviceState.Standby)
                return;

            _modbusRtuClient?.WriteMultipleRegistersAsync(
                RegisterMap.SlaveAddress,
                RegisterMap.DeviceStatusIndex,
                [(ushort)DeviceState.Standby]
            );
        }

        public async Task GetConnectAsync()
        {
            if (_modbusRtuClient != null)
                return;

            try
            {
                _modbusRtuClient = ModbusRtuClient.Instance;
                _registerMap = new(await _modbusRtuClient.ReadHoldingRegistersAsync(
                    RegisterMap.SlaveAddress,
                    RegisterMap.ReadStart,
                    RegisterMap.ReadCount
                    ));
            }
            catch (Exception)
            {
                _modbusRtuClient?.Dispose();
            }
        }

        public async Task LostConnectAsync()
        {
            _modbusRtuClient?.Dispose();
        }

        public async Task SetTemperatureAsync(double temperature) {
            if (_registerMap == null ||
                _registerMap.RawData[RegisterMap.DeviceStatusIndex] == (ushort)DeviceState.Running)
                return;

            _registerMap.RawData[RegisterMap.SetTempIndex] = (ushort)(temperature / RegisterMap.TempScale);
            _modbusRtuClient?.WriteMultipleRegistersAsync(
                RegisterMap.SlaveAddress,
                RegisterMap.DeviceStatusIndex,
                [(ushort)DeviceState.Running]
            );
        }
    }
}
