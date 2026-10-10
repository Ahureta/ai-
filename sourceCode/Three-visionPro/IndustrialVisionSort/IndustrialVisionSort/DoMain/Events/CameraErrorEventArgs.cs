using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialVisionSort.DoMain.Events
{
    /// <summary>
    /// 相机错误事件参数
    /// </summary>
    public class CameraErrorEventArgs : EventArgs
    {
        public string ErrorMessage { get; }
        public Exception Exception { get; }
        public CameraErrorEventArgs(string msg, Exception ex = null)
        {
            ErrorMessage = msg;
            Exception = ex;
        }
    }
}
