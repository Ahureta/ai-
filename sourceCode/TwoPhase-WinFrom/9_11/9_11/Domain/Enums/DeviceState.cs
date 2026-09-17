using System;
using System.Collections.Generic;
using System.Text;

namespace _9_11.Domain.Enums
{
    // 对应寄存器地址 0：设备状态
    public enum DeviceState : byte
    {
        Standby = 0,   // 待机
        Running = 1,   // 运行
        Fault = 2      // 故障
    }
}
