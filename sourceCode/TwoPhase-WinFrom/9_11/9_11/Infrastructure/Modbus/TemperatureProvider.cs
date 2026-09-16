using _9_11.Domain.Entities;
using _9_11.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _9_11.Infrastructure.Modbus
{
    public class TemperatureProvider : ITemperatureProvider
    {
        private readonly IModbusClient _modbus;

        public TemperatureProvider(ModbusRtuClient modbus)
        {
            _modbus = modbus;
        }

        public async Task<DeviceTempRecord> ReadCurrentAsync()
        {
            // 读保持寄存器 0~3，解析成 DeviceTempRecord
            var data = await _modbus.ReadRegistersAsync(1, 0, 4);
            return new DeviceTempRecord(data);
        }
    }
}
