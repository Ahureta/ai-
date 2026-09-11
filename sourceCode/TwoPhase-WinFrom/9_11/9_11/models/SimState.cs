using System;
using System.Collections.Generic;
using System.Text;

namespace _9_11.models
{
    // 模拟状态类
    public class SimState
    {
        public ushort CurrentTemp { get; set; }
        public bool IsRising { get; set; } = true;   // true=上升, false=下降
        public ushort Step { get; set; } = 0;
    }
}
