namespace IndustrialVisionSort.ui.Controls.UC.ContolSetting
{
    partial class UcModbusDeviceDebug
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
            this.panel2 = new AntdUI.Panel();
            this.splitter1 = new AntdUI.Splitter();
            this.tag2 = new AntdUI.Tag();
            this.panel1 = new AntdUI.Panel();
            this.sliderSpeed = new AntdUI.Slider();
            this.label13 = new AntdUI.Label();
            this.LBMoveStatus = new AntdUI.Label();
            this.LBConnectStatus = new AntdUI.Label();
            this.label5 = new AntdUI.Label();
            this.LBCurrentSpeed = new AntdUI.Label();
            this.label6 = new AntdUI.Label();
            this.label7 = new AntdUI.Label();
            this.BTLostModbus = new AntdUI.Button();
            this.BTStart = new AntdUI.Button();
            this.BTStop = new AntdUI.Button();
            this.BTReverse = new AntdUI.Button();
            this.TBForwardRotation = new AntdUI.Button();
            this.BTConnectModbus = new AntdUI.Button();
            this.IPIP = new AntdUI.Input();
            this.tag1 = new AntdUI.Tag();
            this.BTCancel = new AntdUI.Button();
            this.label2 = new AntdUI.Label();
            this.BTConfirm = new AntdUI.Button();
            this.label3 = new AntdUI.Label();
            this.IPSpleed = new AntdUI.Input();
            this.label4 = new AntdUI.Label();
            this.IPForwardAndReverse = new AntdUI.Input();
            this.label1 = new AntdUI.Label();
            this.IPDeviceStatus = new AntdUI.Input();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitter1)).BeginInit();
            this.splitter1.Panel1.SuspendLayout();
            this.splitter1.Panel2.SuspendLayout();
            this.splitter1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.panel2.BorderWidth = 1F;
            this.panel2.Controls.Add(this.splitter1);
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
            this.splitter1.Location = new System.Drawing.Point(2, 2);
            this.splitter1.Name = "splitter1";
            // 
            // splitter1.Panel1
            // 
            this.splitter1.Panel1.Controls.Add(this.tag2);
            this.splitter1.Panel1.Controls.Add(this.panel1);
            // 
            // splitter1.Panel2
            // 
            this.splitter1.Panel2.Controls.Add(this.IPIP);
            this.splitter1.Panel2.Controls.Add(this.tag1);
            this.splitter1.Panel2.Controls.Add(this.BTCancel);
            this.splitter1.Panel2.Controls.Add(this.label2);
            this.splitter1.Panel2.Controls.Add(this.BTConfirm);
            this.splitter1.Panel2.Controls.Add(this.label3);
            this.splitter1.Panel2.Controls.Add(this.IPSpleed);
            this.splitter1.Panel2.Controls.Add(this.label4);
            this.splitter1.Panel2.Controls.Add(this.IPForwardAndReverse);
            this.splitter1.Panel2.Controls.Add(this.label1);
            this.splitter1.Panel2.Controls.Add(this.IPDeviceStatus);
            this.splitter1.Size = new System.Drawing.Size(1196, 746);
            this.splitter1.SplitterDistance = 566;
            this.splitter1.TabIndex = 4;
            // 
            // tag2
            // 
            this.tag2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tag2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tag2.Location = new System.Drawing.Point(0, 0);
            this.tag2.Name = "tag2";
            this.tag2.Size = new System.Drawing.Size(566, 39);
            this.tag2.TabIndex = 2;
            this.tag2.Text = "Modbus传送带控制";
            this.tag2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sliderSpeed);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.LBMoveStatus);
            this.panel1.Controls.Add(this.LBConnectStatus);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.LBCurrentSpeed);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.BTLostModbus);
            this.panel1.Controls.Add(this.BTStart);
            this.panel1.Controls.Add(this.BTStop);
            this.panel1.Controls.Add(this.BTReverse);
            this.panel1.Controls.Add(this.TBForwardRotation);
            this.panel1.Controls.Add(this.BTConnectModbus);
            this.panel1.Location = new System.Drawing.Point(3, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(560, 385);
            this.panel1.TabIndex = 1;
            // 
            // sliderSpeed
            // 
            this.sliderSpeed.Location = new System.Drawing.Point(83, 134);
            this.sliderSpeed.MaxValue = 2000;
            this.sliderSpeed.Name = "sliderSpeed";
            this.sliderSpeed.Size = new System.Drawing.Size(246, 49);
            this.sliderSpeed.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(83, 271);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 49);
            this.label13.TabIndex = 2;
            this.label13.Text = "通讯/运行状态";
            // 
            // LBMoveStatus
            // 
            this.LBMoveStatus.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LBMoveStatus.Location = new System.Drawing.Point(337, 68);
            this.LBMoveStatus.Name = "LBMoveStatus";
            this.LBMoveStatus.Size = new System.Drawing.Size(74, 49);
            this.LBMoveStatus.TabIndex = 2;
            this.LBMoveStatus.Text = "连接";
            // 
            // LBConnectStatus
            // 
            this.LBConnectStatus.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LBConnectStatus.Location = new System.Drawing.Point(337, 8);
            this.LBConnectStatus.Name = "LBConnectStatus";
            this.LBConnectStatus.Size = new System.Drawing.Size(74, 49);
            this.LBConnectStatus.TabIndex = 2;
            this.LBConnectStatus.Text = "连接";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(3, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 49);
            this.label5.TabIndex = 2;
            this.label5.Text = "通讯状态";
            // 
            // LBCurrentSpeed
            // 
            this.LBCurrentSpeed.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LBCurrentSpeed.Location = new System.Drawing.Point(83, 204);
            this.LBCurrentSpeed.Name = "LBCurrentSpeed";
            this.LBCurrentSpeed.Size = new System.Drawing.Size(74, 49);
            this.LBCurrentSpeed.TabIndex = 2;
            this.LBCurrentSpeed.Text = "当前速度";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(3, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 49);
            this.label6.TabIndex = 2;
            this.label6.Text = "当前速度";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(3, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 49);
            this.label7.TabIndex = 2;
            this.label7.Text = "速度调节";
            // 
            // BTLostModbus
            // 
            this.BTLostModbus.BorderWidth = 1F;
            this.BTLostModbus.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTLostModbus.Location = new System.Drawing.Point(164, 3);
            this.BTLostModbus.Name = "BTLostModbus";
            this.BTLostModbus.Size = new System.Drawing.Size(155, 54);
            this.BTLostModbus.TabIndex = 1;
            this.BTLostModbus.Text = "断开Modbus";
            this.BTLostModbus.Click += new System.EventHandler(this.BTLostModbus_Click);
            // 
            // BTStart
            // 
            this.BTStart.BorderWidth = 1F;
            this.BTStart.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTStart.Location = new System.Drawing.Point(164, 63);
            this.BTStart.Name = "BTStart";
            this.BTStart.Size = new System.Drawing.Size(75, 54);
            this.BTStart.TabIndex = 1;
            this.BTStart.Text = "启动";
            this.BTStart.Click += new System.EventHandler(this.BTStart_Click);
            // 
            // BTStop
            // 
            this.BTStop.BorderWidth = 1F;
            this.BTStop.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTStop.Location = new System.Drawing.Point(245, 63);
            this.BTStop.Name = "BTStop";
            this.BTStop.Size = new System.Drawing.Size(75, 54);
            this.BTStop.TabIndex = 1;
            this.BTStop.Text = "停止";
            this.BTStop.Click += new System.EventHandler(this.BTStop_Click);
            // 
            // BTReverse
            // 
            this.BTReverse.BorderWidth = 1F;
            this.BTReverse.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTReverse.Location = new System.Drawing.Point(83, 63);
            this.BTReverse.Name = "BTReverse";
            this.BTReverse.Size = new System.Drawing.Size(75, 54);
            this.BTReverse.TabIndex = 1;
            this.BTReverse.Text = "反转";
            this.BTReverse.Click += new System.EventHandler(this.BTReverse_Click);
            // 
            // TBForwardRotation
            // 
            this.TBForwardRotation.BorderWidth = 1F;
            this.TBForwardRotation.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TBForwardRotation.Location = new System.Drawing.Point(3, 63);
            this.TBForwardRotation.Name = "TBForwardRotation";
            this.TBForwardRotation.Size = new System.Drawing.Size(74, 54);
            this.TBForwardRotation.TabIndex = 1;
            this.TBForwardRotation.Text = "正转";
            this.TBForwardRotation.Click += new System.EventHandler(this.TBForwardRotation_Click);
            // 
            // BTConnectModbus
            // 
            this.BTConnectModbus.BorderWidth = 1F;
            this.BTConnectModbus.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTConnectModbus.Location = new System.Drawing.Point(3, 3);
            this.BTConnectModbus.Name = "BTConnectModbus";
            this.BTConnectModbus.Size = new System.Drawing.Size(155, 54);
            this.BTConnectModbus.TabIndex = 1;
            this.BTConnectModbus.Text = "连接Modbus";
            this.BTConnectModbus.Click += new System.EventHandler(this.BTConnectModbus_Click);
            // 
            // IPIP
            // 
            this.IPIP.Location = new System.Drawing.Point(121, 58);
            this.IPIP.Name = "IPIP";
            this.IPIP.PlaceholderText = "请输入IP";
            this.IPIP.Size = new System.Drawing.Size(278, 39);
            this.IPIP.TabIndex = 2;
            this.IPIP.Text = "2";
            // 
            // tag1
            // 
            this.tag1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tag1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tag1.Location = new System.Drawing.Point(0, 0);
            this.tag1.Name = "tag1";
            this.tag1.Size = new System.Drawing.Size(626, 39);
            this.tag1.TabIndex = 1;
            this.tag1.Text = "Modbus传送带参数配置";
            this.tag1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BTCancel
            // 
            this.BTCancel.BorderWidth = 1F;
            this.BTCancel.Location = new System.Drawing.Point(212, 238);
            this.BTCancel.Name = "BTCancel";
            this.BTCancel.Size = new System.Drawing.Size(109, 41);
            this.BTCancel.TabIndex = 3;
            this.BTCancel.Text = "取消";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(18, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP地址";
            // 
            // BTConfirm
            // 
            this.BTConfirm.BorderWidth = 1F;
            this.BTConfirm.Location = new System.Drawing.Point(87, 238);
            this.BTConfirm.Name = "BTConfirm";
            this.BTConfirm.Size = new System.Drawing.Size(109, 41);
            this.BTConfirm.TabIndex = 3;
            this.BTConfirm.Text = "确认";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(18, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 39);
            this.label3.TabIndex = 1;
            this.label3.Text = "启停寄存器";
            // 
            // IPSpleed
            // 
            this.IPSpleed.Location = new System.Drawing.Point(121, 193);
            this.IPSpleed.Name = "IPSpleed";
            this.IPSpleed.PlaceholderText = "请输入寄存器地址";
            this.IPSpleed.Size = new System.Drawing.Size(278, 39);
            this.IPSpleed.TabIndex = 2;
            this.IPSpleed.Text = "102";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(18, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 39);
            this.label4.TabIndex = 1;
            this.label4.Text = "正反转寄存器";
            // 
            // IPForwardAndReverse
            // 
            this.IPForwardAndReverse.Location = new System.Drawing.Point(121, 148);
            this.IPForwardAndReverse.Name = "IPForwardAndReverse";
            this.IPForwardAndReverse.PlaceholderText = "请输入寄存器地址";
            this.IPForwardAndReverse.Size = new System.Drawing.Size(278, 39);
            this.IPForwardAndReverse.TabIndex = 2;
            this.IPForwardAndReverse.Text = "101";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(18, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "速度寄存器";
            // 
            // IPDeviceStatus
            // 
            this.IPDeviceStatus.Location = new System.Drawing.Point(121, 103);
            this.IPDeviceStatus.Name = "IPDeviceStatus";
            this.IPDeviceStatus.PlaceholderText = "请输入寄存器地址";
            this.IPDeviceStatus.Size = new System.Drawing.Size(278, 39);
            this.IPDeviceStatus.TabIndex = 2;
            this.IPDeviceStatus.Text = "100";
            // 
            // UcModbusDeviceDebug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "UcModbusDeviceDebug";
            this.Size = new System.Drawing.Size(1160, 718);
            this.panel2.ResumeLayout(false);
            this.splitter1.Panel1.ResumeLayout(false);
            this.splitter1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitter1)).EndInit();
            this.splitter1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Panel panel2;
        private AntdUI.Input IPIP;
        private AntdUI.Tag tag1;
        private AntdUI.Label label4;
        private AntdUI.Label label3;
        private AntdUI.Label label2;
        private AntdUI.Label label1;
        private AntdUI.Input IPDeviceStatus;
        private AntdUI.Button BTConfirm;
        private AntdUI.Button BTCancel;
        private AntdUI.Input IPSpleed;
        private AntdUI.Input IPForwardAndReverse;
        private AntdUI.Splitter splitter1;
        private AntdUI.Panel panel1;
        private AntdUI.Slider sliderSpeed;
        private AntdUI.Label label13;
        private AntdUI.Label label5;
        private AntdUI.Label LBCurrentSpeed;
        private AntdUI.Label label6;
        private AntdUI.Label label7;
        private AntdUI.Button BTLostModbus;
        private AntdUI.Button BTStop;
        private AntdUI.Button BTReverse;
        private AntdUI.Button TBForwardRotation;
        private AntdUI.Button BTConnectModbus;
        private AntdUI.Tag tag2;
        private AntdUI.Label LBConnectStatus;
        private AntdUI.Label LBMoveStatus;
        private AntdUI.Button BTStart;
    }
}
