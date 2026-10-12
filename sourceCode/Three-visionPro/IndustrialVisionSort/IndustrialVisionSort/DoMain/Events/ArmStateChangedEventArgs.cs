using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialVisionSort.DoMain.Events
{
    /// <summary>
    /// 机械臂状态变化事件参数
    /// </summary>
    public class ArmStateChangedEventArgs : EventArgs
    {
        public string State { get; set; } // "connected" / "moveEnd" / "disconnected"
    }
}
