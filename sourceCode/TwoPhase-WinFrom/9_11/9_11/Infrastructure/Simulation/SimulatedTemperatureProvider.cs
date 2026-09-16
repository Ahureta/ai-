using _9_11.Domain.Entities;
using _9_11.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace _9_11.Infrastructure.Simulation
{
    public class SimulatedTemperatureProvider : ITemperatureProvider
    {
        public Task<DeviceTempRecord> ReadCurrentAsync()
        {
            // 每秒升/降，返回模拟数据
        }
    }
}
