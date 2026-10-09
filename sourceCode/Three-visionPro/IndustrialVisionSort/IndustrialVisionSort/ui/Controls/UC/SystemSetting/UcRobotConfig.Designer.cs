namespace IndustrialVisionSort.ui.Controls.UC.ContolSetting
{
    partial class UcRobotConfig
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
            this.select3 = new AntdUI.Select();
            this.select4 = new AntdUI.Select();
            this.tag1 = new AntdUI.Tag();
            this.input2 = new AntdUI.Input();
            this.label5 = new AntdUI.Label();
            this.label6 = new AntdUI.Label();
            this.label7 = new AntdUI.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.panel3.BorderWidth = 1F;
            this.panel3.Controls.Add(this.select3);
            this.panel3.Controls.Add(this.select4);
            this.panel3.Controls.Add(this.tag1);
            this.panel3.Controls.Add(this.input2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(487, 253);
            this.panel3.TabIndex = 1;
            this.panel3.Text = "panel2";
            // 
            // select3
            // 
            this.select3.Location = new System.Drawing.Point(137, 152);
            this.select3.Name = "select3";
            this.select3.Size = new System.Drawing.Size(278, 39);
            this.select3.TabIndex = 3;
            // 
            // select4
            // 
            this.select4.Location = new System.Drawing.Point(137, 107);
            this.select4.Name = "select4";
            this.select4.Size = new System.Drawing.Size(278, 39);
            this.select4.TabIndex = 3;
            this.select4.Text = "端口";
            // 
            // tag1
            // 
            this.tag1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tag1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tag1.Location = new System.Drawing.Point(2, 2);
            this.tag1.Name = "tag1";
            this.tag1.Size = new System.Drawing.Size(483, 39);
            this.tag1.TabIndex = 1;
            this.tag1.Text = "机械臂配置";
            this.tag1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(137, 62);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(278, 39);
            this.input2.TabIndex = 2;
            this.input2.Text = "端口";
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
            // RobotConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Name = "RobotConfig";
            this.Size = new System.Drawing.Size(1148, 703);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Panel panel3;
        private AntdUI.Select select3;
        private AntdUI.Select select4;
        private AntdUI.Tag tag1;
        private AntdUI.Input input2;
        private AntdUI.Label label5;
        private AntdUI.Label label6;
        private AntdUI.Label label7;
    }
}
