namespace FontGame
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(164, 14);
            panel1.Name = "panel1";
            panel1.Size = new Size(626, 420);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(16, 42);
            button1.Name = "button1";
            button1.Size = new Size(133, 55);
            button1.TabIndex = 1;
            button1.Text = "开始游戏";
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 119);
            label2.Name = "label2";
            label2.Size = new Size(18, 20);
            label2.TabIndex = 2;
            label2.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 119);
            label1.Name = "label1";
            label1.Size = new Size(43, 20);
            label1.TabIndex = 2;
            label1.Text = "得分:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button1;
        private Label label2;
        private Label label1;
    }
}
