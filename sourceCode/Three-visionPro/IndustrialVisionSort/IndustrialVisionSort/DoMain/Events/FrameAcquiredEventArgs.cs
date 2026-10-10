using Cognex.VisionPro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialVisionSort.DoMain.Events
{
    /// <summary>
    /// 帧采集完成事件参数
    /// </summary>
    public class FrameAcquiredEventArgs : EventArgs
    {
        public ICogImage Image { get; }
        public FrameAcquiredEventArgs(ICogImage image)
        {
            Image = image;
        }
    }
}
