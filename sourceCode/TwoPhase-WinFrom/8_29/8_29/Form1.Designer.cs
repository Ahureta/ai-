namespace _8_29
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
            userNameLB = new Label();
            userNameTB = new TextBox();
            userAgeLB = new Label();
            userAgeTB = new TextBox();
            button1 = new Button();
            label3 = new Label();
            SuspendLayout();
            // 
            // userNameLB
            // 
            userNameLB.AutoSize = true;
            userNameLB.Location = new Point(52, 49);
            userNameLB.Name = "userNameLB";
            userNameLB.Size = new Size(58, 20);
            userNameLB.TabIndex = 0;
            userNameLB.Text = "用户名:";
            // 
            // userNameTB
            // 
            userNameTB.Location = new Point(133, 47);
            userNameTB.Name = "userNameTB";
            userNameTB.Size = new Size(201, 27);
            userNameTB.TabIndex = 1;
            // 
            // userAgeLB
            // 
            userAgeLB.AutoSize = true;
            userAgeLB.Location = new Point(52, 112);
            userAgeLB.Name = "userAgeLB";
            userAgeLB.Size = new Size(43, 20);
            userAgeLB.TabIndex = 0;
            userAgeLB.Text = "年龄:";
            // 
            // userAgeTB
            // 
            userAgeTB.Location = new Point(133, 110);
            userAgeTB.Name = "userAgeTB";
            userAgeTB.Size = new Size(201, 27);
            userAgeTB.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(133, 182);
            button1.Name = "button1";
            button1.Size = new Size(125, 53);
            button1.TabIndex = 2;
            button1.Text = "提交";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(52, 330);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 0;
            label3.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(userAgeTB);
            Controls.Add(userNameTB);
            Controls.Add(label3);
            Controls.Add(userAgeLB);
            Controls.Add(userNameLB);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userNameLB;
        private TextBox userNameTB;
        private Label userAgeLB;
        private TextBox userAgeTB;
        private Button button1;
        private Label label3;
    }
}
