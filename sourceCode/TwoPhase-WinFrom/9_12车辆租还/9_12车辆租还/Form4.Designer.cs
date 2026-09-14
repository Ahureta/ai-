namespace _9_12车辆租还
{
    partial class Form4
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
            button1 = new AntdUI.Button();
            label2 = new AntdUI.Label();
            label4 = new AntdUI.Label();
            label3 = new AntdUI.Label();
            label1 = new AntdUI.Label();
            select1 = new AntdUI.Select();
            label5 = new AntdUI.Label();
            label6 = new AntdUI.Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(201, 313);
            button1.Name = "button1";
            button1.Size = new Size(173, 55);
            button1.TabIndex = 10;
            button1.Text = "租车";
            // 
            // label2
            // 
            label2.Location = new Point(303, 23);
            label2.Name = "label2";
            label2.Size = new Size(101, 44);
            label2.TabIndex = 6;
            label2.Text = "租车";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Location = new Point(140, 230);
            label4.Name = "label4";
            label4.Size = new Size(101, 44);
            label4.TabIndex = 7;
            label4.Text = "租车客户";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Location = new Point(140, 174);
            label3.Name = "label3";
            label3.Size = new Size(101, 44);
            label3.TabIndex = 8;
            label3.Text = "车牌类型";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Location = new Point(140, 118);
            label1.Name = "label1";
            label1.Size = new Size(101, 44);
            label1.TabIndex = 9;
            label1.Text = "车牌号";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // select1
            // 
            select1.Location = new Point(260, 230);
            select1.Name = "select1";
            select1.Size = new Size(264, 50);
            select1.TabIndex = 11;
            // 
            // label5
            // 
            label5.Location = new Point(260, 112);
            label5.Name = "label5";
            label5.Size = new Size(164, 50);
            label5.TabIndex = 6;
            label5.Text = "车牌号";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            label6.Location = new Point(260, 168);
            label6.Name = "label6";
            label6.Size = new Size(164, 50);
            label6.TabIndex = 6;
            label6.Text = "类型";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(select1);
            Controls.Add(button1);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Button button1;
        private AntdUI.Label label2;
        private AntdUI.Label label4;
        private AntdUI.Label label3;
        private AntdUI.Label label1;
        private AntdUI.Select select1;
        private AntdUI.Label label5;
        private AntdUI.Label label6;
    }
}