using Cognex.VisionPro;
using IndustrialVisionSort.Application;
using IndustrialVisionSort.DoMain.Events;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndustrialVisionSort.ui.Controls.UC.ControlConfig
{
    public partial class UcCameraSetting : UserControl
    {
        private readonly CameraSettingService _cameraSettingService = new CameraSettingService();
        private bool _liveMode = false;
        //private CogFrameGrabbers _grabbers;
        //private ICogAcqFifo _acq;        
        public UcCameraSetting()
        {
            InitializeComponent();
            Init();
        }
        private void Init() {
            SetImageSource(_cameraSettingService.GetImageSource());            

            SELImageSource.SelectedValueChanged += SELImageSource_SelectedValueChanged;

            BTInitializeCapture.Click += BTInitializeCapture_Click;

            _cameraSettingService.FrameAcquired += CameraService_FrameAcquired;
        }

        private void CameraService_FrameAcquired(object sender, FrameAcquiredEventArgs e)
        {
            if (this.IsDisposed || !this.IsHandleCreated) return;

            // 必须在 UI 线程操作控件
            if (this.InvokeRequired)
            {
                this.Invoke(new EventHandler<FrameAcquiredEventArgs>(CameraService_FrameAcquired), sender, e);
                return;
            }

            try
            {
                if (e.Image != null)
                {
                    // 直接显示图像（如果是灰度图，强制转一下类型更安全）
                    //cogRecordDisplay1.Image = (CogImage8Grey)e.Image;
                    cogRecordDisplay1.Image = e.Image;
                    cogRecordDisplay1.Refresh();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"显示图像失败: {ex.Message}");
            }
        }

        private void BTInitializeCapture_Click(object sender, EventArgs e)
        {
            _cameraSettingService.GetAcqFifo((string)SELVideoFormat.SelectedValue);
        }

        private void SELImageSource_SelectedValueChanged(object sender, AntdUI.ObjectNEventArgs e)
        {
            ICogFrameGrabber cogFrameGrabber = (ICogFrameGrabber)e;            
            SetVideoFormat(_cameraSettingService.GetVideoFormat(cogFrameGrabber));
        }

        private void SetVideoFormat(CogStringCollection cogStringCollection)
        {
            Action update = () =>
            {
                // 清空现有项并将每个抓取器逐项加入 Items
                SELVideoFormat.Items.Clear();
                foreach (string g in cogStringCollection)
                {
                    SELVideoFormat.Items.Add(g);
                }
            };

            if (InvokeRequired)
            {
                BeginInvoke(update);
                return;
            }

            update();            
        }

        private void SetImageSource(CogFrameGrabbers cogFrameGrabbers)
        {
            Action update = () =>
            {
                // 清空现有项并将每个抓取器逐项加入 Items
                SELImageSource.Items.Clear();
                foreach (ICogFrameGrabber g in cogFrameGrabbers)
                {
                    SELImageSource.Items.Add(g);
                }
            };

            if (InvokeRequired)
            {
                BeginInvoke(update);
                return;
            }

            update();
        }

        private void BTStopPreview_Click(object sender, EventArgs e)
        {
            if (_liveMode)
            {
                cogRecordDisplay1.StopLiveDisplay();
                _liveMode = false;
            }
        }
        private void BTSingleShot_Click(object sender, EventArgs e)
        {
            // 1. 停掉可能的 live
            if (cogRecordDisplay1.LiveDisplayRunning)
                cogRecordDisplay1.StopLiveDisplay();

            // 2. 告诉 service 这是业务模式
            _cameraSettingService.SetMode(false);

            // 3. 开始采（Complete 事件会取图抛回来）
            _cameraSettingService.StartAcquisition();

            //if (_liveMode) return; // 预览模式下不处理
            //_cameraSettingService.StartBusinessMode();
        }

        private void BTLivePreview_Click(object sender, EventArgs e)
        {
            if (!_cameraSettingService.IsAcqReady) return;

            // 1. 告诉 service 这是预览模式（Complete 里不处理）
            _cameraSettingService.SetMode(true);

            // 2. UI 层自己调 StartLiveDisplay（把 acq 交给 display 控件）
            if (!cogRecordDisplay1.LiveDisplayRunning)
            {
                cogRecordDisplay1.StartLiveDisplay(_cameraSettingService.CurrentAcqFifo);
            }

            // 3. 开始采（fifo 开始往队列塞图，display 自己取自己画）
            //_cameraSettingService.StartAcquisition();

            //cogRecordDisplay1.StartLiveDisplay(_cameraSettingService.CurrentAcqFifo); // 把同一个 acq 交给显示控件
            //_cameraSettingService.StartLiveMode();
            //_liveMode = true;
        }
    }
}
