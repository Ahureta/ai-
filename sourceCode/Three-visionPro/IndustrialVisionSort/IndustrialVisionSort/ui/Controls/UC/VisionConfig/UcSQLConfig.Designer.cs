namespace IndustrialVisionSort.ui.Controls.UC.ContolSetting
{
    partial class UcSQLConfig
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
            this.tag4 = new AntdUI.Tag();
            this.select7 = new AntdUI.Select();
            this.select8 = new AntdUI.Select();
            this.input4 = new AntdUI.Input();
            this.label13 = new AntdUI.Label();
            this.label14 = new AntdUI.Label();
            this.label15 = new AntdUI.Label();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.panel5.BorderWidth = 1F;
            this.panel5.Controls.Add(this.tag4);
            this.panel5.Controls.Add(this.select7);
            this.panel5.Controls.Add(this.select8);
            this.panel5.Controls.Add(this.input4);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Controls.Add(this.label14);
            this.panel5.Controls.Add(this.label15);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(487, 238);
            this.panel5.TabIndex = 1;
            this.panel5.Text = "panel2";
            // 
            // tag4
            // 
            this.tag4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tag4.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tag4.Location = new System.Drawing.Point(2, 2);
            this.tag4.Name = "tag4";
            this.tag4.Size = new System.Drawing.Size(483, 44);
            this.tag4.TabIndex = 1;
            this.tag4.Text = "数据库配置";
            this.tag4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // select7
            // 
            this.select7.Location = new System.Drawing.Point(137, 152);
            this.select7.Name = "select7";
            this.select7.Size = new System.Drawing.Size(278, 39);
            this.select7.TabIndex = 3;
            // 
            // select8
            // 
            this.select8.Location = new System.Drawing.Point(137, 107);
            this.select8.Name = "select8";
            this.select8.Size = new System.Drawing.Size(278, 39);
            this.select8.TabIndex = 3;
            this.select8.Text = "端口";
            // 
            // input4
            // 
            this.input4.Location = new System.Drawing.Point(137, 62);
            this.input4.Name = "input4";
            this.input4.Size = new System.Drawing.Size(278, 39);
            this.input4.TabIndex = 2;
            this.input4.Text = "端口";
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(34, 152);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 39);
            this.label13.TabIndex = 1;
            this.label13.Text = "连接测试";
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(34, 107);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 39);
            this.label14.TabIndex = 1;
            this.label14.Text = "连接字符串";
            // 
            // label15
            // 
            this.label15.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.Location = new System.Drawing.Point(34, 62);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(88, 39);
            this.label15.TabIndex = 1;
            this.label15.Text = "数据库类型";
            // 
            // SQLCofig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel5);
            this.Name = "SQLCofig";
            this.Size = new System.Drawing.Size(1107, 715);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Panel panel5;
        private AntdUI.Tag tag4;
        private AntdUI.Select select7;
        private AntdUI.Select select8;
        private AntdUI.Input input4;
        private AntdUI.Label label13;
        private AntdUI.Label label14;
        private AntdUI.Label label15;
    }
}
