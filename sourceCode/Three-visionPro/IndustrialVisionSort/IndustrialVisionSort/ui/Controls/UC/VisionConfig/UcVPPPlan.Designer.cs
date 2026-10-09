namespace IndustrialVisionSort.ui.Controls.UC.ControlConfig
{
    partial class UcVPPPlan
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
            this.LBCurrentVPPPath = new AntdUI.Label();
            this.tag1 = new AntdUI.Tag();
            this.label5 = new AntdUI.Label();
            this.BTSaveVPPPlan = new AntdUI.Button();
            this.BTLoadVPPPlan = new AntdUI.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            this.panel3.BorderWidth = 1F;
            this.panel3.Controls.Add(this.LBCurrentVPPPath);
            this.panel3.Controls.Add(this.tag1);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.BTSaveVPPPlan);
            this.panel3.Controls.Add(this.BTLoadVPPPlan);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1200, 750);
            this.panel3.TabIndex = 1;
            this.panel3.Text = "panel2";
            // 
            // LBCurrentVPPPath
            // 
            this.LBCurrentVPPPath.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LBCurrentVPPPath.Location = new System.Drawing.Point(127, 135);
            this.LBCurrentVPPPath.Name = "LBCurrentVPPPath";
            this.LBCurrentVPPPath.Size = new System.Drawing.Size(328, 44);
            this.LBCurrentVPPPath.TabIndex = 2;
            this.LBCurrentVPPPath.Text = "当前VPP路径";
            // 
            // tag1
            // 
            this.tag1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tag1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tag1.Location = new System.Drawing.Point(2, 2);
            this.tag1.Name = "tag1";
            this.tag1.Size = new System.Drawing.Size(1196, 36);
            this.tag1.TabIndex = 2;
            this.tag1.Text = "VPP方案";
            this.tag1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(27, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 44);
            this.label5.TabIndex = 2;
            this.label5.Text = "当前VPP路径";
            // 
            // BTSaveVPPPlan
            // 
            this.BTSaveVPPPlan.BorderWidth = 1F;
            this.BTSaveVPPPlan.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTSaveVPPPlan.Location = new System.Drawing.Point(215, 62);
            this.BTSaveVPPPlan.Name = "BTSaveVPPPlan";
            this.BTSaveVPPPlan.Size = new System.Drawing.Size(129, 52);
            this.BTSaveVPPPlan.TabIndex = 1;
            this.BTSaveVPPPlan.Text = "保存VPP方案";
            // 
            // BTLoadVPPPlan
            // 
            this.BTLoadVPPPlan.BorderWidth = 1F;
            this.BTLoadVPPPlan.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BTLoadVPPPlan.Location = new System.Drawing.Point(71, 62);
            this.BTLoadVPPPlan.Name = "BTLoadVPPPlan";
            this.BTLoadVPPPlan.Size = new System.Drawing.Size(129, 52);
            this.BTLoadVPPPlan.TabIndex = 1;
            this.BTLoadVPPPlan.Text = "加载VPP方案";
            // 
            // UcVPPPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel3);
            this.Name = "UcVPPPlan";
            this.Size = new System.Drawing.Size(1200, 750);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Panel panel3;
        private AntdUI.Label LBCurrentVPPPath;
        private AntdUI.Tag tag1;
        private AntdUI.Label label5;
        private AntdUI.Button BTSaveVPPPlan;
        private AntdUI.Button BTLoadVPPPlan;
    }
}
