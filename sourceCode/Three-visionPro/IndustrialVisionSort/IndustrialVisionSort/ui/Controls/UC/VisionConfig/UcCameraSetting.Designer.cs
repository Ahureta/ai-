namespace IndustrialVisionSort.ui.Controls.UC.ControlConfig
{
    partial class UcCameraSetting
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcCameraSetting));
            this.panel2 = new AntdUI.Panel();
            this.splitter1 = new AntdUI.Splitter();
            this.select3 = new AntdUI.Select();
            this.tag2 = new AntdUI.Tag();
            this.SELVideoFormat = new AntdUI.Select();
            this.SELImageSource = new AntdUI.Select();
            this.BTConnectCamera = new AntdUI.Button();
            this.BTLostCamera = new AntdUI.Button();
            this.BTLivePreview = new AntdUI.Button();
            this.SELBagSize = new AntdUI.Select();
            this.BTStopPreview = new AntdUI.Button();
            this.BTInitializeCapture = new AntdUI.Button();
            this.BTSingleShot = new AntdUI.Button();
            this.input2 = new AntdUI.Input();
            this.input1 = new AntdUI.Input();
            this.input3 = new AntdUI.Input();
            this.IPExposure = new AntdUI.Input();
            this.label1 = new AntdUI.Label();
            this.LBVideoFormat = new AntdUI.Label();
            this.LBImageSource = new AntdUI.Label();
            this.label2 = new AntdUI.Label();
            this.label4 = new AntdUI.Label();
            this.label3 = new AntdUI.Label();
            this.label18 = new AntdUI.Label();
            this.INDelayLevel = new AntdUI.Label();
            this.cogRecordDisplay1 = new Cognex.VisionPro.CogRecordDisplay();
            this.tag1 = new AntdUI.Tag();
            this.TagCameraSetting = new AntdUI.Tag();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitter1)).BeginInit();
            this.splitter1.Panel1.SuspendLayout();
            this.splitter1.Panel2.SuspendLayout();
            this.splitter1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.panel2.BorderWidth = 1F;
            this.panel2.Controls.Add(this.splitter1);
            this.panel2.Controls.Add(this.TagCameraSetting);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 750);
            this.panel2.TabIndex = 1;
            this.panel2.Text = "panel2";
            // 
            // splitter1
            // 
            this.splitter1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitter1.Location = new System.Drawing.Point(2, 38);
            this.splitter1.Name = "splitter1";
            // 
            // splitter1.Panel1
            // 
            this.splitter1.Panel1.Controls.Add(this.select3);
            this.splitter1.Panel1.Controls.Add(this.tag2);
            this.splitter1.Panel1.Controls.Add(this.SELVideoFormat);
            this.splitter1.Panel1.Controls.Add(this.SELImageSource);
            this.splitter1.Panel1.Controls.Add(this.BTConnectCamera);
            this.splitter1.Panel1.Controls.Add(this.BTLostCamera);
            this.splitter1.Panel1.Controls.Add(this.BTLivePreview);
            this.splitter1.Panel1.Controls.Add(this.SELBagSize);
            this.splitter1.Panel1.Controls.Add(this.BTStopPreview);
            this.splitter1.Panel1.Controls.Add(this.BTInitializeCapture);
            this.splitter1.Panel1.Controls.Add(this.BTSingleShot);
            this.splitter1.Panel1.Controls.Add(this.input2);
            this.splitter1.Panel1.Controls.Add(this.input1);
            this.splitter1.Panel1.Controls.Add(this.input3);
            this.splitter1.Panel1.Controls.Add(this.IPExposure);
            this.splitter1.Panel1.Controls.Add(this.label1);
            this.splitter1.Panel1.Controls.Add(this.LBVideoFormat);
            this.splitter1.Panel1.Controls.Add(this.LBImageSource);
            this.splitter1.Panel1.Controls.Add(this.label2);
            this.splitter1.Panel1.Controls.Add(this.label4);
            this.splitter1.Panel1.Controls.Add(this.label3);
            this.splitter1.Panel1.Controls.Add(this.label18);
            this.splitter1.Panel1.Controls.Add(this.INDelayLevel);
            // 
            // splitter1.Panel2
            // 
            this.splitter1.Panel2.Controls.Add(this.cogRecordDisplay1);
            this.splitter1.Panel2.Controls.Add(this.tag1);
            this.splitter1.Size = new System.Drawing.Size(1196, 710);
            this.splitter1.SplitterDistance = 486;
            this.splitter1.TabIndex = 8;
            // 
            // select3
            // 
            this.select3.Empty = true;
            this.select3.Location = new System.Drawing.Point(159, 179);
            this.select3.Name = "select3";
            this.select3.Size = new System.Drawing.Size(127, 45);
            this.select3.TabIndex = 26;
            // 
            // tag2
            // 
            this.tag2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tag2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tag2.Location = new System.Drawing.Point(0, 0);
            this.tag2.Name = "tag2";
            this.tag2.Size = new System.Drawing.Size(486, 42);
            this.tag2.TabIndex = 0;
            this.tag2.Text = "参数控制区";
            this.tag2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SELVideoFormat
            // 
            this.SELVideoFormat.Empty = true;
            this.SELVideoFormat.Location = new System.Drawing.Point(13, 179);
            this.SELVideoFormat.Name = "SELVideoFormat";
            this.SELVideoFormat.ReadOnly = true;
            this.SELVideoFormat.Size = new System.Drawing.Size(140, 45);
            this.SELVideoFormat.TabIndex = 25;
            // 
            // SELImageSource
            // 
            this.SELImageSource.Empty = true;
            this.SELImageSource.Location = new System.Drawing.Point(13, 88);
            this.SELImageSource.Name = "SELImageSource";
            this.SELImageSource.ReadOnly = true;
            this.SELImageSource.Size = new System.Drawing.Size(312, 45);
            this.SELImageSource.TabIndex = 24;
            // 
            // BTConnectCamera
            // 
            this.BTConnectCamera.BorderWidth = 1F;
            this.BTConnectCamera.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTConnectCamera.Location = new System.Drawing.Point(13, 242);
            this.BTConnectCamera.Name = "BTConnectCamera";
            this.BTConnectCamera.Size = new System.Drawing.Size(84, 37);
            this.BTConnectCamera.TabIndex = 7;
            this.BTConnectCamera.Text = "连接相机";
            // 
            // BTLostCamera
            // 
            this.BTLostCamera.BorderWidth = 1F;
            this.BTLostCamera.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTLostCamera.Location = new System.Drawing.Point(106, 242);
            this.BTLostCamera.Name = "BTLostCamera";
            this.BTLostCamera.Size = new System.Drawing.Size(84, 37);
            this.BTLostCamera.TabIndex = 8;
            this.BTLostCamera.Text = "断开相机";
            // 
            // BTLivePreview
            // 
            this.BTLivePreview.BorderWidth = 1F;
            this.BTLivePreview.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTLivePreview.Location = new System.Drawing.Point(196, 242);
            this.BTLivePreview.Name = "BTLivePreview";
            this.BTLivePreview.Size = new System.Drawing.Size(84, 37);
            this.BTLivePreview.TabIndex = 9;
            this.BTLivePreview.Text = "实时预览";
            this.BTLivePreview.Click += new System.EventHandler(this.BTLivePreview_Click);
            // 
            // SELBagSize
            // 
            this.SELBagSize.Location = new System.Drawing.Point(93, 525);
            this.SELBagSize.Name = "SELBagSize";
            this.SELBagSize.Size = new System.Drawing.Size(119, 54);
            this.SELBagSize.TabIndex = 21;
            // 
            // BTStopPreview
            // 
            this.BTStopPreview.BorderWidth = 1F;
            this.BTStopPreview.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTStopPreview.Location = new System.Drawing.Point(286, 242);
            this.BTStopPreview.Name = "BTStopPreview";
            this.BTStopPreview.Size = new System.Drawing.Size(84, 37);
            this.BTStopPreview.TabIndex = 10;
            this.BTStopPreview.Text = "停止预览";
            this.BTStopPreview.Click += new System.EventHandler(this.BTStopPreview_Click);
            // 
            // BTInitializeCapture
            // 
            this.BTInitializeCapture.BorderWidth = 1F;
            this.BTInitializeCapture.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTInitializeCapture.Location = new System.Drawing.Point(300, 179);
            this.BTInitializeCapture.Name = "BTInitializeCapture";
            this.BTInitializeCapture.Size = new System.Drawing.Size(160, 45);
            this.BTInitializeCapture.TabIndex = 6;
            this.BTInitializeCapture.Text = "初始化取相";
            // 
            // BTSingleShot
            // 
            this.BTSingleShot.BorderWidth = 1F;
            this.BTSingleShot.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTSingleShot.Location = new System.Drawing.Point(376, 242);
            this.BTSingleShot.Name = "BTSingleShot";
            this.BTSingleShot.Size = new System.Drawing.Size(84, 37);
            this.BTSingleShot.TabIndex = 11;
            this.BTSingleShot.Text = "单次拍照";
            this.BTSingleShot.Click += new System.EventHandler(this.BTSingleShot_Click);
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(93, 465);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(119, 54);
            this.input2.TabIndex = 20;
            this.input2.Text = "1";
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(93, 345);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(119, 54);
            this.input1.TabIndex = 20;
            this.input1.Text = "0.524";
            // 
            // input3
            // 
            this.input3.Location = new System.Drawing.Point(93, 405);
            this.input3.Name = "input3";
            this.input3.Size = new System.Drawing.Size(119, 54);
            this.input3.TabIndex = 20;
            this.input3.Text = "0";
            // 
            // IPExposure
            // 
            this.IPExposure.Location = new System.Drawing.Point(93, 285);
            this.IPExposure.Name = "IPExposure";
            this.IPExposure.Size = new System.Drawing.Size(119, 54);
            this.IPExposure.TabIndex = 20;
            this.IPExposure.Text = "50";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(164, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 34);
            this.label1.TabIndex = 17;
            this.label1.Text = "照相机端口：";
            // 
            // LBVideoFormat
            // 
            this.LBVideoFormat.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LBVideoFormat.Location = new System.Drawing.Point(23, 140);
            this.LBVideoFormat.Name = "LBVideoFormat";
            this.LBVideoFormat.Size = new System.Drawing.Size(98, 34);
            this.LBVideoFormat.TabIndex = 16;
            this.LBVideoFormat.Text = "视屏格式：";
            // 
            // LBImageSource
            // 
            this.LBImageSource.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LBImageSource.Location = new System.Drawing.Point(23, 48);
            this.LBImageSource.Name = "LBImageSource";
            this.LBImageSource.Size = new System.Drawing.Size(236, 34);
            this.LBImageSource.TabIndex = 15;
            this.LBImageSource.Text = "图片采集设备/图像采集卡：";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(23, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 54);
            this.label2.TabIndex = 14;
            this.label2.Text = "曝光";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(23, 345);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 54);
            this.label4.TabIndex = 13;
            this.label4.Text = "亮度";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(23, 405);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 54);
            this.label3.TabIndex = 12;
            this.label3.Text = "对比度";
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(23, 525);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 54);
            this.label18.TabIndex = 19;
            this.label18.Text = "包大小";
            // 
            // INDelayLevel
            // 
            this.INDelayLevel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.INDelayLevel.Location = new System.Drawing.Point(23, 465);
            this.INDelayLevel.Name = "INDelayLevel";
            this.INDelayLevel.Size = new System.Drawing.Size(72, 54);
            this.INDelayLevel.TabIndex = 18;
            this.INDelayLevel.Text = "延迟级别";
            // 
            // cogRecordDisplay1
            // 
            this.cogRecordDisplay1.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplay1.ColorMapLowerRoiLimit = 0D;
            this.cogRecordDisplay1.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cogRecordDisplay1.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplay1.ColorMapUpperRoiLimit = 1D;
            this.cogRecordDisplay1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cogRecordDisplay1.DoubleTapZoomCycleLength = 2;
            this.cogRecordDisplay1.DoubleTapZoomSensitivity = 2.5D;
            this.cogRecordDisplay1.Location = new System.Drawing.Point(0, 42);
            this.cogRecordDisplay1.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogRecordDisplay1.MouseWheelSensitivity = 1D;
            this.cogRecordDisplay1.Name = "cogRecordDisplay1";
            this.cogRecordDisplay1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogRecordDisplay1.OcxState")));
            this.cogRecordDisplay1.Size = new System.Drawing.Size(706, 668);
            this.cogRecordDisplay1.TabIndex = 5;
            // 
            // tag1
            // 
            this.tag1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tag1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tag1.Location = new System.Drawing.Point(0, 0);
            this.tag1.Name = "tag1";
            this.tag1.Size = new System.Drawing.Size(706, 42);
            this.tag1.TabIndex = 0;
            this.tag1.Text = "图像预览区";
            this.tag1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TagCameraSetting
            // 
            this.TagCameraSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.TagCameraSetting.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TagCameraSetting.Location = new System.Drawing.Point(2, 2);
            this.TagCameraSetting.Name = "TagCameraSetting";
            this.TagCameraSetting.Size = new System.Drawing.Size(1196, 36);
            this.TagCameraSetting.TabIndex = 2;
            this.TagCameraSetting.Text = "相机设置";
            this.TagCameraSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UcCameraSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "UcCameraSetting";
            this.Size = new System.Drawing.Size(1200, 750);
            this.panel2.ResumeLayout(false);
            this.splitter1.Panel1.ResumeLayout(false);
            this.splitter1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitter1)).EndInit();
            this.splitter1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Panel panel2;
        private AntdUI.Tag TagCameraSetting;
        private Cognex.VisionPro.CogRecordDisplay cogRecordDisplay1;
        private AntdUI.Tag tag1;
        private AntdUI.Splitter splitter1;
        private AntdUI.Select select3;
        private AntdUI.Tag tag2;
        private AntdUI.Select SELVideoFormat;
        private AntdUI.Select SELImageSource;
        private AntdUI.Button BTConnectCamera;
        private AntdUI.Button BTLostCamera;
        private AntdUI.Button BTLivePreview;
        private AntdUI.Button BTStopPreview;
        private AntdUI.Button BTInitializeCapture;
        private AntdUI.Button BTSingleShot;
        private AntdUI.Input IPExposure;
        private AntdUI.Label label1;
        private AntdUI.Label LBVideoFormat;
        private AntdUI.Label LBImageSource;
        private AntdUI.Label label2;
        private AntdUI.Label label4;
        private AntdUI.Label label3;
        private AntdUI.Label label18;
        private AntdUI.Label INDelayLevel;
        private AntdUI.Select SELBagSize;
        private AntdUI.Input input2;
        private AntdUI.Input input1;
        private AntdUI.Input input3;
    }
}
