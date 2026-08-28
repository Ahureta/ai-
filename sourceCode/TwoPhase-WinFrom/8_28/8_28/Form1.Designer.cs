namespace _8_28
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
            ProvinceCb = new ComboBox();
            CityCb = new ComboBox();
            checkBox1 = new CheckBox();
            panel1 = new Panel();
            checkBox6 = new CheckBox();
            checkBox5 = new CheckBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox7 = new CheckBox();
            AllCb = new CheckBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // ProvinceCb
            // 
            ProvinceCb.FormattingEnabled = true;
            ProvinceCb.Location = new Point(28, 45);
            ProvinceCb.Name = "ProvinceCb";
            ProvinceCb.Size = new Size(197, 28);
            ProvinceCb.TabIndex = 0;
            ProvinceCb.Text = "省份";
            // 
            // CityCb
            // 
            CityCb.FormattingEnabled = true;
            CityCb.Location = new Point(269, 45);
            CityCb.Name = "CityCb";
            CityCb.Size = new Size(221, 28);
            CityCb.TabIndex = 0;
            CityCb.Text = "城市";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(12, 14);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(61, 24);
            checkBox1.TabIndex = 1;
            checkBox1.Text = "香蕉";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBox7);
            panel1.Controls.Add(checkBox6);
            panel1.Controls.Add(checkBox5);
            panel1.Controls.Add(checkBox4);
            panel1.Controls.Add(checkBox3);
            panel1.Controls.Add(checkBox2);
            panel1.Controls.Add(checkBox1);
            panel1.Location = new Point(566, 129);
            panel1.Name = "panel1";
            panel1.Size = new Size(190, 237);
            panel1.TabIndex = 2;
            // 
            // checkBox6
            // 
            checkBox6.AutoSize = true;
            checkBox6.Location = new Point(12, 164);
            checkBox6.Name = "checkBox6";
            checkBox6.Size = new Size(61, 24);
            checkBox6.TabIndex = 1;
            checkBox6.Text = "芒果";
            checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            checkBox5.AutoSize = true;
            checkBox5.Location = new Point(12, 134);
            checkBox5.Name = "checkBox5";
            checkBox5.Size = new Size(61, 24);
            checkBox5.TabIndex = 1;
            checkBox5.Text = "橙子";
            checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(12, 104);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(61, 24);
            checkBox4.TabIndex = 1;
            checkBox4.Text = "葡萄";
            checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(12, 74);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(61, 24);
            checkBox3.TabIndex = 1;
            checkBox3.Text = "菠萝";
            checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(12, 44);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(61, 24);
            checkBox2.TabIndex = 1;
            checkBox2.Text = "苹果";
            checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            checkBox7.AutoSize = true;
            checkBox7.Location = new Point(12, 194);
            checkBox7.Name = "checkBox7";
            checkBox7.Size = new Size(61, 24);
            checkBox7.TabIndex = 1;
            checkBox7.Text = "西瓜";
            checkBox7.UseVisualStyleBackColor = true;
            // 
            // AllCb
            // 
            AllCb.AutoSize = true;
            AllCb.Location = new Point(566, 99);
            AllCb.Name = "AllCb";
            AllCb.Size = new Size(61, 24);
            AllCb.TabIndex = 1;
            AllCb.Text = "全选";
            AllCb.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AllCb);
            Controls.Add(panel1);
            Controls.Add(CityCb);
            Controls.Add(ProvinceCb);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ProvinceCb;
        private ComboBox CityCb;
        private CheckBox checkBox1;
        private Panel panel1;
        private CheckBox checkBox7;
        private CheckBox checkBox6;
        private CheckBox checkBox5;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox AllCb;
    }
}
