using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialVisionSort.DoMain.Enums
{
    /// <summary>
    /// 相机连接状态
    /// </summary>
    public enum CameraConnectionState
    {
        Disconnected,
        Connecting,
        Ready,
        Acquiring,
        Error
    }
}
