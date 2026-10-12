namespace IndustrialVisionSort.ui.Controls.UC.ContolSetting
{
    partial class UcVisionConfig
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
            this.panel4 = new AntdUI.Panel();
            this.select5 = new AntdUI.Select();
            this.tag3 = new AntdUI.Tag();
            this.select6 = new AntdUI.Select();
            this.input3 = new AntdUI.Input();
            this.label9 = new AntdUI.Label();
            this.label10 = new AntdUI.Label();
            this.label11 = new AntdUI.Label();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.panel4.BorderWidth = 1F;
            this.panel4.Controls.Add(this.select5);
            this.panel4.Controls.Add(this.tag3);
            this.panel4.Controls.Add(this.select6);
            this.panel4.Controls.Add(this.input3);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(487, 238);
            this.panel4.TabIndex = 1;
            this.panel4.Text = "panel2";
            // 
            // select5
            // 
            this.select5.Location = new System.Drawing.Point(137, 152);
            this.select5.Name = "select5";
            this.select5.Size = new System.Drawing.Size(278, 39);
            this.select5.TabIndex = 3;
            // 
            // tag3
            // 
            this.tag3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tag3.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tag3.Location = new System.Drawing.Point(2, 2);
            this.tag3.Name = "tag3";
            this.tag3.Size = new System.Drawing.Size(483, 44);
            this.tag3.TabIndex = 1;
            this.tag3.Text = "视觉参数配置";
            this.tag3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // select6
            // 
            this.select6.Location = new System.Drawing.Point(137, 107);
            this.select6.Name = "select6";
            this.select6.Size = new System.Drawing.Size(278, 39);
            this.select6.TabIndex = 3;
            this.select6.Text = "端口";
            // 
            // input3
            // 
            this.input3.Location = new System.Drawing.Point(137, 62);
            this.input3.Name = "input3";
            this.input3.Size = new System.Drawing.Size(278, 39);
            this.input3.TabIndex = 2;
            this.input3.Text = "端口";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(26, 152);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 39);
            this.label9.TabIndex = 1;
            this.label9.Text = "拍照等待时间";
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(26, 107);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 39);
            this.label10.TabIndex = 1;
            this.label10.Text = "光电触发后停";
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(26, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 39);
            this.label11.TabIndex = 1;
            this.label11.Text = "匹配分数阈值";
            // 
            // VisionConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel4);
            this.Name = "VisionConfig";
            this.Size = new System.Drawing.Size(1073, 707);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Panel panel4;
        private AntdUI.Select select5;
        private AntdUI.Tag tag3;
        private AntdUI.Select select6;
        private AntdUI.Input input3;
        private AntdUI.Label label9;
        private AntdUI.Label label10;
        private AntdUI.Label label11;
    }
}
