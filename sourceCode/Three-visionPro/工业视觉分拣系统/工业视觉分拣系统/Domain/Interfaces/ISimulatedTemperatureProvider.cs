using System;
using System.Collections.Generic;
using System.Text;

namespace _9_11.Domain.Interfaces
{
    internal interface ISimulatedTemperatureProvider
    {
        //event EventHandler<double>? SimulatedTempGenerated;  // 产出模拟值
        void Start();
        void Stop();
        Task LoopWriteCurrentAsync(ushort temp);  // 循环写入虚拟温度
    }
}
