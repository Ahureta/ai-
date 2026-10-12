using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialVisionSort.DoMain.Entities
{
    using AntdUI;
    using Cognex.VisionPro;
    using Cognex.VisionPro.FGGigE;
    using Cognex.VisionPro.FGGigE.Implementation.Internal;
    using IndustrialVisionSort.DoMain.Enums;
    using IndustrialVisionSort.DoMain.Events;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// 相机封装类 —— 只管硬件，不碰 UI 控件
    /// </summary>
    public class Camera : IDisposable
    {
        // ============================================================
        // 一、身份/连接信息
        // ============================================================
        public string Name { get; private set; }
        public string SerialNumber { get; private set; }
        public string Vendor { get; private set; }          //厂商
        public string Model { get; private set; }           //型号
        public string InterfaceType { get; private set; }
        public string MacAddress { get; private set; }        //MAC地址
        public string CurrentIpAddress { get; private set; }    //相机IP
        public string HostIpAddress { get; private set; }       //连接端IP

        // ============================================================
        // 二、采集参数
        // ============================================================
        public string VideoFormat { get; private set; }        
        public CogStringCollection AvailableVideoFormats { get; } = new CogStringCollection();
        public CogAcqFifoPixelFormatConstants PixelFormat { get; private set; }     //视频格式
        public double ExposureMs { get; set; } = 50;   //曝光
        public double Gain { get; set; } = 1.0;         //增益，对比度        
        public CogAcqTriggerModelConstants TriggerMode { get; set; }    // = CogAcqTriggerModelConstants.FreeRun;     //连续，软触发，硬触发
        public bool TriggerEnabled { get; set; }    // = true;
        public int TimeoutMs { get; set; } = 5000;
        public int BufferCount { get; set; } = 4;      // 默认4帧缓冲
        public double TargetFrameRate { get; set; } = 0; // 0=不限制，跑最大

        // 图像尺寸，创建 FIFO 后从 ROI 读取
        public int Width { get; private set; }
        public int Height { get; private set; }

        // ============================================================
        // 四、运行状态
        // ============================================================
        public bool IsConnected { get; private set; }
        public bool IsInitialized { get; private set; }
        public bool IsAcquiring { get; private set; }
        public bool IsLive { get; private set; }
        public string LastError { get; private set; }
        public string LastErrorMessage { get; private set; }
        public CameraConnectionState ConnectionState
        {
            get => _connectionState;
            private set
            {
                if (_connectionState != value)
                {
                    _connectionState = value;
                    ConnectionStateChanged?.Invoke(this, _connectionState);
                }
            }
        }
        private CameraConnectionState _connectionState = CameraConnectionState.Disconnected;

        // ============================================================
        // 五、底层对象（私有，UI 不直触）
        // ============================================================
        private ICogFrameGrabber _grabber;
        private ICogAcqFifo _acq;

        // 事件
        public event EventHandler<FrameAcquiredEventArgs> FrameAcquired;
        public event EventHandler<CameraConnectionState> ConnectionStateChanged;
        public event EventHandler<CameraErrorEventArgs> ErrorOccurred;
        public event Action<ICogAcqFifo>GetAcqFifo;

        // ============================================================
        // 构造
        // ============================================================
        public Camera() { }

        // ============================================================
        // 方法
        // ============================================================

        /// <summary>
        /// 按序列号或名称连接相机
        /// </summary>
        public void Connect(string identifier, bool bySerial = false)
        {
            ConnectionState = CameraConnectionState.Connecting;
            LastError = null;

            try
            {
                var allGrabbers = new CogFrameGrabbers();
                _grabber = null;

                foreach (ICogFrameGrabber g in allGrabbers)
                {
                    bool match = bySerial
                        ? (g.SerialNumber != null && g.SerialNumber.Equals(identifier, StringComparison.OrdinalIgnoreCase))
                        : (g.Name != null && g.Name.Equals(identifier, StringComparison.OrdinalIgnoreCase));

                    if (match)
                    {
                        _grabber = g;
                        break;
                    }
                }

                if (_grabber == null)
                    throw new InvalidOperationException($"未找到相机: {identifier}");

                // 填充身份信息
                Name = _grabber.Name;
                SerialNumber = _grabber.SerialNumber;
                Vendor = ParseVendor(Name);
                Model = ParseModel(Name);
                InterfaceType = _grabber.GetType().Name;

                // GigE 特有信息
                if (_grabber is CogFrameGrabberGigE gigE)
                {                    
                    try
                    {
                        var gigEAccess = gigE.OwnedGigEAccess;
                        if (gigEAccess is ICogGigEAccess access)
                        {
                            try { MacAddress = access.MACAddress; } catch { }
                            try { CurrentIpAddress = access.CurrentIPAddress; } catch { }
                            try { HostIpAddress = access.HostIPAddress; } catch { }
                        }
                    }
                    catch { }
                }

                foreach (string item in _grabber.AvailableVideoFormats) {
                    AvailableVideoFormats.Add(item);
                }
                Console.WriteLine("formate数量"+AvailableVideoFormats.Count);

                IsConnected = true;
                ConnectionState = CameraConnectionState.Ready;
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                LastErrorMessage = ex.ToString();
                ConnectionState = CameraConnectionState.Error;
                ErrorOccurred?.Invoke(this, new CameraErrorEventArgs("连接失败", ex));
                throw;
            }
        }

        /// <summary>
        /// 创建采集 FIFO
        /// </summary>
        public void CreateFifo(string videoFormat)
        {
            if (_grabber == null)
                throw new InvalidOperationException("请先调用 Connect()");

            VideoFormat = videoFormat;
            PixelFormat = InferPixelFormat(videoFormat);

            // 释放旧的
            if (_acq != null)
            {
                //try { _acq.StopAcquire(); } catch { }
                try { _acq.Complete -= OnAcqComplete; } catch { }
                _acq = null;
            }

            _acq = _grabber.CreateAcqFifo(videoFormat, PixelFormat, 0, false);
            _acq.Timeout = TimeoutMs;
            _acq.OwnedExposureParams.Exposure = ExposureMs;

            // 读取图像尺寸
            var roi = _acq.OwnedROIParams;
            if (roi != null)
            {
                roi.GetROIXYWidthHeight(out _, out _, out int w, out int h);
                Width = w;
                Height = h;
            }

            _acq.Complete += OnAcqComplete;
            IsInitialized = true;
            ConnectionState = CameraConnectionState.Ready;
        }

        /// <summary>
        /// 从设备端读取当前参数，同步到现有属性
        /// 在 CreateFifo() 成功后调用
        /// </summary>
        private void SyncPropertiesFromDevice()
        {
            if (_acq == null) return;

            // ---- 触发模式/状态 ----
            try
            {
                TriggerMode = _acq.OwnedTriggerParams.TriggerModel;
                TriggerEnabled = _acq.OwnedTriggerParams.TriggerEnabled;
            }
            catch { }

            // ---- 曝光：从相机端读回实际值 ----
            try
            {
                var g = _acq.FrameGrabber?.OwnedGigEAccess as ICogGigEAccess;
                if (g != null)
                {
                    string expStr = g.GetFeature("ExposureTime");
                    if (double.TryParse(expStr, out double expUs) && expUs > 0)
                        ExposureMs = expUs / 1000.0;
                }
            }
            catch { }

            // ---- 增益：从相机端读回 ----
            try
            {
                var g = _acq.FrameGrabber?.OwnedGigEAccess as ICogGigEAccess;
                if (g != null)
                {
                    string gainStr = g.GetFeature("Gain");
                    if (double.TryParse(gainStr, out double gv) && gv > 0)
                        Gain = gv;
                }
            }
            catch { }
        }

        public void SetTriggerModel(CogAcqTriggerModelConstants model) {            
            // 1) 先停触发，避免热切换时旧触发继续生效
            _acq.OwnedTriggerParams.TriggerEnabled = false;

            // 2) 清掉 FIFO 里排队的旧请求（重要，尤其 Semi/Manual 切来切去时）
            try { _acq.Flush(); } catch { }

            // 3) 设模型
            _acq.OwnedTriggerParams.TriggerModel = model;

            // 4) 按模型设 Enabled             
            switch (model)
            {
                case CogAcqTriggerModelConstants.FreeRun:
                case CogAcqTriggerModelConstants.Auto:
                case CogAcqTriggerModelConstants.Semi:
                    _acq.OwnedTriggerParams.TriggerEnabled = true;
                    break;
                case CogAcqTriggerModelConstants.Manual:
                    //但海康、大华、Baumer 等 GigE 相机的实际行为是：
                    //Manual 模式下 TriggerEnabled 必须 true，然后 StartAcquire() 充当"软触发信号"→ 相机收到触发→出图→Complete
                    _acq.OwnedTriggerParams.TriggerEnabled = true;  // 手动靠 StartAcquire     这里有个bug必须要true
                    break;
            }
            // 5) 硬触发还要配相机/采集卡端（见下）
            // 6) 改了 videoFormat/大属性可重 Prepare；纯触发切换一般不必重建 FIFO
        }



        /// <summary>
        /// 硬件自动模式（外部触发自动采集，不需要 StartAcquire）
        /// 外部信号到来时相机自动出图，程序只管从 FIFO 取
        /// </summary>
        public void StartHardwareAuto(string triggerLine = "Line0", string edge = "RisingEdge")
        {
            if (_acq == null) throw new InvalidOperationException("请先 CreateFifo");

            //Stop();

            // 2. 设置 FIFO 触发模型为 Auto
            SetTriggerModel(CogAcqTriggerModelConstants.Auto);

            Console.WriteLine("CogAcqTriggerModelConstants"+ _acq.OwnedTriggerParams.TriggerModel);

            // 3. 配置相机端硬触发（GigE）
            var g = _acq.FrameGrabber?.OwnedGigEAccess;
            if (g != null)
            {
                try { g.SetFeature("TriggerMode", "On"); } catch { }
                try { g.SetFeature("TriggerSource", triggerLine); } catch { }
                try { g.SetFeature("TriggerActivation", edge); } catch { }
            }

            // 4. ⚠️ Auto 模式不要调 StartAcquire！
            //    外部触发到来时相机自动开始采集，调了反而和硬件信号冲突

            IsAcquiring = true;
            IsLive = false;
            ConnectionState = CameraConnectionState.Acquiring;
        }

        /// <summary>
        /// 硬件半自动模式（先武装 FIFO，等外部触发才出图）
        /// 需要 StartAcquire 武装 → 外部信号到来 → 真正采集一帧
        /// </summary>
        public void StartHardwareSemi(string triggerLine = "Line0", string edge = "RisingEdge")
        {
            if (_acq == null) throw new InvalidOperationException("请先 CreateFifo");

            //Stop();

            // 2. 设置 FIFO 触发模型为 Semi
            SetTriggerModel(CogAcqTriggerModelConstants.Semi);

            // 3. 配置相机端硬触发（GigE）
            var g = _acq.FrameGrabber?.OwnedGigEAccess;
            if (g != null)
            {
                try { g.SetFeature("TriggerMode", "On"); } catch { }
                try { g.SetFeature("TriggerSource", triggerLine); } catch { }
                try { g.SetFeature("TriggerActivation", edge); } catch { }
            }

            // 4. ⚠️ Semi 模式必须调 StartAcquire 武装 FIFO
            //    武装后，外部触发到来才真正出图；不武装则触发来了也不取
            _acq.StartAcquire();

            IsAcquiring = true;
            IsLive = false;
            ConnectionState = CameraConnectionState.Acquiring;
        }

        /// <summary>
        /// 预览模式（连续采集，不抛 FrameAcquired 事件，由外部直接读）
        /// </summary>
        public void StartLive()
        {
            if (_acq == null) throw new InvalidOperationException("请先 CreateFifo");
            //Stop();

            SetTriggerModel(CogAcqTriggerModelConstants.FreeRun);            

            GetAcqFifo.Invoke(_acq);
            IsAcquiring = true;
            IsLive = true;
            ConnectionState = CameraConnectionState.Acquiring;
        }

        /// <summary>
        /// 业务模式（单帧/连续，Complete 事件抛 FrameAcquired）
        /// </summary>
        public void StartSingle()
        {
            if (_acq == null) throw new InvalidOperationException("请先 CreateFifo");
            //Stop();

            // 只在需要时才切模式            
            if (_acq.OwnedTriggerParams.TriggerModel != CogAcqTriggerModelConstants.Manual)
                SetTriggerModel(CogAcqTriggerModelConstants.Manual);

            //Console.WriteLine("单次触发模式"+_acq.OwnedTriggerParams.TriggerModel);
            //Console.WriteLine("模式启动"+ _acq.OwnedTriggerParams.TriggerEnabled);            
            _acq.StartAcquire();
                        
            IsAcquiring = true;
            IsLive = false;
            ConnectionState = CameraConnectionState.Acquiring;
        }

        /// <summary>
        /// 停止采集
        /// </summary>
        public void Stop()
        {
            if (_acq != null)
            {
                // 1. 停触发 + 清队列
                _acq.OwnedTriggerParams.TriggerEnabled = false;                
                try { _acq.Flush(); } catch { }
            }
            IsAcquiring = false;
            IsLive = false;
            ConnectionState = IsConnected ? CameraConnectionState.Ready : CameraConnectionState.Disconnected;
        }

        /// <summary>
        /// 应用曝光参数
        /// </summary>
        public void ApplyExposure()
        {
            if (_acq != null)
                _acq.OwnedExposureParams.Exposure = ExposureMs;
        }

        /// <summary>
        /// 应用增益（若相机支持）
        /// </summary>
        public void ApplyGain()
        {
            // VisionPro 增益通常通过 GenTL 特性或 Imaging 参数设置
            // 这里留扩展点
            try
            {
                // 部分采集卡/相机支持：
                 //_acq.OwnedImagingParams.Gain = Gain;
            }
            catch { }
        }

        /// <summary>
        /// 应用触发模式
        /// </summary>
        public void ApplyTrigger()
        {
            if (_acq != null)
            {
                _acq.OwnedTriggerParams.TriggerModel = TriggerMode;
            }
        }

        /// <summary>
        /// 断开连接
        /// </summary>
        public void Disconnect()
        {
            Stop();
            if (_acq != null)
            {
                _acq.Complete -= OnAcqComplete;
                _acq = null;
            }
            if (_grabber != null)
            {
                try { _grabber.Disconnect(false); } catch { }
                _grabber = null;
            }
            IsConnected = false;
            IsInitialized = false;
            ConnectionState = CameraConnectionState.Disconnected;
        }

        /// <summary>
        /// 释放资源
        /// </summary>
        public void Dispose()
        {
            Disconnect();
        }

        // ============================================================
        // 私有方法
        // ============================================================

        /*
                private void OnAcqComplete(object sender, CogCompleteEventArgs e)
                {
                    try
                    {
                        if (IsLive)
                            return;  // 预览模式不抛事件（由 cogRecordDisplay 自己读）

                        // 不判断 ready，直接尝试取帧
                        var info = new CogAcqInfo();
                        ICogImage img = null;

                        try
                        {
                            img = _acq.CompleteAcquireEx(info);
                        }
                        catch
                        {                    
                            return;  // 取不到就跳过，不抛异常
                        }

                        if (img != null)
                        {
                            FrameAcquired?.Invoke(this, new FrameAcquiredEventArgs(img));
                        }

                        // 单帧模式取完自动停
                        if (!IsLive && IsAcquiring)
                        {                    
                            IsAcquiring = false;
                            ConnectionState = CameraConnectionState.Ready;
                        }
                    }
                    catch (Exception ex)
                    {
                        LastError = ex.Message;
                        ErrorOccurred?.Invoke(this, new CameraErrorEventArgs("取帧失败", ex));
                    }
                }
        */
        private void OnAcqComplete(object sender, CogCompleteEventArgs e)
        {
            try
            {                
                if (IsLive)
                {
                    // 预览模式：不抛事件，由外部直接读 CurrentImage
                    return;
                }
                // 业务模式：取帧并抛事件
                _acq.GetFifoState(out _, out int ready, out _);
                if (ready <= 0) return;

                var info = new CogAcqInfo();
                ICogImage img = _acq.CompleteAcquireEx(info);
                FrameAcquired?.Invoke(this, new FrameAcquiredEventArgs(img));
            }
            catch (Exception ex)
            {
                LastError = ex.Message;
                ErrorOccurred?.Invoke(this, new CameraErrorEventArgs("取帧失败", ex));
            }
        }

        private CogAcqFifoPixelFormatConstants InferPixelFormat(string videoFormat)
        {
            var s = videoFormat.ToUpper();
            if (s.Contains("BAYER") || s.Contains("RGB") || s.Contains("COLOR"))
                return CogAcqFifoPixelFormatConstants.Format32RGB;
            if (s.Contains("MONO10") || s.Contains("MONO12") || s.Contains("10") || s.Contains("12"))
                return CogAcqFifoPixelFormatConstants.Format16Grey;
            return CogAcqFifoPixelFormatConstants.Format8Grey;
        }

        private string ParseVendor(string name)
        {
            if (name.Contains("Hikrobot") || name.Contains("Hik")) return "Hikrobot";
            if (name.Contains("Basler")) return "Basler";
            if (name.Contains("Sony")) return "Sony";
            return "Unknown";
        }

        private string ParseModel(string name)
        {
            // 从 "GigE Vision: Hikrobot: MV-CS060-10GC" 提取型号部分
            var parts = name.Split(':');
            return parts.Length >= 3 ? parts[2].Trim() : name;
        }
    }
}
