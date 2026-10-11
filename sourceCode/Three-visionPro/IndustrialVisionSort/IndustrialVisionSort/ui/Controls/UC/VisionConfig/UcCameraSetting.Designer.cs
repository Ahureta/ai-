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
            this.LBImageSource = new AntdUI.Label();
            this.LBVideoFormat = new AntdUI.Label();
            this.label1 = new AntdUI.Label();
            this.LBstatus = new AntdUI.Label();
            this.CBBVideoFormat = new System.Windows.Forms.ComboBox();
            this.CBBImageSource = new System.Windows.Forms.ComboBox();
            this.select3 = new AntdUI.Select();
            this.tag2 = new AntdUI.Tag();
            this.BTAuto = new AntdUI.Button();
            this.BTSemi = new AntdUI.Button();
            this.BTLivePreview = new AntdUI.Button();
            this.BTStopPreview = new AntdUI.Button();
            this.BTInitializeCapture = new AntdUI.Button();
            this.BTSingleShot = new AntdUI.Button();
            this.PNAttribute = new AntdUI.In.Panel();
            this.IPDelayLevel = new AntdUI.Input();
            this.IPTimeOut = new AntdUI.Input();
            this.IPBagSize = new AntdUI.Input();
            this.IPLight = new AntdUI.Input();
            this.IPContrast = new AntdUI.Input();
            this.IPExposureMS = new AntdUI.Input();
            this.LBSerialNumber = new AntdUI.Label();
            this.LBModel = new AntdUI.Label();
            this.LBWidthWithHeight = new AntdUI.Label();
            this.LBMacAddress = new AntdUI.Label();
            this.LBHostIpAddress = new AntdUI.Label();
            this.label16 = new AntdUI.Label();
            this.LBCurrentIpAddress = new AntdUI.Label();
            this.label14 = new AntdUI.Label();
            this.label12 = new AntdUI.Label();
            this.label10 = new AntdUI.Label();
            this.label8 = new AntdUI.Label();
            this.label6 = new AntdUI.Label();
            this.label2 = new AntdUI.Label();
            this.label4 = new AntdUI.Label();
            this.label3 = new AntdUI.Label();
            this.label5 = new AntdUI.Label();
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
            this.PNAttribute.SuspendLayout();
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
            this.splitter1.Panel1.Controls.Add(this.LBImageSource);
            this.splitter1.Panel1.Controls.Add(this.LBVideoFormat);
            this.splitter1.Panel1.Controls.Add(this.PNAttribute);
            this.splitter1.Panel1.Controls.Add(this.label1);
            this.splitter1.Panel1.Controls.Add(this.LBstatus);
            this.splitter1.Panel1.Controls.Add(this.CBBVideoFormat);
            this.splitter1.Panel1.Controls.Add(this.CBBImageSource);
            this.splitter1.Panel1.Controls.Add(this.select3);
            this.splitter1.Panel1.Controls.Add(this.tag2);
            this.splitter1.Panel1.Controls.Add(this.BTAuto);
            this.splitter1.Panel1.Controls.Add(this.BTSemi);
            this.splitter1.Panel1.Controls.Add(this.BTLivePreview);
            this.splitter1.Panel1.Controls.Add(this.BTStopPreview);
            this.splitter1.Panel1.Controls.Add(this.BTInitializeCapture);
            this.splitter1.Panel1.Controls.Add(this.BTSingleShot);
            // 
            // splitter1.Panel2
            // 
            this.splitter1.Panel2.Controls.Add(this.cogRecordDisplay1);
            this.splitter1.Panel2.Controls.Add(this.tag1);
            this.splitter1.Size = new System.Drawing.Size(1196, 710);
            this.splitter1.SplitterDistance = 486;
            this.splitter1.TabIndex = 8;
            // 
            // LBImageSource
            // 
            this.LBImageSource.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LBImageSource.Location = new System.Drawing.Point(13, 48);
            this.LBImageSource.Name = "LBImageSource";
            this.LBImageSource.Size = new System.Drawing.Size(236, 34);
            this.LBImageSource.TabIndex = 15;
            this.LBImageSource.Text = "图片采集设备/图像采集卡：";
            // 
            // LBVideoFormat
            // 
            this.LBVideoFormat.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LBVideoFormat.Location = new System.Drawing.Point(13, 117);
            this.LBVideoFormat.Name = "LBVideoFormat";
            this.LBVideoFormat.Size = new System.Drawing.Size(98, 34);
            this.LBVideoFormat.TabIndex = 16;
            this.LBVideoFormat.Text = "视屏格式：";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(10, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 34);
            this.label1.TabIndex = 17;
            this.label1.Text = "照相机端口：";
            // 
            // LBstatus
            // 
            this.LBstatus.Location = new System.Drawing.Point(343, 59);
            this.LBstatus.Name = "LBstatus";
            this.LBstatus.Size = new System.Drawing.Size(100, 23);
            this.LBstatus.TabIndex = 30;
            this.LBstatus.Text = "加载中/失败";
            // 
            // CBBVideoFormat
            // 
            this.CBBVideoFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBBVideoFormat.FormattingEnabled = true;
            this.CBBVideoFormat.Location = new System.Drawing.Point(13, 157);
            this.CBBVideoFormat.Name = "CBBVideoFormat";
            this.CBBVideoFormat.Size = new System.Drawing.Size(430, 23);
            this.CBBVideoFormat.TabIndex = 29;
            // 
            // CBBImageSource
            // 
            this.CBBImageSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBBImageSource.FormattingEnabled = true;
            this.CBBImageSource.Location = new System.Drawing.Point(13, 88);
            this.CBBImageSource.Name = "CBBImageSource";
            this.CBBImageSource.Size = new System.Drawing.Size(430, 23);
            this.CBBImageSource.TabIndex = 29;
            // 
            // select3
            // 
            this.select3.Empty = true;
            this.select3.Location = new System.Drawing.Point(122, 190);
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
            // BTAuto
            // 
            this.BTAuto.BorderWidth = 1F;
            this.BTAuto.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTAuto.Location = new System.Drawing.Point(10, 254);
            this.BTAuto.Name = "BTAuto";
            this.BTAuto.Size = new System.Drawing.Size(84, 37);
            this.BTAuto.TabIndex = 7;
            this.BTAuto.Text = "硬件自动";
            this.BTAuto.Click += new System.EventHandler(this.BTAuto_Click);
            // 
            // BTSemi
            // 
            this.BTSemi.BorderWidth = 1F;
            this.BTSemi.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTSemi.Location = new System.Drawing.Point(87, 254);
            this.BTSemi.Name = "BTSemi";
            this.BTSemi.Size = new System.Drawing.Size(107, 37);
            this.BTSemi.TabIndex = 8;
            this.BTSemi.Text = "硬件半自动";
            this.BTSemi.Click += new System.EventHandler(this.BTSemi_Click);
            // 
            // BTLivePreview
            // 
            this.BTLivePreview.BorderWidth = 1F;
            this.BTLivePreview.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTLivePreview.Location = new System.Drawing.Point(200, 254);
            this.BTLivePreview.Name = "BTLivePreview";
            this.BTLivePreview.Size = new System.Drawing.Size(84, 37);
            this.BTLivePreview.TabIndex = 9;
            this.BTLivePreview.Text = "实时预览";
            this.BTLivePreview.Click += new System.EventHandler(this.BTLivePreview_Click);
            // 
            // BTStopPreview
            // 
            this.BTStopPreview.BorderWidth = 1F;
            this.BTStopPreview.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTStopPreview.Location = new System.Drawing.Point(290, 254);
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
            this.BTInitializeCapture.Location = new System.Drawing.Point(283, 190);
            this.BTInitializeCapture.Name = "BTInitializeCapture";
            this.BTInitializeCapture.Size = new System.Drawing.Size(160, 45);
            this.BTInitializeCapture.TabIndex = 6;
            this.BTInitializeCapture.Text = "初始化取相";
            // 
            // BTSingleShot
            // 
            this.BTSingleShot.BorderWidth = 1F;
            this.BTSingleShot.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTSingleShot.Location = new System.Drawing.Point(380, 254);
            this.BTSingleShot.Name = "BTSingleShot";
            this.BTSingleShot.Size = new System.Drawing.Size(84, 37);
            this.BTSingleShot.TabIndex = 11;
            this.BTSingleShot.Text = "单次拍照";
            this.BTSingleShot.Click += new System.EventHandler(this.BTSingleShot_Click);
            // 
            // PNAttribute
            // 
            this.PNAttribute.Controls.Add(this.IPDelayLevel);
            this.PNAttribute.Controls.Add(this.IPTimeOut);
            this.PNAttribute.Controls.Add(this.IPBagSize);
            this.PNAttribute.Controls.Add(this.IPLight);
            this.PNAttribute.Controls.Add(this.IPContrast);
            this.PNAttribute.Controls.Add(this.IPExposureMS);
            this.PNAttribute.Controls.Add(this.LBSerialNumber);
            this.PNAttribute.Controls.Add(this.LBModel);
            this.PNAttribute.Controls.Add(this.LBWidthWithHeight);
            this.PNAttribute.Controls.Add(this.LBMacAddress);
            this.PNAttribute.Controls.Add(this.LBHostIpAddress);
            this.PNAttribute.Controls.Add(this.label16);
            this.PNAttribute.Controls.Add(this.LBCurrentIpAddress);
            this.PNAttribute.Controls.Add(this.label14);
            this.PNAttribute.Controls.Add(this.label12);
            this.PNAttribute.Controls.Add(this.label10);
            this.PNAttribute.Controls.Add(this.label8);
            this.PNAttribute.Controls.Add(this.label6);
            this.PNAttribute.Controls.Add(this.label2);
            this.PNAttribute.Controls.Add(this.label4);
            this.PNAttribute.Controls.Add(this.label3);
            this.PNAttribute.Controls.Add(this.label5);
            this.PNAttribute.Controls.Add(this.label18);
            this.PNAttribute.Controls.Add(this.INDelayLevel);
            this.PNAttribute.Location = new System.Drawing.Point(14, 288);
            this.PNAttribute.Name = "PNAttribute";
            this.PNAttribute.Size = new System.Drawing.Size(429, 399);
            this.PNAttribute.TabIndex = 31;
            this.PNAttribute.Text = "panel1";
            // 
            // IPDelayLevel
            // 
            this.IPDelayLevel.Location = new System.Drawing.Point(66, 169);
            this.IPDelayLevel.Name = "IPDelayLevel";
            this.IPDelayLevel.Size = new System.Drawing.Size(119, 54);
            this.IPDelayLevel.TabIndex = 20;
            this.IPDelayLevel.Text = "1";
            // 
            // IPTimeOut
            // 
            this.IPTimeOut.Location = new System.Drawing.Point(61, 289);
            this.IPTimeOut.Name = "IPTimeOut";
            this.IPTimeOut.Size = new System.Drawing.Size(119, 54);
            this.IPTimeOut.TabIndex = 20;
            this.IPTimeOut.Text = "2000毫秒";
            // 
            // IPBagSize
            // 
            this.IPBagSize.Location = new System.Drawing.Point(61, 229);
            this.IPBagSize.Name = "IPBagSize";
            this.IPBagSize.Size = new System.Drawing.Size(119, 54);
            this.IPBagSize.TabIndex = 20;
            this.IPBagSize.Text = "9000字";
            // 
            // IPLight
            // 
            this.IPLight.Location = new System.Drawing.Point(66, 60);
            this.IPLight.Name = "IPLight";
            this.IPLight.Size = new System.Drawing.Size(119, 54);
            this.IPLight.TabIndex = 20;
            this.IPLight.Text = "0.524";
            // 
            // IPContrast
            // 
            this.IPContrast.Location = new System.Drawing.Point(66, 109);
            this.IPContrast.Name = "IPContrast";
            this.IPContrast.Size = new System.Drawing.Size(119, 54);
            this.IPContrast.TabIndex = 20;
            this.IPContrast.Text = "0";
            // 
            // IPExposureMS
            // 
            this.IPExposureMS.Location = new System.Drawing.Point(66, 0);
            this.IPExposureMS.Name = "IPExposureMS";
            this.IPExposureMS.Size = new System.Drawing.Size(119, 54);
            this.IPExposureMS.TabIndex = 20;
            this.IPExposureMS.Text = "50MS";
            // 
            // LBSerialNumber
            // 
            this.LBSerialNumber.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LBSerialNumber.Location = new System.Drawing.Point(254, 60);
            this.LBSerialNumber.Name = "LBSerialNumber";
            this.LBSerialNumber.Size = new System.Drawing.Size(67, 54);
            this.LBSerialNumber.TabIndex = 14;
            this.LBSerialNumber.Text = "序列号：";
            // 
            // LBModel
            // 
            this.LBModel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LBModel.Location = new System.Drawing.Point(254, 0);
            this.LBModel.Name = "LBModel";
            this.LBModel.Size = new System.Drawing.Size(57, 54);
            this.LBModel.TabIndex = 14;
            this.LBModel.Text = "模型";
            // 
            // LBWidthWithHeight
            // 
            this.LBWidthWithHeight.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LBWidthWithHeight.Location = new System.Drawing.Point(254, 289);
            this.LBWidthWithHeight.Name = "LBWidthWithHeight";
            this.LBWidthWithHeight.Size = new System.Drawing.Size(57, 54);
            this.LBWidthWithHeight.TabIndex = 14;
            this.LBWidthWithHeight.Text = "宽高";
            // 
            // LBMacAddress
            // 
            this.LBMacAddress.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LBMacAddress.Location = new System.Drawing.Point(254, 109);
            this.LBMacAddress.Name = "LBMacAddress";
            this.LBMacAddress.Size = new System.Drawing.Size(57, 54);
            this.LBMacAddress.TabIndex = 14;
            this.LBMacAddress.Text = "固件：";
            // 
            // LBHostIpAddress
            // 
            this.LBHostIpAddress.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LBHostIpAddress.Location = new System.Drawing.Point(254, 229);
            this.LBHostIpAddress.Name = "LBHostIpAddress";
            this.LBHostIpAddress.Size = new System.Drawing.Size(57, 54);
            this.LBHostIpAddress.TabIndex = 14;
            this.LBHostIpAddress.Text = "适配器IP地址：";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(186, 289);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(57, 54);
            this.label16.TabIndex = 14;
            this.label16.Text = "图像宽高：";
            // 
            // LBCurrentIpAddress
            // 
            this.LBCurrentIpAddress.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LBCurrentIpAddress.Location = new System.Drawing.Point(254, 169);
            this.LBCurrentIpAddress.Name = "LBCurrentIpAddress";
            this.LBCurrentIpAddress.Size = new System.Drawing.Size(57, 54);
            this.LBCurrentIpAddress.TabIndex = 14;
            this.LBCurrentIpAddress.Text = "相机IP地址：";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(191, 229);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 54);
            this.label14.TabIndex = 14;
            this.label14.Text = "适配器IP地址：";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(191, 169);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 54);
            this.label12.TabIndex = 14;
            this.label12.Text = "相机IP地址：";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(191, 109);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 54);
            this.label10.TabIndex = 14;
            this.label10.Text = "固件：";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(191, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 54);
            this.label8.TabIndex = 14;
            this.label8.Text = "序列号：";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(191, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 54);
            this.label6.TabIndex = 14;
            this.label6.Text = "模型：";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 54);
            this.label2.TabIndex = 14;
            this.label2.Text = "曝光";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 54);
            this.label4.TabIndex = 13;
            this.label4.Text = "亮度";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(3, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 54);
            this.label3.TabIndex = 12;
            this.label3.Text = "对比度/增益";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(-4, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 54);
            this.label5.TabIndex = 19;
            this.label5.Text = "传输超时";
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label18.Location = new System.Drawing.Point(-1, 229);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 54);
            this.label18.TabIndex = 19;
            this.label18.Text = "包大小";
            // 
            // INDelayLevel
            // 
            this.INDelayLevel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.INDelayLevel.Location = new System.Drawing.Point(-4, 169);
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
            this.PNAttribute.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Panel panel2;
        private AntdUI.Tag TagCameraSetting;
        private Cognex.VisionPro.CogRecordDisplay cogRecordDisplay1;
        private AntdUI.Tag tag1;
        private AntdUI.Splitter splitter1;
        private AntdUI.Tag tag2;
        private AntdUI.Button BTAuto;
        private AntdUI.Button BTSemi;
        private AntdUI.Button BTLivePreview;
        private AntdUI.Button BTStopPreview;
        private AntdUI.Button BTInitializeCapture;
        private AntdUI.Button BTSingleShot;
        private AntdUI.Input IPExposureMS;
        private AntdUI.Label LBVideoFormat;
        private AntdUI.Label LBImageSource;
        private AntdUI.Label label2;
        private AntdUI.Label label4;
        private AntdUI.Label label3;
        private AntdUI.Label label18;
        private AntdUI.Label INDelayLevel;
        private AntdUI.Input IPDelayLevel;
        private AntdUI.Input IPLight;
        private AntdUI.Input IPContrast;
        private System.Windows.Forms.ComboBox CBBImageSource;
        private System.Windows.Forms.ComboBox CBBVideoFormat;
        private AntdUI.Select select3;
        private AntdUI.Label label1;
        private AntdUI.Label label5;
        private AntdUI.Input IPBagSize;
        private AntdUI.Input IPTimeOut;
        private AntdUI.Label LBModel;
        private AntdUI.Label label6;
        private AntdUI.Label label8;
        private AntdUI.Label LBSerialNumber;
        private AntdUI.Label label10;
        private AntdUI.Label LBMacAddress;
        private AntdUI.Label label12;
        private AntdUI.Label LBCurrentIpAddress;
        private AntdUI.Label LBHostIpAddress;
        private AntdUI.Label label14;
        private AntdUI.Label label16;
        private AntdUI.Label LBWidthWithHeight;
        private AntdUI.Label LBstatus;
        private AntdUI.In.Panel PNAttribute;
    }
}
