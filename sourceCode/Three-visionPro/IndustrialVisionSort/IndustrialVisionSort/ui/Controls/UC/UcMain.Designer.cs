namespace IndustrialVisionSort.ui.Controls.UC
{
    partial class UcMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UcMain));
            this.cogRecordDisplay = new Cognex.VisionPro.CogRecordDisplay();
            this.TagImagePreviewAreaLB = new AntdUI.Tag();
            this.TagImagePreviewArea = new AntdUI.Tag();
            this.TagTestingStatistics = new AntdUI.Tag();
            this.select3 = new AntdUI.Select();
            this.select2 = new AntdUI.Select();
            this.PNOperationControl = new AntdUI.Panel();
            this.select1 = new AntdUI.Select();
            this.label1 = new AntdUI.Label();
            this.radio2 = new AntdUI.Radio();
            this.radio1 = new AntdUI.Radio();
            this.button4 = new AntdUI.Button();
            this.button3 = new AntdUI.Button();
            this.button7 = new AntdUI.Button();
            this.button6 = new AntdUI.Button();
            this.button5 = new AntdUI.Button();
            this.button2 = new AntdUI.Button();
            this.button1 = new AntdUI.Button();
            this.label2 = new AntdUI.Label();
            this.panel1 = new AntdUI.In.Panel();
            this.PNTestingStatistics = new AntdUI.Panel();
            this.TagOperationControl = new AntdUI.Tag();
            this.label5 = new AntdUI.Label();
            this.label4 = new AntdUI.Label();
            this.label7 = new AntdUI.Label();
            this.label9 = new AntdUI.Label();
            this.label8 = new AntdUI.Label();
            this.label6 = new AntdUI.Label();
            this.label3 = new AntdUI.Label();
            this.splitter1 = new AntdUI.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay)).BeginInit();
            this.PNOperationControl.SuspendLayout();
            this.PNTestingStatistics.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitter1)).BeginInit();
            this.splitter1.Panel1.SuspendLayout();
            this.splitter1.Panel2.SuspendLayout();
            this.splitter1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cogRecordDisplay
            // 
            this.cogRecordDisplay.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplay.ColorMapLowerRoiLimit = 0D;
            this.cogRecordDisplay.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cogRecordDisplay.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplay.ColorMapUpperRoiLimit = 1D;
            this.cogRecordDisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cogRecordDisplay.DoubleTapZoomCycleLength = 2;
            this.cogRecordDisplay.DoubleTapZoomSensitivity = 2.5D;
            this.cogRecordDisplay.Location = new System.Drawing.Point(0, 0);
            this.cogRecordDisplay.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogRecordDisplay.MouseWheelSensitivity = 1D;
            this.cogRecordDisplay.Name = "cogRecordDisplay";
            this.cogRecordDisplay.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogRecordDisplay.OcxState")));
            this.cogRecordDisplay.Size = new System.Drawing.Size(728, 712);
            this.cogRecordDisplay.TabIndex = 3;
            // 
            // TagImagePreviewAreaLB
            // 
            this.TagImagePreviewAreaLB.Dock = System.Windows.Forms.DockStyle.Top;
            this.TagImagePreviewAreaLB.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TagImagePreviewAreaLB.Location = new System.Drawing.Point(0, 0);
            this.TagImagePreviewAreaLB.Name = "TagImagePreviewAreaLB";
            this.TagImagePreviewAreaLB.Size = new System.Drawing.Size(728, 45);
            this.TagImagePreviewAreaLB.TabIndex = 4;
            this.TagImagePreviewAreaLB.Text = "图像预览区";
            this.TagImagePreviewAreaLB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TagImagePreviewArea
            // 
            this.TagImagePreviewArea.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TagImagePreviewArea.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TagImagePreviewArea.Location = new System.Drawing.Point(0, 712);
            this.TagImagePreviewArea.Name = "TagImagePreviewArea";
            this.TagImagePreviewArea.Size = new System.Drawing.Size(728, 38);
            this.TagImagePreviewArea.TabIndex = 0;
            this.TagImagePreviewArea.Text = "状态栏";
            this.TagImagePreviewArea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TagTestingStatistics
            // 
            this.TagTestingStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.TagTestingStatistics.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TagTestingStatistics.Location = new System.Drawing.Point(2, 2);
            this.TagTestingStatistics.Name = "TagTestingStatistics";
            this.TagTestingStatistics.Size = new System.Drawing.Size(464, 45);
            this.TagTestingStatistics.TabIndex = 0;
            this.TagTestingStatistics.Text = "检测统计";
            this.TagTestingStatistics.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // select3
            // 
            this.select3.Location = new System.Drawing.Point(131, 105);
            this.select3.Name = "select3";
            this.select3.PlaceholderColorExtend = "";
            this.select3.PlaceholderText = "运行模式";
            this.select3.Size = new System.Drawing.Size(105, 33);
            this.select3.TabIndex = 4;
            // 
            // select2
            // 
            this.select2.Location = new System.Drawing.Point(267, 105);
            this.select2.Name = "select2";
            this.select2.PlaceholderColorExtend = "";
            this.select2.PlaceholderText = "运行模式";
            this.select2.Size = new System.Drawing.Size(105, 33);
            this.select2.TabIndex = 4;
            // 
            // PNOperationControl
            // 
            this.PNOperationControl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.PNOperationControl.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.PNOperationControl.BorderWidth = 1F;
            this.PNOperationControl.Controls.Add(this.TagTestingStatistics);
            this.PNOperationControl.Controls.Add(this.select3);
            this.PNOperationControl.Controls.Add(this.select2);
            this.PNOperationControl.Controls.Add(this.select1);
            this.PNOperationControl.Controls.Add(this.label1);
            this.PNOperationControl.Controls.Add(this.radio2);
            this.PNOperationControl.Controls.Add(this.radio1);
            this.PNOperationControl.Controls.Add(this.button4);
            this.PNOperationControl.Controls.Add(this.button3);
            this.PNOperationControl.Controls.Add(this.button7);
            this.PNOperationControl.Controls.Add(this.button6);
            this.PNOperationControl.Controls.Add(this.button5);
            this.PNOperationControl.Controls.Add(this.button2);
            this.PNOperationControl.Controls.Add(this.button1);
            this.PNOperationControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNOperationControl.Location = new System.Drawing.Point(0, 0);
            this.PNOperationControl.Name = "PNOperationControl";
            this.PNOperationControl.Size = new System.Drawing.Size(468, 506);
            this.PNOperationControl.TabIndex = 2;
            this.PNOperationControl.Text = "panel4";
            // 
            // select1
            // 
            this.select1.Location = new System.Drawing.Point(131, 203);
            this.select1.Name = "select1";
            this.select1.PlaceholderColorExtend = "";
            this.select1.PlaceholderText = "工件编号";
            this.select1.Size = new System.Drawing.Size(217, 33);
            this.select1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(47, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "检测NG";
            // 
            // radio2
            // 
            this.radio2.Location = new System.Drawing.Point(18, 144);
            this.radio2.Name = "radio2";
            this.radio2.Size = new System.Drawing.Size(107, 34);
            this.radio2.TabIndex = 2;
            this.radio2.Text = "光电触发";
            // 
            // radio1
            // 
            this.radio1.Location = new System.Drawing.Point(18, 104);
            this.radio1.Name = "radio1";
            this.radio1.Size = new System.Drawing.Size(107, 34);
            this.radio1.TabIndex = 2;
            this.radio1.Text = "系统就绪";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.button4.BorderWidth = 1F;
            this.button4.Location = new System.Drawing.Point(288, 53);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(84, 45);
            this.button4.TabIndex = 1;
            this.button4.Text = "连续运行";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.button3.BorderWidth = 1F;
            this.button3.Location = new System.Drawing.Point(198, 53);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 45);
            this.button3.TabIndex = 1;
            this.button3.Text = "单次运行";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.button7.BorderWidth = 1F;
            this.button7.Location = new System.Drawing.Point(288, 137);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(73, 41);
            this.button7.TabIndex = 1;
            this.button7.Text = "检测NG";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.button6.BorderWidth = 1F;
            this.button6.Location = new System.Drawing.Point(209, 137);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(73, 41);
            this.button6.TabIndex = 1;
            this.button6.Text = "检测OK";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.button5.BorderWidth = 1F;
            this.button5.Location = new System.Drawing.Point(131, 137);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(78, 41);
            this.button5.TabIndex = 1;
            this.button5.Text = "拍照中";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.button2.BorderWidth = 1F;
            this.button2.Location = new System.Drawing.Point(108, 53);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "停止检测";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.button1.BorderWidth = 1F;
            this.button1.Location = new System.Drawing.Point(18, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "开始检测";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(33, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "总检测数量：";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 500);
            this.panel1.TabIndex = 1;
            this.panel1.Text = "panel1";
            // 
            // PNTestingStatistics
            // 
            this.PNTestingStatistics.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.PNTestingStatistics.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.PNTestingStatistics.BorderWidth = 1F;
            this.PNTestingStatistics.Controls.Add(this.TagOperationControl);
            this.PNTestingStatistics.Controls.Add(this.label5);
            this.PNTestingStatistics.Controls.Add(this.label4);
            this.PNTestingStatistics.Controls.Add(this.label7);
            this.PNTestingStatistics.Controls.Add(this.label9);
            this.PNTestingStatistics.Controls.Add(this.label8);
            this.PNTestingStatistics.Controls.Add(this.label6);
            this.PNTestingStatistics.Controls.Add(this.label3);
            this.PNTestingStatistics.Controls.Add(this.label2);
            this.PNTestingStatistics.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PNTestingStatistics.Location = new System.Drawing.Point(0, 506);
            this.PNTestingStatistics.Name = "PNTestingStatistics";
            this.PNTestingStatistics.Size = new System.Drawing.Size(468, 244);
            this.PNTestingStatistics.TabIndex = 3;
            this.PNTestingStatistics.Text = "panel5";
            // 
            // TagOperationControl
            // 
            this.TagOperationControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.TagOperationControl.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TagOperationControl.Location = new System.Drawing.Point(2, 2);
            this.TagOperationControl.Name = "TagOperationControl";
            this.TagOperationControl.Size = new System.Drawing.Size(464, 44);
            this.TagOperationControl.TabIndex = 0;
            this.TagOperationControl.Text = "状态栏";
            this.TagOperationControl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(47, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "合格率：";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(47, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "瑕疵数量：";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(131, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "0";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(131, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "0.00%";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(131, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "0";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(131, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "0";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(47, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "合格数量：";
            // 
            // splitter1
            // 
            this.splitter1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            // 
            // splitter1.Panel1
            // 
            this.splitter1.Panel1.Controls.Add(this.PNOperationControl);
            this.splitter1.Panel1.Controls.Add(this.PNTestingStatistics);
            // 
            // splitter1.Panel2
            // 
            this.splitter1.Panel2.Controls.Add(this.TagImagePreviewAreaLB);
            this.splitter1.Panel2.Controls.Add(this.cogRecordDisplay);
            this.splitter1.Panel2.Controls.Add(this.TagImagePreviewArea);
            this.splitter1.Size = new System.Drawing.Size(1200, 750);
            this.splitter1.SplitterDistance = 468;
            this.splitter1.TabIndex = 2;
            // 
            // UcMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Name = "UcMain";
            this.Size = new System.Drawing.Size(1200, 750);
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay)).EndInit();
            this.PNOperationControl.ResumeLayout(false);
            this.PNTestingStatistics.ResumeLayout(false);
            this.splitter1.Panel1.ResumeLayout(false);
            this.splitter1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitter1)).EndInit();
            this.splitter1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Cognex.VisionPro.CogRecordDisplay cogRecordDisplay;
        private AntdUI.Tag TagImagePreviewAreaLB;
        private AntdUI.Tag TagImagePreviewArea;
        private AntdUI.Tag TagTestingStatistics;
        private AntdUI.Select select3;
        private AntdUI.Select select2;
        private AntdUI.Panel PNOperationControl;
        private AntdUI.Select select1;
        private AntdUI.Label label1;
        private AntdUI.Radio radio2;
        private AntdUI.Radio radio1;
        private AntdUI.Button button4;
        private AntdUI.Button button3;
        private AntdUI.Button button7;
        private AntdUI.Button button6;
        private AntdUI.Button button5;
        private AntdUI.Button button2;
        private AntdUI.Button button1;
        private AntdUI.Label label2;
        private AntdUI.In.Panel panel1;
        private AntdUI.Panel PNTestingStatistics;
        private AntdUI.Tag TagOperationControl;
        private AntdUI.Label label5;
        private AntdUI.Label label4;
        private AntdUI.Label label7;
        private AntdUI.Label label9;
        private AntdUI.Label label8;
        private AntdUI.Label label6;
        private AntdUI.Label label3;
        private AntdUI.Splitter splitter1;
    }
}
