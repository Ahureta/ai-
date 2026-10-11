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
        private readonly CameraService _cameraService = new CameraService();
        private bool _liveMode = false;             
        public UcCameraSetting()
        {
            InitializeComponent();
            Init();            
        }
        private void Init()
        {
            // 图片采集设备/图像采集卡：
            _cameraService.GetCogFrameGrabbers += cogFrameGrabbers => {
                SetImageSource(cogFrameGrabbers);
            };
            _cameraService.InitializeImageSource();

            // 选择图片采集设备/图像采集卡后
            CBBImageSource.SelectedIndexChanged += CBBImageSource_SelectedIndexChanged;

            // 初始化取相
            BTInitializeCapture.Click += BTInitializeCapture_Click;

            _cameraService.GetAcqFifo += acqFifo => {
                cogRecordDisplay1.StartLiveDisplay(acqFifo);
            };

            // 显示属性
            _cameraService.InitializeAttribute += _cameraService_InitializeAttribute;

            // 取相操作
            _cameraService.FrameAcquired += CameraService_FrameAcquired;

            //bug
            _cameraService.ErrorOccurred += err => { MessageBox.Show(err); };
        }

        private void _cameraService_InitializeAttribute(Camera camera)
        {
            if (camera == null) return;

            var cameraType = typeof(Camera);
            var props = cameraType.GetProperties(
                System.Reflection.BindingFlags.Public |
                System.Reflection.BindingFlags.Instance);

            foreach (Control ctrl in PNAttribute.Controls)
            {
                if (string.IsNullOrEmpty(ctrl.Name)) continue;

                string propName = null;

                // 标签：LB + 属性名
                if (ctrl.Name.StartsWith("LB"))
                    propName = ctrl.Name.Substring(2);

                // 输入框：IP + 属性名
                else if (ctrl.Name.StartsWith("IP"))
                    propName = ctrl.Name.Substring(2);

                if (string.IsNullOrEmpty(propName)) continue;

                // 忽略大小写匹配属性
                var prop = props.FirstOrDefault(p =>
                    string.Equals(p.Name, propName, StringComparison.OrdinalIgnoreCase));

                if (prop == null || !prop.CanRead) continue;

                object value;
                try { value = prop.GetValue(camera); }
                catch { continue; }

                string displayText;
                if (value == null)
                {
                    displayText = "-";
                }
                else if (value is CogStringCollection col)
                {
                    displayText = string.Join(", ", col.Cast<string>());
                }
                else
                {
                    displayText = value.ToString();
                }

                // 根据控件类型赋值
                if (ctrl.Name.StartsWith("LB"))
                {
                    ctrl.Text = displayText;
                }
                else if (ctrl.Name.StartsWith("IP"))
                {
                    if (ctrl is AntdUI.Input antInput)
                        antInput.Text = displayText;
                    else if (ctrl is TextBox txt)
                        txt.Text = displayText;
                    else if (ctrl is NumericUpDown nud && value is IConvertible conv)
                    {
                        decimal val = Convert.ToDecimal(conv);
                        nud.Value = Math.Min(Math.Max(val, nud.Minimum), nud.Maximum);
                    }
                    else
                        ctrl.Text = displayText;
                }
            }
        }


        private void CBBImageSource_SelectedIndexChanged(object sender, EventArgs e)
        {            
            var combo = sender as ComboBox;
            var item = combo?.SelectedItem as ComboBoxItem;
            if (item == null) return;

            var grabber = item.Value as ICogFrameGrabber;
            if (grabber == null) return;

            _cameraService.GetVideoFormat += videoFormat => {
                //MessageBox.Show("diyige"+videoFormat[0]);
                SetVideoFormat(videoFormat);
            };            
            _cameraService.InitializeVideoFormat(grabber);            
        }

        //private bool _dataLoaded = false;

        protected async override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (DesignMode) return;

            BTInitializeCapture.Enabled = false;  // 先禁用            
            LBstatus.Text = "正在初始化...";

            _cameraService.StatusChanged += msg => LBstatus.Text = msg;
            _cameraService.Ready += () =>
            {
                LBstatus.Text = "就绪";
                BTInitializeCapture.Enabled = true;                
            };

            #region    测试
            //base.OnLoad(e);
            //if (DesignMode || _dataLoaded) return;

            //_dataLoaded = true;

            //try
            //{
            //    var cameraNames = await Task.Run(() =>
            //    {
            //        var grabbers = _cameraService.GetImageSource();
            //        var list = new List<(string Name, string Serial)>();

            //        foreach (ICogFrameGrabber g in grabbers)
            //        {
            //            // 在后台线程访问耗时的 COM 属性
            //            list.Add((g.Name, g.SerialNumber));
            //        }

            //        return list;
            //    });

            //    // UI 线程只做“绑定纯数据”，不再访问相机对象
            //    CBBImageSource.Items.Clear();
            //    foreach (var cam in cameraNames)
            //        CBBImageSource.Items.Add(cam.Name);

            //    if (CBBImageSource.Items.Count > 0)
            //        CBBImageSource.SelectedIndex = 0;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show($"加载相机列表失败：{ex.Message}");
            //}

            //Action LoadCameraListAsync = async () => {
            //    try
            //    {
            //        var grabbers = await Task.Run(() => _cameraService.GetImageSource());
            //        SetImageSource(grabbers);
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show($"加载相机列表失败：{ex.Message}");
            //    }
            //};

            //base.OnLoad(e);

            //if (DesignMode || _dataLoaded) return;

            //_dataLoaded = true;
            //await LoadCameraListAsync();

            //if (DesignMode) return;

            //if (!_dataLoaded)
            //{
            //    _dataLoaded = true;
            //    Console.WriteLine(">>> OnLoad 加载相机列表");
            //    var grabbers = _cameraService.GetImageSource();
            //    SetImageSource(grabbers);
            //}
            //}
            #endregion
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
            var serialItem = CBBImageSource.SelectedItem as ComboBoxItem;
            if (serialItem == null || serialItem.Value == null)
            {
                MessageBox.Show("请先选择相机");
                return;
            }
            var serial = serialItem.Value as ICogFrameGrabber;
            if (serial == null)
            {
                MessageBox.Show("相机选择无效");
                return;
            }

            var formatItem = CBBVideoFormat.SelectedItem as ComboBoxItem;
            if (formatItem == null || formatItem.Value == null)
            {
                MessageBox.Show("请先选择视频格式");
                return;
            }
            string format = formatItem.Value as string;
            if (string.IsNullOrEmpty(format))
            {
                MessageBox.Show("视频格式无效");
                return;
            }

            Console.WriteLine(serial.Name);
            Console.WriteLine(format);
            _cameraService.InitializeCapture(serial.Name, format);
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
                    CBBImageSource.Items.Add(new ComboBoxItem("未检测到相机/采集卡", null));
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
            cogRecordDisplay1.StopLiveDisplay();
            _cameraService.Stop();
            _liveMode = false;
        }
        private void BTSingleShot_Click(object sender, EventArgs e)
        {
            // 1. 停掉可能的 live
            //if (cogRecordDisplay1.LiveDisplayRunning)
                //cogRecordDisplay1.StopLiveDisplay();

            //_cameraService.Stop();

            _cameraService.SetManual();
        }

        private void BTLivePreview_Click(object sender, EventArgs e)
        {
            _cameraService.SetFreeRun();
        }

        private void BTSemi_Click(object sender, EventArgs e)
        {
            _cameraService.SetSemi();
        }

        private void BTAuto_Click(object sender, EventArgs e)
        {
            _cameraService.SetAuto();
        }
    }
}
