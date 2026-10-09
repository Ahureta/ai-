namespace IndustrialVisionSort.ui.Controls.UC.ControlConfig
{
    partial class UcImageSaveConfig
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
            this.panel5 = new AntdUI.Panel();
            this.TagImageSaveSetting = new AntdUI.Tag();
            this.checkbox2 = new AntdUI.Checkbox();
            this.checkbox1 = new AntdUI.Checkbox();
            this.label15 = new AntdUI.Label();
            this.input2 = new AntdUI.Input();
            this.button11 = new AntdUI.Button();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.panel5.BorderWidth = 1F;
            this.panel5.Controls.Add(this.TagImageSaveSetting);
            this.panel5.Controls.Add(this.checkbox2);
            this.panel5.Controls.Add(this.checkbox1);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Controls.Add(this.input2);
            this.panel5.Controls.Add(this.button11);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(487, 238);
            this.panel5.TabIndex = 1;
            this.panel5.Text = "panel2";
            // 
            // TagImageSaveSetting
            // 
            this.TagImageSaveSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.TagImageSaveSetting.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TagImageSaveSetting.Location = new System.Drawing.Point(2, 2);
            this.TagImageSaveSetting.Name = "TagImageSaveSetting";
            this.TagImageSaveSetting.Size = new System.Drawing.Size(483, 36);
            this.TagImageSaveSetting.TabIndex = 2;
            this.TagImageSaveSetting.Text = "图像保存配置";
            this.TagImageSaveSetting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkbox2
            // 
            this.checkbox2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkbox2.Location = new System.Drawing.Point(196, 58);
            this.checkbox2.Name = "checkbox2";
            this.checkbox2.Size = new System.Drawing.Size(148, 36);
            this.checkbox2.TabIndex = 2;
            this.checkbox2.Text = "自动保存NG图";
            // 
            // checkbox1
            // 
            this.checkbox1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkbox1.Location = new System.Drawing.Point(27, 58);
            this.checkbox1.Name = "checkbox1";
            this.checkbox1.Size = new System.Drawing.Size(148, 36);
            this.checkbox1.TabIndex = 2;
            this.checkbox1.Text = "自动保存OK图";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(27, 100);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 39);
            this.label15.TabIndex = 1;
            this.label15.Text = "保存路径";
            // 
            // input2
            // 
            this.input2.Location = new System.Drawing.Point(127, 100);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(328, 116);
            this.input2.TabIndex = 3;
            // 
            // button11
            // 
            this.button11.BorderWidth = 1F;
            this.button11.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button11.Location = new System.Drawing.Point(27, 160);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(84, 37);
            this.button11.TabIndex = 1;
            this.button11.Text = "选择路径";
            // 
            // ImageSaveConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel5);
            this.Name = "ImageSaveConfig";
            this.Size = new System.Drawing.Size(1147, 713);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Panel panel5;
        private AntdUI.Tag TagImageSaveSetting;
        private AntdUI.Checkbox checkbox2;
        private AntdUI.Checkbox checkbox1;
        private AntdUI.Label label15;
        private AntdUI.Input input2;
        private AntdUI.Button button11;
    }
}
