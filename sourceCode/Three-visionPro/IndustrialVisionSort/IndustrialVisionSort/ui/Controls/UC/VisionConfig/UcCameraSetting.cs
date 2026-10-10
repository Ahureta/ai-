using Cognex.VisionPro;
using IndustrialVisionSort.Application;
using IndustrialVisionSort.DoMain.Entities;
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
        private readonly CameraService _cameraSettingService = new CameraService();
        private bool _liveMode = false;             
        public UcCameraSetting()
        {
            InitializeComponent();
            Init();
        }
        private void Init()
        {            
            CBBImageSource.SelectedIndexChanged += CBBImageSource_SelectedIndexChanged;

            BTInitializeCapture.Click += BTInitializeCapture_Click;

            _cameraSettingService.FrameAcquired += CameraService_FrameAcquired;
        }

        private void CBBImageSource_SelectedIndexChanged(object sender, EventArgs e)
        {            
            var combo = sender as ComboBox;
            var item = combo?.SelectedItem as ComboBoxItem;
            if (item == null) return;

            var grabber = item.Value as ICogFrameGrabber;
            if (grabber == null) return;

            SetVideoFormat(_cameraSettingService.GetVideoFormat(grabber));
        }

        private bool _dataLoaded = false;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            if (DesignMode) return;

            if (!_dataLoaded)
            {
                _dataLoaded = true;
                Console.WriteLine(">>> OnLoad 加载相机列表");
                var grabbers = _cameraSettingService.GetImageSource();
                SetImageSource(grabbers);
            }
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

        private async void BTInitializeCapture_Click(object sender, EventArgs e)
        {
            if (!(CBBVideoFormat.SelectedItem is ComboBoxItem item && item.Value is string format))
            {
                MessageBox.Show("请先选择视频格式");
                return;
            }

            BTInitializeCapture.Enabled = false;  // 防重复点击
            Cursor = Cursors.WaitCursor;

            // 先弹提示
            AntdUI.Message.info(this.FindForm(), "正在初始化...", autoClose: 2);

            // 让出 UI 线程，让消息循环有机会渲染上面的提示
            await Task.Delay(150);

            try
            {
                _cameraSettingService.GetAcqFifo(format);
                AntdUI.Message.success(this.FindForm(), "初始化成功", autoClose: 3);
            }
            catch (Exception ex)
            {
                AntdUI.Message.error(this.FindForm(), $"初始化失败:\n{ex.Message}", autoClose: 5);
            }
            finally
            {
                Cursor = Cursors.Default;
                BTInitializeCapture.Enabled = true;
            }
        }

        private void SetVideoFormat(CogStringCollection cogStringCollection)
        {
            Action update = () =>
            {
                // 清空现有项并将每个抓取器逐项加入 Items
                CBBVideoFormat.Items.Clear();
                foreach (string g in cogStringCollection)
                {
                    //Console.WriteLine(g);
                    CBBVideoFormat.Items.Add(new ComboBoxItem(g, g));
                }

                // 默认选中第一项
                if (CBBVideoFormat.Items.Count > 0)
                    CBBVideoFormat.SelectedIndex = 0;
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
                CBBImageSource.Items.Clear();                

                if (cogFrameGrabbers.Count == 0)
                {
                    CBBImageSource.Items.Add(new AntdUI.SelectItem("未检测到相机/采集卡", null));
                    return;
                }
                
                foreach (ICogFrameGrabber g in cogFrameGrabbers)
                {
                    CBBImageSource.Items.Add(new ComboBoxItem(g.Name, g));
                }
                // 默认选中第一项
                if (CBBImageSource.Items.Count > 0)
                    CBBImageSource.SelectedIndex = 0;
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

            _liveMode = true;
        }
    }
}
