namespace IndustrialVisionSort.UI.Forms
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Main = new AntdUI.In.Panel();
            this.PNTestingStatistics = new AntdUI.Panel();
            this.label5 = new AntdUI.Label();
            this.label4 = new AntdUI.Label();
            this.label7 = new AntdUI.Label();
            this.label6 = new AntdUI.Label();
            this.label3 = new AntdUI.Label();
            this.label2 = new AntdUI.Label();
            this.LBTestingStatistics = new AntdUI.Label();
            this.PNOperationControl = new AntdUI.Panel();
            this.select3 = new AntdUI.Select();
            this.select2 = new AntdUI.Select();
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
            this.LBOperationControl = new AntdUI.Label();
            this.PNStatusBar = new AntdUI.Panel();
            this.LBImagePreviewArea = new AntdUI.Label();
            this.PNImagePreviewArea = new AntdUI.Panel();
            this.LBImagePreviewAreaLB = new AntdUI.Label();
            this.IGImagePreviewArea = new AntdUI.Image3D();
            this.label8 = new AntdUI.Label();
            this.label9 = new AntdUI.Label();
            this.Main.SuspendLayout();
            this.PNTestingStatistics.SuspendLayout();
            this.PNOperationControl.SuspendLayout();
            this.PNStatusBar.SuspendLayout();
            this.PNImagePreviewArea.SuspendLayout();
            this.SuspendLayout();
            // 
            // Main
            // 
            this.Main.Controls.Add(this.PNTestingStatistics);
            this.Main.Controls.Add(this.PNOperationControl);
            this.Main.Controls.Add(this.PNStatusBar);
            this.Main.Controls.Add(this.PNImagePreviewArea);
            this.Main.Location = new System.Drawing.Point(0, 0);
            this.Main.Name = "Main";
            this.Main.Size = new System.Drawing.Size(1000, 500);
            this.Main.TabIndex = 0;
            this.Main.Text = "panel1";
            // 
            // PNTestingStatistics
            // 
            this.PNTestingStatistics.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.PNTestingStatistics.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.PNTestingStatistics.BorderWidth = 1F;
            this.PNTestingStatistics.Controls.Add(this.label5);
            this.PNTestingStatistics.Controls.Add(this.label4);
            this.PNTestingStatistics.Controls.Add(this.label7);
            this.PNTestingStatistics.Controls.Add(this.label9);
            this.PNTestingStatistics.Controls.Add(this.label8);
            this.PNTestingStatistics.Controls.Add(this.label6);
            this.PNTestingStatistics.Controls.Add(this.label3);
            this.PNTestingStatistics.Controls.Add(this.label2);
            this.PNTestingStatistics.Controls.Add(this.LBTestingStatistics);
            this.PNTestingStatistics.Location = new System.Drawing.Point(611, 304);
            this.PNTestingStatistics.Name = "PNTestingStatistics";
            this.PNTestingStatistics.Size = new System.Drawing.Size(389, 192);
            this.PNTestingStatistics.TabIndex = 3;
            this.PNTestingStatistics.Text = "panel5";
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
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(33, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "总检测数量：";
            // 
            // LBTestingStatistics
            // 
            this.LBTestingStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBTestingStatistics.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LBTestingStatistics.Location = new System.Drawing.Point(2, 2);
            this.LBTestingStatistics.Name = "LBTestingStatistics";
            this.LBTestingStatistics.Size = new System.Drawing.Size(385, 35);
            this.LBTestingStatistics.TabIndex = 0;
            this.LBTestingStatistics.Text = "检测统计";
            // 
            // PNOperationControl
            // 
            this.PNOperationControl.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.PNOperationControl.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.PNOperationControl.BorderWidth = 1F;
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
            this.PNOperationControl.Controls.Add(this.LBOperationControl);
            this.PNOperationControl.Location = new System.Drawing.Point(611, 12);
            this.PNOperationControl.Name = "PNOperationControl";
            this.PNOperationControl.Size = new System.Drawing.Size(389, 270);
            this.PNOperationControl.TabIndex = 2;
            this.PNOperationControl.Text = "panel4";
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
            // LBOperationControl
            // 
            this.LBOperationControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBOperationControl.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LBOperationControl.Location = new System.Drawing.Point(2, 2);
            this.LBOperationControl.Name = "LBOperationControl";
            this.LBOperationControl.Size = new System.Drawing.Size(385, 32);
            this.LBOperationControl.TabIndex = 0;
            this.LBOperationControl.Text = "运行控制";
            // 
            // PNStatusBar
            // 
            this.PNStatusBar.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.PNStatusBar.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.PNStatusBar.BorderWidth = 1F;
            this.PNStatusBar.Controls.Add(this.LBImagePreviewArea);
            this.PNStatusBar.Location = new System.Drawing.Point(12, 428);
            this.PNStatusBar.Name = "PNStatusBar";
            this.PNStatusBar.Size = new System.Drawing.Size(578, 69);
            this.PNStatusBar.TabIndex = 1;
            this.PNStatusBar.Text = "PNStatusBar";
            // 
            // LBImagePreviewArea
            // 
            this.LBImagePreviewArea.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBImagePreviewArea.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LBImagePreviewArea.Location = new System.Drawing.Point(2, 2);
            this.LBImagePreviewArea.Name = "LBImagePreviewArea";
            this.LBImagePreviewArea.Size = new System.Drawing.Size(574, 50);
            this.LBImagePreviewArea.TabIndex = 0;
            this.LBImagePreviewArea.Text = "状态栏：";
            // 
            // PNImagePreviewArea
            // 
            this.PNImagePreviewArea.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.PNImagePreviewArea.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            this.PNImagePreviewArea.BorderWidth = 1F;
            this.PNImagePreviewArea.Controls.Add(this.LBImagePreviewAreaLB);
            this.PNImagePreviewArea.Controls.Add(this.IGImagePreviewArea);
            this.PNImagePreviewArea.Location = new System.Drawing.Point(12, 12);
            this.PNImagePreviewArea.Name = "PNImagePreviewArea";
            this.PNImagePreviewArea.Size = new System.Drawing.Size(579, 396);
            this.PNImagePreviewArea.TabIndex = 0;
            this.PNImagePreviewArea.Text = "PNImagePreviewArea";
            // 
            // LBImagePreviewAreaLB
            // 
            this.LBImagePreviewAreaLB.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBImagePreviewAreaLB.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LBImagePreviewAreaLB.Location = new System.Drawing.Point(2, 2);
            this.LBImagePreviewAreaLB.Name = "LBImagePreviewAreaLB";
            this.LBImagePreviewAreaLB.Size = new System.Drawing.Size(575, 45);
            this.LBImagePreviewAreaLB.TabIndex = 2;
            this.LBImagePreviewAreaLB.Text = "图像预览区";
            // 
            // IGImagePreviewArea
            // 
            this.IGImagePreviewArea.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.IGImagePreviewArea.Location = new System.Drawing.Point(2, 53);
            this.IGImagePreviewArea.Name = "IGImagePreviewArea";
            this.IGImagePreviewArea.Size = new System.Drawing.Size(575, 341);
            this.IGImagePreviewArea.TabIndex = 1;
            this.IGImagePreviewArea.Text = "image3D1";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(131, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "0";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(131, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 25);
            this.label9.TabIndex = 1;
            this.label9.Text = "0.00%";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 564);
            this.Controls.Add(this.Main);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.Main.ResumeLayout(false);
            this.PNTestingStatistics.ResumeLayout(false);
            this.PNOperationControl.ResumeLayout(false);
            this.PNStatusBar.ResumeLayout(false);
            this.PNImagePreviewArea.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.In.Panel Main;
        private AntdUI.Panel PNImagePreviewArea;
        private AntdUI.Panel PNStatusBar;
        private AntdUI.Panel PNTestingStatistics;
        private AntdUI.Panel PNOperationControl;
        private AntdUI.Label LBImagePreviewArea;
        private AntdUI.Label LBOperationControl;
        private AntdUI.Image3D IGImagePreviewArea;
        private AntdUI.Label LBImagePreviewAreaLB;
        private AntdUI.Label LBTestingStatistics;
        private AntdUI.Button button1;
        private AntdUI.Button button4;
        private AntdUI.Button button3;
        private AntdUI.Button button2;
        private AntdUI.Radio radio2;
        private AntdUI.Radio radio1;
        private AntdUI.Label label1;
        private AntdUI.Button button5;
        private AntdUI.Button button6;
        private AntdUI.Button button7;
        private AntdUI.Select select1;
        private AntdUI.Select select2;
        private AntdUI.Select select3;
        private AntdUI.Label label2;
        private AntdUI.Label label3;
        private AntdUI.Label label4;
        private AntdUI.Label label5;
        private AntdUI.Label label7;
        private AntdUI.Label label6;
        private AntdUI.Label label8;
        private AntdUI.Label label9;
    }
}