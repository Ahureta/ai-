namespace IndustrialVisionSort.ui.Controls.UC.ContolSetting
{
    partial class UcModbusConfig
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
            this.select2 = new AntdUI.Select();
            this.select1 = new AntdUI.Select();
            this.input1 = new AntdUI.Input();
            this.tag1 = new AntdUI.Tag();
            this.label4 = new AntdUI.Label();
            this.label3 = new AntdUI.Label();
            this.label2 = new AntdUI.Label();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.panel2.BorderWidth = 1F;
            this.panel2.Controls.Add(this.select2);
            this.panel2.Controls.Add(this.select1);
            this.panel2.Controls.Add(this.input1);
            this.panel2.Controls.Add(this.tag1);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(487, 253);
            this.panel2.TabIndex = 1;
            this.panel2.Text = "panel2";
            // 
            // select2
            // 
            this.select2.Location = new System.Drawing.Point(137, 152);
            this.select2.Name = "select2";
            this.select2.Size = new System.Drawing.Size(278, 39);
            this.select2.TabIndex = 3;
            // 
            // select1
            // 
            this.select1.Location = new System.Drawing.Point(137, 107);
            this.select1.Name = "select1";
            this.select1.Size = new System.Drawing.Size(278, 39);
            this.select1.TabIndex = 3;
            this.select1.Text = "端口";
            // 
            // input1
            // 
            this.input1.Location = new System.Drawing.Point(137, 62);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(278, 39);
            this.input1.TabIndex = 2;
            this.input1.Text = "端口";
            // 
            // tag1
            // 
            this.tag1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tag1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tag1.Location = new System.Drawing.Point(2, 2);
            this.tag1.Name = "tag1";
            this.tag1.Size = new System.Drawing.Size(483, 39);
            this.tag1.TabIndex = 1;
            this.tag1.Text = "Modbus传送带配置";
            this.tag1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(34, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 39);
            this.label4.TabIndex = 1;
            this.label4.Text = "速度寄存器";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(34, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 39);
            this.label3.TabIndex = 1;
            this.label3.Text = "启停寄存器";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(34, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP地址";
            // 
            // ModbusConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "ModbusConfig";
            this.Size = new System.Drawing.Size(1160, 718);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Panel panel2;
        private AntdUI.Select select2;
        private AntdUI.Select select1;
        private AntdUI.Input input1;
        private AntdUI.Tag tag1;
        private AntdUI.Label label4;
        private AntdUI.Label label3;
        private AntdUI.Label label2;
    }
}
