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

        public SimulatedTemperatureProvider(IModbusClient modbusRtuClient)
        {
            _modbusRtuClient = modbusRtuClient ?? throw new ArgumentNullException(nameof(modbusRtuClient));
        }

        public async Task WriteCurrentAsync(ushort temp)
        {
            // 每秒升/降，返回模拟数据
            await _modbusRtuClient.WriteMultipleRegistersAsync(
                RegisterMap.SlaveAddress,
                RegisterMap.SetTempIndex,                    
                [temp]
            );
        }
    }
}
