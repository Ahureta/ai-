using Cognex.VisionPro;
using IndustrialVisionSort.DoMain.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialVisionSort.Application
{
    internal class CameraSettingService
    {
        //UI委托
        //public event EventHandler<ImageSourceEventArgs> ImageSource;
        public event EventHandler<FrameAcquiredEventArgs> FrameAcquired;

        private CogFrameGrabbers _grabbers;
        private ICogFrameGrabber _cogFrameGrabber;
        private ICogAcqFifo _acq;
        private bool _isLiveMode = false;
        // 暴露给 UI 层读取（只读）
        public ICogAcqFifo CurrentAcqFifo => _acq;
        public bool IsAcqReady => _acq != null;

        internal void GetAcqFifo(string selectedValue)
        {
            // 根据 videoFormat 自动匹配 pixelFormat
            CogAcqFifoPixelFormatConstants pixelFormat = MapPixelFormat(selectedValue);

            _acq = _cogFrameGrabber.CreateAcqFifo(selectedValue,
                pixelFormat,
                0,
                true
            );

            _acq.OwnedExposureParams.Exposure = 300;
            
            _acq.Complete += Acq_Complete;
        }
        private void Acq_Complete(object sender, CogCompleteEventArgs e)
        {
            if (_isLiveMode)
                return; // 预览模式：UI 层的 StartLiveDisplay 自己取图，这里不抢
            try
            {
                _acq.GetFifoState(out int numPending, out int numReady, out bool busy);

                if (numReady > 0)
                {
                    //拿图方式：调用 CompleteAcquireEx
                    var info = new CogAcqInfo();
                    ICogImage image = _acq.CompleteAcquireEx(info); // 返回的是 ICogImage

                    // 抛给 UI 层
                    FrameAcquired?.Invoke(this, new FrameAcquiredEventArgs(image));
                }
            }
            catch (Exception ex)
            {
                // 采集异常不要吞掉
                System.Diagnostics.Debug.WriteLine($"Acq_Complete error: {ex.Message}");
            }
        }
        //// 模式一：业务采集（单次/连续处理）
        //public void StartBusinessMode()
        //{            
        //    _acq.StartAcquire(); // 开始采，Complete 事件里处理
        //}
        //// 模式二：纯预览
        //public void StartLiveMode()
        //{                    
        //    _acq?.StartAcquire();            
        //}
        private CogAcqFifoPixelFormatConstants MapPixelFormat(string videoFormat)
        {
            if (string.IsNullOrEmpty(videoFormat))
                return CogAcqFifoPixelFormatConstants.Format8Grey;

            string vf = videoFormat.ToUpper();

            // 灰度格式
            if (vf.Contains("MONO") || vf.Contains("GREY") || vf.Contains("GRAY"))
                return CogAcqFifoPixelFormatConstants.Format8Grey;

            // Bayer / 彩色格式
            if (vf.Contains("BAYER") || vf.Contains("RGB") || vf.Contains("YUV"))
                return CogAcqFifoPixelFormatConstants.Format32RGB; // 或 FormatRgb32

            // 默认兜底
            return CogAcqFifoPixelFormatConstants.Format8Grey;
        }
        internal CogFrameGrabbers GetImageSource()
        {
            _grabbers = new CogFrameGrabbers();
            return _grabbers;
        }
        internal CogStringCollection GetVideoFormat(ICogFrameGrabber cogFrameGrabber)
        {
            _cogFrameGrabber = cogFrameGrabber;
            return cogFrameGrabber.AvailableVideoFormats;
        }
        // 统一开始采集
        public void StartAcquisition()
        {
            _acq?.StartAcquire();
        }
        //停止开采
        public void StopAcquisition()
        {
            _acq?.Flush();
            _isLiveMode = false;
        }
        public void SetMode(bool isLiveMode)
        {
            _isLiveMode = isLiveMode;
        }
    }
}
