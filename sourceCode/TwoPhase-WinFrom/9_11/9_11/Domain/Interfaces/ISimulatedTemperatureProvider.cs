using System;
using System.Collections.Generic;
using System.Text;

namespace _9_11.Domain.Interfaces
{
    internal interface ISimulatedTemperatureProvider
    {
        internal Task WriteCurrentAsync(ushort temp);  // 写入虚拟温度
    }
}
