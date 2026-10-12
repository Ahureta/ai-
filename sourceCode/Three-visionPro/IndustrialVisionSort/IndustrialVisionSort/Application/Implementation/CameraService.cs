using Cognex.VisionPro;
using IndustrialVisionSort.DoMain.Entities;
using IndustrialVisionSort.DoMain.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace IndustrialVisionSort.Application
{
    internal class CameraService
    {
        private readonly Camera _camera = new Camera();

        // 状态事件，UI 只订阅
        public event Action<string> StatusChanged;
        public event Action<string> ErrorOccurred;
        public event Action Ready;
        // 事件
        public event Action<CogFrameGrabbers> GetCogFrameGrabbers;
        public event Action<CogStringCollection> GetVideoFormat;
        public event Action<ICogAcqFifo> GetAcqFifo;
        public event Action<Camera> InitializeAttribute;        //显示属性

        private Thread _worker;

        public event EventHandler<FrameAcquiredEventArgs> FrameAcquired;        //UI委托        
        private CogFrameGrabbers _grabbers;
        private ICogFrameGrabber _cogFrameGrabber;
        private ICogAcqFifo _acq;
        public ICogAcqFifo CurrentAcqFifo => _acq;
        public bool IsAcqReady => _acq != null;

        public CameraService() {
            // 桥接：Camera 抛出来的事件直接转发给外层
            _camera.FrameAcquired += (s, e) => FrameAcquired?.Invoke(s, e);

            // 顺便把 Error 也桥接了（可选）
            _camera.ErrorOccurred += (s, e) => ErrorOccurred?.Invoke(e.ErrorMessage.ToString());
        }
        public void InitializeImageSource() {
            _worker = new Thread(() =>
            {
                try
                {
                    StatusChanged?.Invoke("正在枚举相机...");

                    _grabbers = new CogFrameGrabbers();
                    GetCogFrameGrabbers?.Invoke(_grabbers);

                    StatusChanged?.Invoke("相机枚举完毕...");
                }
                catch (Exception ex)
                {
                    ErrorOccurred?.Invoke(ex.Message);
                }
            });

            // 关键：COM 对象要求 STA
            _worker.SetApartmentState(ApartmentState.STA);
            _worker.IsBackground = true;
            _worker.Start();

        }

        public void InitializeVideoFormat(ICogFrameGrabber cogFrameGrabber) {
            _worker = new Thread(() =>
            {
                try
                {
                    _camera.Connect(cogFrameGrabber.Name);
                    Console.WriteLine(_camera.AvailableVideoFormats.Count);
                    GetVideoFormat?.Invoke(_camera.AvailableVideoFormats);
                    Ready?.Invoke();
                }
                catch (Exception ex)
                {
                    ErrorOccurred?.Invoke(ex.Message);
                }
            });

            // 关键：COM 对象要求 STA
            _worker.SetApartmentState(ApartmentState.STA);
            _worker.IsBackground = true;
            _worker.Start();

            //_camera.Connect(cogFrameGrabber.Name);
            //GetVideoFormat?.Invoke(_camera.AvailableVideoFormats);           
        }

        public void InitializeCapture(string serial, string format)
        {
            _worker = new Thread(() =>
            {
                try
                {
                    // 同步阻塞，但后台线程里做，无所谓
                    StatusChanged?.Invoke("正在枚举相机...");
                    _camera.Connect(serial);

                    StatusChanged?.Invoke("正在创建采集通道...");
                    _camera.CreateFifo(format);

                    StatusChanged?.Invoke("初始化完成");
                    
                    InitializeAttribute.Invoke(_camera);
                    //Ready?.Invoke();
                }
                catch (Exception ex)
                {
                    ErrorOccurred?.Invoke(ex.Message);
                }
            });

            // 关键：COM 对象要求 STA
            _worker.SetApartmentState(ApartmentState.STA);
            _worker.IsBackground = true;
            _worker.Start();
        }

        public void SetFreeRun() {
            _camera.GetAcqFifo += conAcqFifo => {
                GetAcqFifo.Invoke(conAcqFifo);
            };
            _camera.StartLive();
        }
        public void SetManual() {
            _camera.StartSingle();
        }
        public void SetAuto() {
            _camera.StartHardwareAuto();
        }
        public void SetSemi(){
            _camera.StartHardwareSemi();
        }
        public void Stop() {
            _camera.Stop();
        }

        //internal void GetAcqFifo(string selectedValue)
        //{
        //    //_camera.Connect(selectedValue);


        //    if (_cogFrameGrabber == null)
        //        throw new InvalidOperationException("请先选择图像源");

        //    if (string.IsNullOrEmpty(selectedValue))
        //        throw new ArgumentException("视频格式不能为空");

        //    // 防重复创建：先释放旧的
        //    if (_acq != null)
        //    {
        //        try
        //        {                    
        //            _acq.Complete -= Acq_Complete;
        //            _acq = null;
        //        }
        //        catch { /* 忽略释放时的异常 */ }
        //    }

        //    // 根据 videoFormat 自动匹配 pixelFormat
        //    CogAcqFifoPixelFormatConstants pixelFormat = MapPixelFormat(selectedValue);

        //    _acq = _cogFrameGrabber.CreateAcqFifo(selectedValue,
        //        pixelFormat,
        //        0,
        //        true
        //    );

        //    if (_acq == null)
        //        throw new InvalidOperationException("CreateAcqFifo 返回 null，相机可能未就绪");

        //    _acq.OwnedExposureParams.Exposure = 300;

        //    _acq.Complete += Acq_Complete;
        //}
        //private void Acq_Complete(object sender, CogCompleteEventArgs e)
        //{
        //    if (_isLiveMode)
        //        return; // 预览模式：UI 层的 StartLiveDisplay 自己取图，这里不抢
        //    try
        //    {
        //        _acq.GetFifoState(out int numPending, out int numReady, out bool busy);

        //        if (numReady > 0)
        //        {
        //            //拿图方式：调用 CompleteAcquireEx
        //            var info = new CogAcqInfo();
        //            ICogImage image = _acq.CompleteAcquireEx(info); // 返回的是 ICogImage

        //            // 抛给 UI 层
        //            FrameAcquired?.Invoke(this, new FrameAcquiredEventArgs(image));
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        // 采集异常不要吞掉
        //        System.Diagnostics.Debug.WriteLine($"Acq_Complete error: {ex.Message}");
        //    }
        //}
        //private CogAcqFifoPixelFormatConstants MapPixelFormat(string videoFormat)
        //{
        //    if (string.IsNullOrEmpty(videoFormat))
        //        return CogAcqFifoPixelFormatConstants.Format8Grey;

        //    string vf = videoFormat.ToUpper();

        //    // 灰度格式
        //    if (vf.Contains("MONO") || vf.Contains("GREY") || vf.Contains("GRAY"))
        //        return CogAcqFifoPixelFormatConstants.Format8Grey;

        //    // Bayer / 彩色格式
        //    if (vf.Contains("BAYER") || vf.Contains("RGB") || vf.Contains("YUV"))
        //        return CogAcqFifoPixelFormatConstants.Format32RGB; // 或 FormatRgb32

        //    // 默认兜底
        //    return CogAcqFifoPixelFormatConstants.Format8Grey;
        //}
    }
}
