namespace _9_12
{
    partial class Form
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
            panel1 = new AntdUI.Panel();
            comboBox1 = new ComboBox();
            inputNumber1 = new AntdUI.InputNumber();
            checkbox2 = new AntdUI.Checkbox();
            panel2 = new AntdUI.Panel();
            radio2 = new AntdUI.Radio();
            radio1 = new AntdUI.Radio();
            input1 = new AntdUI.Input();
            label2 = new AntdUI.Label();
            label4 = new AntdUI.Label();
            label3 = new AntdUI.Label();
            label1 = new AntdUI.Label();
            panel3 = new AntdUI.Panel();
            label10 = new AntdUI.Label();
            label7 = new AntdUI.Label();
            label9 = new AntdUI.Label();
            label6 = new AntdUI.Label();
            label8 = new AntdUI.Label();
            label5 = new AntdUI.Label();
            button1 = new AntdUI.Button();
            button2 = new AntdUI.Button();
            button3 = new AntdUI.Button();
            panel4 = new AntdUI.Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(inputNumber1);
            panel1.Controls.Add(checkbox2);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(input1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(22, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(416, 313);
            panel1.TabIndex = 0;
            panel1.Text = "panel1";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "A设备", "B设备", "C设备", "D设备" });
            comboBox1.Location = new Point(143, 91);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(204, 28);
            comboBox1.TabIndex = 1;
            // 
            // inputNumber1
            // 
            inputNumber1.Location = new Point(113, 253);
            inputNumber1.Name = "inputNumber1";
            inputNumber1.Size = new Size(102, 34);
            inputNumber1.TabIndex = 4;
            inputNumber1.Text = "0";
            // 
            // checkbox2
            // 
            checkbox2.Location = new Point(66, 210);
            checkbox2.Name = "checkbox2";
            checkbox2.Size = new Size(149, 27);
            checkbox2.TabIndex = 0;
            checkbox2.Text = "启用温度报警";
            // 
            // panel2
            // 
            panel2.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            panel2.BorderWidth = 1F;
            panel2.Controls.Add(radio2);
            panel2.Controls.Add(radio1);
            panel2.Location = new Point(32, 138);
            panel2.Name = "panel2";
            panel2.Size = new Size(348, 52);
            panel2.TabIndex = 3;
            panel2.Text = "运行模式";
            // 
            // radio2
            // 
            radio2.Location = new Point(179, 5);
            radio2.Name = "radio2";
            radio2.Size = new Size(100, 42);
            radio2.TabIndex = 1;
            radio2.Text = "手动模式";
            // 
            // radio1
            // 
            radio1.Location = new Point(43, 5);
            radio1.Name = "radio1";
            radio1.Size = new Size(100, 42);
            radio1.TabIndex = 1;
            radio1.Text = "自动模式";
            // 
            // input1
            // 
            input1.Location = new Point(143, 14);
            input1.Name = "input1";
            input1.PlaceholderText = "请输入设备名称";
            input1.Size = new Size(204, 56);
            input1.TabIndex = 1;
            // 
            // label2
            // 
            label2.Location = new Point(32, 84);
            label2.Name = "label2";
            label2.Size = new Size(105, 35);
            label2.TabIndex = 0;
            label2.Text = "设备类型:";
            // 
            // label4
            // 
            label4.Location = new Point(221, 252);
            label4.Name = "label4";
            label4.Size = new Size(75, 35);
            label4.TabIndex = 0;
            label4.Text = "°C";
            // 
            // label3
            // 
            label3.Location = new Point(32, 253);
            label3.Name = "label3";
            label3.Size = new Size(75, 35);
            label3.TabIndex = 0;
            label3.Text = "温度上限";
            // 
            // label1
            // 
            label1.Location = new Point(32, 24);
            label1.Name = "label1";
            label1.Size = new Size(105, 35);
            label1.TabIndex = 0;
            label1.Text = "设备名称:";
            // 
            // panel3
            // 
            panel3.Controls.Add(label10);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label5);
            panel3.Location = new Point(472, 22);
            panel3.Name = "panel3";
            panel3.Size = new Size(371, 313);
            panel3.TabIndex = 1;
            panel3.Text = "panel3";
            // 
            // label10
            // 
            label10.Location = new Point(153, 140);
            label10.Name = "label10";
            label10.Size = new Size(76, 35);
            label10.TabIndex = 0;
            label10.Text = "正常";
            // 
            // label7
            // 
            label7.Location = new Point(48, 140);
            label7.Name = "label7";
            label7.Size = new Size(76, 35);
            label7.TabIndex = 0;
            label7.Text = "报警状态:";
            // 
            // label9
            // 
            label9.Location = new Point(153, 81);
            label9.Name = "label9";
            label9.Size = new Size(76, 35);
            label9.TabIndex = 0;
            label9.Text = "未连接";
            // 
            // label6
            // 
            label6.Location = new Point(48, 81);
            label6.Name = "label6";
            label6.Size = new Size(76, 35);
            label6.TabIndex = 0;
            label6.Text = "连接状态:";
            // 
            // label8
            // 
            label8.Location = new Point(153, 32);
            label8.Name = "label8";
            label8.Size = new Size(76, 35);
            label8.TabIndex = 0;
            label8.Text = "未运行";
            // 
            // label5
            // 
            label5.Location = new Point(48, 32);
            label5.Name = "label5";
            label5.Size = new Size(76, 35);
            label5.TabIndex = 0;
            label5.Text = "当前状态:";
            // 
            // button1
            // 
            button1.Location = new Point(181, 347);
            button1.Name = "button1";
            button1.Size = new Size(148, 52);
            button1.TabIndex = 2;
            button1.Text = "应用参数";
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(344, 347);
            button2.Name = "button2";
            button2.Size = new Size(148, 52);
            button2.TabIndex = 2;
            button2.Text = "启动设备";
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(520, 347);
            button3.Name = "button3";
            button3.Size = new Size(148, 52);
            button3.TabIndex = 2;
            button3.Text = "停止设备";
            button3.Click += button3_Click;
            // 
            // panel4
            // 
            panel4.AutoScroll = true;
            panel4.Location = new Point(22, 415);
            panel4.Name = "panel4";
            panel4.Size = new Size(827, 120);
            panel4.TabIndex = 3;
            panel4.Text = "panel4";
            // 
            // Form
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 559);
            Controls.Add(panel4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "Form";
            Text = "Form";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Panel panel1;
        private AntdUI.Input input1;
        private AntdUI.Label label2;
        private AntdUI.Label label1;
        private AntdUI.InputNumber inputNumber1;
        private AntdUI.Checkbox checkbox2;
        private AntdUI.Panel panel2;
        private AntdUI.Radio radio2;
        private AntdUI.Radio radio1;
        private AntdUI.Label label4;
        private AntdUI.Label label3;
        private AntdUI.Panel panel3;
        private AntdUI.Label label6;
        private AntdUI.Label label5;
        private AntdUI.Label label7;
        private AntdUI.Label label10;
        private AntdUI.Label label9;
        private AntdUI.Label label8;
        private AntdUI.Button button1;
        private AntdUI.Button button2;
        private AntdUI.Button button3;
        private AntdUI.Panel panel4;
        private ComboBox comboBox1;
    }
}
