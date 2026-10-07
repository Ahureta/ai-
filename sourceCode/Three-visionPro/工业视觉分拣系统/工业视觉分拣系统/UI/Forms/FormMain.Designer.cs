namespace 工业视觉分拣系统.UI.Forms
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
            this.ControlMain = new AntdUI.In.Panel();
            this.panel1 = new AntdUI.In.Panel();
            this.panel2 = new AntdUI.In.Panel();
            this.ControlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // ControlMain
            // 
            this.ControlMain.Controls.Add(this.panel2);
            this.ControlMain.Controls.Add(this.panel1);
            this.ControlMain.Location = new System.Drawing.Point(0, 0);
            this.ControlMain.Name = "ControlMain";
            this.ControlMain.Size = new System.Drawing.Size(950, 500);
            this.ControlMain.TabIndex = 0;
            this.ControlMain.Text = "ControlMain";
            // 
            // panel1
            // 
            this.panel1.BadgeBorderWidth = 5F;
            this.panel1.BadgeMode = true;
            this.panel1.Location = new System.Drawing.Point(14, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(706, 418);
            this.panel1.TabIndex = 0;
            this.panel1.Text = "panel1";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(742, 19);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(207, 167);
            this.panel2.TabIndex = 1;
            this.panel2.Text = "panel2";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 564);
            this.Controls.Add(this.ControlMain);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.ControlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.In.Panel ControlMain;
        private AntdUI.In.Panel panel2;
        private AntdUI.In.Panel panel1;
    }
}