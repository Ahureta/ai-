using System;
using System.Collections.Generic;
using System.Text;

namespace _9_11.Domain.Enums
{
    // 对应寄存器地址 3：故障码
    public enum FaultCode : byte
    {
        None = 0,      // 无故障
        OverTemperature = 1  // 超温
    }
}
