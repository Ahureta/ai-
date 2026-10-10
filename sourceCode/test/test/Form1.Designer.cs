namespace test
{
    partial class Form1
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

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.select1 = new AntdUI.Select();
            this.selectMultiple1 = new AntdUI.SelectMultiple();
            this.panel1 = new AntdUI.In.Panel();
            this.SuspendLayout();
            // 
            // select1
            // 
            this.select1.Location = new System.Drawing.Point(136, 86);
            this.select1.Name = "select1";
            this.select1.Size = new System.Drawing.Size(232, 78);
            this.select1.TabIndex = 0;
            this.select1.Text = "select1";
            // 
            // selectMultiple1
            // 
            this.selectMultiple1.Items.AddRange(new object[] {
            "12123",
            "12313sdg",
            "sd"});
            this.selectMultiple1.Location = new System.Drawing.Point(130, 254);
            this.selectMultiple1.Name = "selectMultiple1";
            this.selectMultiple1.Size = new System.Drawing.Size(282, 73);
            this.selectMultiple1.TabIndex = 1;
            this.selectMultiple1.Text = "selectMultiple1";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(468, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(369, 301);
            this.panel1.TabIndex = 2;
            this.panel1.Text = "panel1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 491);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.selectMultiple1);
            this.Controls.Add(this.select1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Select select1;
        private AntdUI.SelectMultiple selectMultiple1;
        private AntdUI.In.Panel panel1;
    }
}

