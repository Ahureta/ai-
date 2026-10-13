namespace IndustrialVisionSort.ui.Controls.UC.ContolSetting
{
    partial class UcRobotDeviceDebug
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
            this.panel3 = new AntdUI.Panel();
            this.tag1 = new AntdUI.Tag();
            this.input7 = new AntdUI.Input();
            this.IPPort = new AntdUI.Input();
            this.IPIP = new AntdUI.Input();
            this.label5 = new AntdUI.Label();
            this.label6 = new AntdUI.Label();
            this.label7 = new AntdUI.Label();
            this.button4 = new AntdUI.Button();
            this.button3 = new AntdUI.Button();
            this.splitter1 = new AntdUI.Splitter();
            this.panel1 = new AntdUI.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tag2 = new AntdUI.Tag();
            this.BTSetPTPCmd = new AntdUI.Button();
            this.IPRGoal = new AntdUI.Input();
            this.IPZGoal = new AntdUI.Input();
            this.IPYGoal = new AntdUI.Input();
            this.IPXGoal = new AntdUI.Input();
            this.panel4 = new AntdUI.In.Panel();
            this.BTRRemove = new AntdUI.Button();
            this.BTRAdd = new AntdUI.Button();
            this.BTZRemove = new AntdUI.Button();
            this.BTZAdd = new AntdUI.Button();
            this.BTYRemove = new AntdUI.Button();
            this.BTYAdd = new AntdUI.Button();
            this.BTXRemove = new AntdUI.Button();
            this.BTXAdd = new AntdUI.Button();
            this.LBCurrentY = new AntdUI.Label();
            this.label11 = new AntdUI.Label();
            this.LBCurrentR = new AntdUI.Label();
            this.label14 = new AntdUI.Label();
            this.LBCurrentZ = new AntdUI.Label();
            this.label12 = new AntdUI.Label();
            this.LBCurrentX = new AntdUI.Label();
            this.label10 = new AntdUI.Label();
            this.label16 = new AntdUI.Label();
            this.label1 = new AntdUI.Label();
            this.label9 = new AntdUI.Label();
            this.LBStatus = new AntdUI.Label();
            this.LBConnectStatus = new AntdUI.Label();
            this.label2 = new AntdUI.Label();
            this.label3 = new AntdUI.Label();
            this.BTClearQueue = new AntdUI.Button();
            this.BTClearAllAlarmsState = new AntdUI.Button();
            this.BTSetHOMECmd = new AntdUI.Button();
            this.BTLostRobot = new AntdUI.Button();
            this.BTStopQueue = new AntdUI.Button();
            this.BTAddQueue = new AntdUI.Button();
            this.BTGetPose = new AntdUI.Button();
            this.BTStartQueue = new AntdUI.Button();
            this.BTSetEndEffectorSuctionCupOff = new AntdUI.Button();
            this.BTSetEndEffectorSuctionCupOn = new AntdUI.Button();
            this.BTConnectRobot = new AntdUI.Button();
            this.panel2 = new AntdUI.Panel();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitter1)).BeginInit();
            this.splitter1.Panel1.SuspendLayout();
            this.splitter1.Panel2.SuspendLayout();
            this.splitter1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.panel3.BorderWidth = 1F;
            this.panel3.Controls.Add(this.tag1);
            this.panel3.Controls.Add(this.input7);
            this.panel3.Controls.Add(this.IPPort);
            this.panel3.Controls.Add(this.IPIP);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(552, 750);
            this.panel3.TabIndex = 1;
            this.panel3.Text = "panel2";
            // 
            // tag1
            // 
            this.tag1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tag1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tag1.Location = new System.Drawing.Point(2, 2);
            this.tag1.Name = "tag1";
            this.tag1.Size = new System.Drawing.Size(548, 39);
            this.tag1.TabIndex = 1;
            this.tag1.Text = "机械臂配置";
            this.tag1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // input7
            // 
            this.input7.Location = new System.Drawing.Point(137, 152);
            this.input7.Name = "input7";
            this.input7.Size = new System.Drawing.Size(278, 39);
            this.input7.TabIndex = 2;
            this.input7.Text = "0";
            // 
            // IPPort
            // 
            this.IPPort.Location = new System.Drawing.Point(137, 107);
            this.IPPort.Name = "IPPort";
            this.IPPort.Size = new System.Drawing.Size(278, 39);
            this.IPPort.TabIndex = 2;
            this.IPPort.Text = "8989";
            // 
            // IPIP
            // 
            this.IPIP.Location = new System.Drawing.Point(137, 62);
            this.IPIP.Name = "IPIP";
            this.IPIP.Size = new System.Drawing.Size(278, 39);
            this.IPIP.TabIndex = 2;
            this.IPIP.Text = "127.0.0.1";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(34, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 39);
            this.label5.TabIndex = 1;
            this.label5.Text = "复位延迟";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(34, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 39);
            this.label6.TabIndex = 1;
            this.label6.Text = "端口";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(34, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 39);
            this.label7.TabIndex = 1;
            this.label7.Text = "机械臂IP";
            // 
            // button4
            // 
            this.button4.BorderWidth = 1F;
            this.button4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button4.Location = new System.Drawing.Point(240, 197);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 54);
            this.button4.TabIndex = 1;
            this.button4.Text = "取消";
            // 
            // button3
            // 
            this.button3.BorderWidth = 1F;
            this.button3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button3.Location = new System.Drawing.Point(110, 197);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 54);
            this.button3.TabIndex = 1;
            this.button3.Text = "确认";
            // 
            // splitter1
            // 
            this.splitter1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            // 
            // splitter1.Panel1
            // 
            this.splitter1.Panel1.Controls.Add(this.panel1);
            // 
            // splitter1.Panel2
            // 
            this.splitter1.Panel2.Controls.Add(this.panel3);
            this.splitter1.Size = new System.Drawing.Size(1200, 750);
            this.splitter1.SplitterDistance = 644;
            this.splitter1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.tag2);
            this.panel1.Controls.Add(this.BTSetPTPCmd);
            this.panel1.Controls.Add(this.IPRGoal);
            this.panel1.Controls.Add(this.IPZGoal);
            this.panel1.Controls.Add(this.IPYGoal);
            this.panel1.Controls.Add(this.IPXGoal);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.LBCurrentY);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.LBCurrentR);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.LBCurrentZ);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.LBCurrentX);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.LBStatus);
            this.panel1.Controls.Add(this.LBConnectStatus);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.BTClearQueue);
            this.panel1.Controls.Add(this.BTClearAllAlarmsState);
            this.panel1.Controls.Add(this.BTSetHOMECmd);
            this.panel1.Controls.Add(this.BTLostRobot);
            this.panel1.Controls.Add(this.BTStopQueue);
            this.panel1.Controls.Add(this.BTAddQueue);
            this.panel1.Controls.Add(this.BTGetPose);
            this.panel1.Controls.Add(this.BTStartQueue);
            this.panel1.Controls.Add(this.BTSetEndEffectorSuctionCupOff);
            this.panel1.Controls.Add(this.BTSetEndEffectorSuctionCupOn);
            this.panel1.Controls.Add(this.BTConnectRobot);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 750);
            this.panel1.TabIndex = 1;
            this.panel1.Text = "panel2";
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "吸盘"});
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(76, 253);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(91, 23);
            this.comboBox1.TabIndex = 6;
            // 
            // tag2
            // 
            this.tag2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tag2.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tag2.Location = new System.Drawing.Point(0, 0);
            this.tag2.Name = "tag2";
            this.tag2.Size = new System.Drawing.Size(644, 39);
            this.tag2.TabIndex = 5;
            this.tag2.Text = "机械臂控制";
            this.tag2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BTSetPTPCmd
            // 
            this.BTSetPTPCmd.BorderWidth = 1F;
            this.BTSetPTPCmd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTSetPTPCmd.Location = new System.Drawing.Point(510, 240);
            this.BTSetPTPCmd.Name = "BTSetPTPCmd";
            this.BTSetPTPCmd.Size = new System.Drawing.Size(119, 54);
            this.BTSetPTPCmd.TabIndex = 1;
            this.BTSetPTPCmd.Text = "定点运动";
            this.BTSetPTPCmd.Click += new System.EventHandler(this.BTPointMove_Click);
            // 
            // IPRGoal
            // 
            this.IPRGoal.Location = new System.Drawing.Point(544, 186);
            this.IPRGoal.Name = "IPRGoal";
            this.IPRGoal.Size = new System.Drawing.Size(91, 49);
            this.IPRGoal.TabIndex = 4;
            this.IPRGoal.Text = "0";
            // 
            // IPZGoal
            // 
            this.IPZGoal.Location = new System.Drawing.Point(387, 186);
            this.IPZGoal.Name = "IPZGoal";
            this.IPZGoal.Size = new System.Drawing.Size(91, 49);
            this.IPZGoal.TabIndex = 4;
            this.IPZGoal.Text = "0";
            // 
            // IPYGoal
            // 
            this.IPYGoal.Location = new System.Drawing.Point(233, 186);
            this.IPYGoal.Name = "IPYGoal";
            this.IPYGoal.Size = new System.Drawing.Size(91, 49);
            this.IPYGoal.TabIndex = 4;
            this.IPYGoal.Text = "0";
            // 
            // IPXGoal
            // 
            this.IPXGoal.Location = new System.Drawing.Point(76, 185);
            this.IPXGoal.Name = "IPXGoal";
            this.IPXGoal.Size = new System.Drawing.Size(91, 49);
            this.IPXGoal.TabIndex = 4;
            this.IPXGoal.Text = "0";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.BTRRemove);
            this.panel4.Controls.Add(this.BTRAdd);
            this.panel4.Controls.Add(this.BTZRemove);
            this.panel4.Controls.Add(this.BTZAdd);
            this.panel4.Controls.Add(this.BTYRemove);
            this.panel4.Controls.Add(this.BTYAdd);
            this.panel4.Controls.Add(this.BTXRemove);
            this.panel4.Controls.Add(this.BTXAdd);
            this.panel4.Location = new System.Drawing.Point(16, 114);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(613, 65);
            this.panel4.TabIndex = 3;
            this.panel4.Text = "panel4";
            // 
            // BTRRemove
            // 
            this.BTRRemove.BorderWidth = 1F;
            this.BTRRemove.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTRRemove.Location = new System.Drawing.Point(539, 5);
            this.BTRRemove.Name = "BTRRemove";
            this.BTRRemove.Size = new System.Drawing.Size(71, 57);
            this.BTRRemove.TabIndex = 1;
            this.BTRRemove.Text = "R-";
            // 
            // BTRAdd
            // 
            this.BTRAdd.BorderWidth = 1F;
            this.BTRAdd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTRAdd.Location = new System.Drawing.Point(462, 5);
            this.BTRAdd.Name = "BTRAdd";
            this.BTRAdd.Size = new System.Drawing.Size(71, 57);
            this.BTRAdd.TabIndex = 1;
            this.BTRAdd.Text = "R+";
            // 
            // BTZRemove
            // 
            this.BTZRemove.BorderWidth = 1F;
            this.BTZRemove.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTZRemove.Location = new System.Drawing.Point(388, 5);
            this.BTZRemove.Name = "BTZRemove";
            this.BTZRemove.Size = new System.Drawing.Size(71, 57);
            this.BTZRemove.TabIndex = 1;
            this.BTZRemove.Text = "Z-";
            // 
            // BTZAdd
            // 
            this.BTZAdd.BorderWidth = 1F;
            this.BTZAdd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTZAdd.Location = new System.Drawing.Point(311, 5);
            this.BTZAdd.Name = "BTZAdd";
            this.BTZAdd.Size = new System.Drawing.Size(71, 57);
            this.BTZAdd.TabIndex = 1;
            this.BTZAdd.Text = "Z+";
            // 
            // BTYRemove
            // 
            this.BTYRemove.BorderWidth = 1F;
            this.BTYRemove.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTYRemove.Location = new System.Drawing.Point(234, 5);
            this.BTYRemove.Name = "BTYRemove";
            this.BTYRemove.Size = new System.Drawing.Size(71, 57);
            this.BTYRemove.TabIndex = 1;
            this.BTYRemove.Text = "Y-";
            // 
            // BTYAdd
            // 
            this.BTYAdd.BorderWidth = 1F;
            this.BTYAdd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTYAdd.Location = new System.Drawing.Point(157, 5);
            this.BTYAdd.Name = "BTYAdd";
            this.BTYAdd.Size = new System.Drawing.Size(71, 57);
            this.BTYAdd.TabIndex = 1;
            this.BTYAdd.Text = "Y+";
            // 
            // BTXRemove
            // 
            this.BTXRemove.BorderWidth = 1F;
            this.BTXRemove.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTXRemove.Location = new System.Drawing.Point(80, 5);
            this.BTXRemove.Name = "BTXRemove";
            this.BTXRemove.Size = new System.Drawing.Size(71, 57);
            this.BTXRemove.TabIndex = 1;
            this.BTXRemove.Text = "X-";
            // 
            // BTXAdd
            // 
            this.BTXAdd.BorderWidth = 1F;
            this.BTXAdd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTXAdd.Location = new System.Drawing.Point(3, 5);
            this.BTXAdd.Name = "BTXAdd";
            this.BTXAdd.Size = new System.Drawing.Size(71, 57);
            this.BTXAdd.TabIndex = 1;
            this.BTXAdd.Text = "X+";
            // 
            // LBCurrentY
            // 
            this.LBCurrentY.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LBCurrentY.Location = new System.Drawing.Point(76, 350);
            this.LBCurrentY.Name = "LBCurrentY";
            this.LBCurrentY.Size = new System.Drawing.Size(54, 49);
            this.LBCurrentY.TabIndex = 2;
            this.LBCurrentY.Text = "当前Y";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(16, 350);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 49);
            this.label11.TabIndex = 2;
            this.label11.Text = "当前Y";
            // 
            // LBCurrentR
            // 
            this.LBCurrentR.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LBCurrentR.Location = new System.Drawing.Point(233, 350);
            this.LBCurrentR.Name = "LBCurrentR";
            this.LBCurrentR.Size = new System.Drawing.Size(54, 49);
            this.LBCurrentR.TabIndex = 2;
            this.LBCurrentR.Text = "当前R";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(173, 350);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 49);
            this.label14.TabIndex = 2;
            this.label14.Text = "当前R";
            // 
            // LBCurrentZ
            // 
            this.LBCurrentZ.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LBCurrentZ.Location = new System.Drawing.Point(233, 295);
            this.LBCurrentZ.Name = "LBCurrentZ";
            this.LBCurrentZ.Size = new System.Drawing.Size(54, 49);
            this.LBCurrentZ.TabIndex = 2;
            this.LBCurrentZ.Text = "当前Z";
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(173, 295);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(54, 49);
            this.label12.TabIndex = 2;
            this.label12.Text = "当前Z";
            // 
            // LBCurrentX
            // 
            this.LBCurrentX.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LBCurrentX.Location = new System.Drawing.Point(76, 295);
            this.LBCurrentX.Name = "LBCurrentX";
            this.LBCurrentX.Size = new System.Drawing.Size(54, 49);
            this.LBCurrentX.TabIndex = 2;
            this.LBCurrentX.Text = "当前X";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(16, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 49);
            this.label10.TabIndex = 2;
            this.label10.Text = "当前X";
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(484, 185);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 49);
            this.label16.TabIndex = 2;
            this.label16.Text = "目标R";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(16, 240);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 49);
            this.label1.TabIndex = 2;
            this.label1.Text = "执行器";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(327, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 49);
            this.label9.TabIndex = 2;
            this.label9.Text = "目标Z";
            // 
            // LBStatus
            // 
            this.LBStatus.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LBStatus.Location = new System.Drawing.Point(557, 54);
            this.LBStatus.Name = "LBStatus";
            this.LBStatus.Size = new System.Drawing.Size(66, 54);
            this.LBStatus.TabIndex = 2;
            this.LBStatus.Text = "状态";
            // 
            // LBConnectStatus
            // 
            this.LBConnectStatus.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LBConnectStatus.Location = new System.Drawing.Point(260, 54);
            this.LBConnectStatus.Name = "LBConnectStatus";
            this.LBConnectStatus.Size = new System.Drawing.Size(66, 54);
            this.LBConnectStatus.TabIndex = 2;
            this.LBConnectStatus.Text = "连接状态";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(173, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 49);
            this.label2.TabIndex = 2;
            this.label2.Text = "目标Y";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(16, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 49);
            this.label3.TabIndex = 2;
            this.label3.Text = "目标X";
            // 
            // BTClearQueue
            // 
            this.BTClearQueue.BorderWidth = 1F;
            this.BTClearQueue.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTClearQueue.Location = new System.Drawing.Point(16, 405);
            this.BTClearQueue.Name = "BTClearQueue";
            this.BTClearQueue.Size = new System.Drawing.Size(93, 54);
            this.BTClearQueue.TabIndex = 1;
            this.BTClearQueue.Text = "清空队列";
            // 
            // BTClearAllAlarmsState
            // 
            this.BTClearAllAlarmsState.BorderWidth = 1F;
            this.BTClearAllAlarmsState.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTClearAllAlarmsState.Location = new System.Drawing.Point(447, 54);
            this.BTClearAllAlarmsState.Name = "BTClearAllAlarmsState";
            this.BTClearAllAlarmsState.Size = new System.Drawing.Size(93, 54);
            this.BTClearAllAlarmsState.TabIndex = 1;
            this.BTClearAllAlarmsState.Text = "消除报警";
            this.BTClearAllAlarmsState.Click += new System.EventHandler(this.BTClearAllAlarmsState_Click);
            // 
            // BTSetHOMECmd
            // 
            this.BTSetHOMECmd.BorderWidth = 1F;
            this.BTSetHOMECmd.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTSetHOMECmd.Location = new System.Drawing.Point(351, 54);
            this.BTSetHOMECmd.Name = "BTSetHOMECmd";
            this.BTSetHOMECmd.Size = new System.Drawing.Size(68, 54);
            this.BTSetHOMECmd.TabIndex = 1;
            this.BTSetHOMECmd.Text = "回零";
            this.BTSetHOMECmd.Click += new System.EventHandler(this.BTSetHOMECmd_Click);
            // 
            // BTLostRobot
            // 
            this.BTLostRobot.BorderWidth = 1F;
            this.BTLostRobot.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTLostRobot.Location = new System.Drawing.Point(127, 54);
            this.BTLostRobot.Name = "BTLostRobot";
            this.BTLostRobot.Size = new System.Drawing.Size(110, 54);
            this.BTLostRobot.TabIndex = 1;
            this.BTLostRobot.Text = "断开机械臂";
            this.BTLostRobot.Click += new System.EventHandler(this.BTLostRobot_Click);
            // 
            // BTStopQueue
            // 
            this.BTStopQueue.BorderWidth = 1F;
            this.BTStopQueue.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTStopQueue.Location = new System.Drawing.Point(413, 405);
            this.BTStopQueue.Name = "BTStopQueue";
            this.BTStopQueue.Size = new System.Drawing.Size(136, 54);
            this.BTStopQueue.TabIndex = 1;
            this.BTStopQueue.Text = "停止队列运行";
            // 
            // BTAddQueue
            // 
            this.BTAddQueue.BorderWidth = 1F;
            this.BTAddQueue.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTAddQueue.Location = new System.Drawing.Point(115, 405);
            this.BTAddQueue.Name = "BTAddQueue";
            this.BTAddQueue.Size = new System.Drawing.Size(119, 54);
            this.BTAddQueue.TabIndex = 1;
            this.BTAddQueue.Text = "添加队列";
            // 
            // BTGetPose
            // 
            this.BTGetPose.BorderWidth = 1F;
            this.BTGetPose.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTGetPose.Location = new System.Drawing.Point(365, 240);
            this.BTGetPose.Name = "BTGetPose";
            this.BTGetPose.Size = new System.Drawing.Size(136, 54);
            this.BTGetPose.TabIndex = 1;
            this.BTGetPose.Text = "获取当前坐标";
            // 
            // BTStartQueue
            // 
            this.BTStartQueue.BorderWidth = 1F;
            this.BTStartQueue.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTStartQueue.Location = new System.Drawing.Point(250, 405);
            this.BTStartQueue.Name = "BTStartQueue";
            this.BTStartQueue.Size = new System.Drawing.Size(136, 54);
            this.BTStartQueue.TabIndex = 1;
            this.BTStartQueue.Text = "启动队列运行";
            // 
            // BTSetEndEffectorSuctionCupOff
            // 
            this.BTSetEndEffectorSuctionCupOff.BorderWidth = 1F;
            this.BTSetEndEffectorSuctionCupOff.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTSetEndEffectorSuctionCupOff.Location = new System.Drawing.Point(269, 241);
            this.BTSetEndEffectorSuctionCupOff.Name = "BTSetEndEffectorSuctionCupOff";
            this.BTSetEndEffectorSuctionCupOff.Size = new System.Drawing.Size(90, 49);
            this.BTSetEndEffectorSuctionCupOff.TabIndex = 1;
            this.BTSetEndEffectorSuctionCupOff.Text = "吸盘放";
            // 
            // BTSetEndEffectorSuctionCupOn
            // 
            this.BTSetEndEffectorSuctionCupOn.BorderWidth = 1F;
            this.BTSetEndEffectorSuctionCupOn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTSetEndEffectorSuctionCupOn.Location = new System.Drawing.Point(173, 241);
            this.BTSetEndEffectorSuctionCupOn.Name = "BTSetEndEffectorSuctionCupOn";
            this.BTSetEndEffectorSuctionCupOn.Size = new System.Drawing.Size(90, 49);
            this.BTSetEndEffectorSuctionCupOn.TabIndex = 1;
            this.BTSetEndEffectorSuctionCupOn.Text = "吸盘吸";
            // 
            // BTConnectRobot
            // 
            this.BTConnectRobot.BorderWidth = 1F;
            this.BTConnectRobot.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTConnectRobot.Location = new System.Drawing.Point(11, 54);
            this.BTConnectRobot.Name = "BTConnectRobot";
            this.BTConnectRobot.Size = new System.Drawing.Size(110, 54);
            this.BTConnectRobot.TabIndex = 1;
            this.BTConnectRobot.Text = "连接机械臂";
            this.BTConnectRobot.Click += new System.EventHandler(this.BTConnectRobot_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BorderWidth = 1F;
            this.panel2.Location = new System.Drawing.Point(16, 465);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(601, 214);
            this.panel2.TabIndex = 7;
            this.panel2.Text = "panel2";
            // 
            // UcRobotDeviceDebug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitter1);
            this.Name = "UcRobotDeviceDebug";
            this.Size = new System.Drawing.Size(1148, 703);
            this.panel3.ResumeLayout(false);
            this.splitter1.Panel1.ResumeLayout(false);
            this.splitter1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitter1)).EndInit();
            this.splitter1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Panel panel3;
        private AntdUI.Tag tag1;
        private AntdUI.Input IPIP;
        private AntdUI.Label label5;
        private AntdUI.Label label6;
        private AntdUI.Label label7;
        private AntdUI.Splitter splitter1;
        private AntdUI.Panel panel1;
        private AntdUI.Button BTSetPTPCmd;
        private AntdUI.Input IPZGoal;
        private AntdUI.Input IPYGoal;
        private AntdUI.Input IPXGoal;
        private AntdUI.In.Panel panel4;
        private AntdUI.Button BTZRemove;
        private AntdUI.Button BTZAdd;
        private AntdUI.Button BTYRemove;
        private AntdUI.Button BTYAdd;
        private AntdUI.Button BTXRemove;
        private AntdUI.Button BTXAdd;
        private AntdUI.Label label11;
        private AntdUI.Label label10;
        private AntdUI.Label label1;
        private AntdUI.Label label9;
        private AntdUI.Label label2;
        private AntdUI.Label label3;
        private AntdUI.Button BTClearQueue;
        private AntdUI.Button BTClearAllAlarmsState;
        private AntdUI.Button BTSetHOMECmd;
        private AntdUI.Button BTLostRobot;
        private AntdUI.Button BTAddQueue;
        private AntdUI.Button BTStartQueue;
        private AntdUI.Button BTSetEndEffectorSuctionCupOn;
        private AntdUI.Button BTConnectRobot;
        private AntdUI.Tag tag2;
        private AntdUI.Button BTRRemove;
        private AntdUI.Button BTRAdd;
        private AntdUI.Input input7;
        private AntdUI.Input IPPort;
        private AntdUI.Button button3;
        private AntdUI.Button button4;
        private System.Windows.Forms.ComboBox comboBox1;
        private AntdUI.Button BTSetEndEffectorSuctionCupOff;
        private AntdUI.Label LBCurrentX;
        private AntdUI.Label LBCurrentY;
        private AntdUI.Label LBCurrentR;
        private AntdUI.Label label14;
        private AntdUI.Label LBCurrentZ;
        private AntdUI.Label label12;
        private AntdUI.Button BTStopQueue;
        private AntdUI.Input IPRGoal;
        private AntdUI.Label label16;
        private AntdUI.Label LBConnectStatus;
        private AntdUI.Label LBStatus;
        private AntdUI.Button BTGetPose;
        private AntdUI.Panel panel2;
    }
}
