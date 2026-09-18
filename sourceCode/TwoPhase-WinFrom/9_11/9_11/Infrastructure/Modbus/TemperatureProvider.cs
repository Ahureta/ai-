using _9_11.Domain.Entities;
using _9_11.Domain.Events;
using _9_11.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _9_11.Infrastructure.Modbus
{
    public class TemperatureProvider : ITemperatureProvider
    {
        private readonly IModbusClient _modbusRtuClient;

        public TemperatureProvider(IModbusClient modbusRtuClient)
        {
            _modbusRtuClient = modbusRtuClient ?? throw new ArgumentNullException(nameof(modbusRtuClient));
        }

        public async Task<DeviceTempRecord> ReadCurrentAsync()
        {
            // 读保持寄存器 0~3，解析成 DeviceTempRecord
            var data = await _modbusRtuClient.ReadHoldingRegistersAsync(RegisterMap.SlaveAddress, RegisterMap.RealTempIndex, 1);
            return new DeviceTempRecord(data);

            /*
                    // 读保持寄存器 0~3，解析成 DeviceTempRecord
                var data = await _modbus.ReadHoldingRegistersAsync(RegisterMap.SlaveAddress, RegisterMap.ReadStart, RegisterMap.ReadCount);
                return new RegisterMap(data);
             */
        }
    }
}
