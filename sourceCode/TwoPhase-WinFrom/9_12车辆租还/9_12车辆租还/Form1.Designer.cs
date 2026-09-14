namespace _9_12车辆租还
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
            label1 = new AntdUI.Label();
            table1 = new AntdUI.Table();
            button1 = new AntdUI.Button();
            button2 = new AntdUI.Button();
            button3 = new AntdUI.Button();
            button4 = new AntdUI.Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Microsoft YaHei UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label1.Location = new Point(407, 23);
            label1.Name = "label1";
            label1.Size = new Size(188, 56);
            label1.TabIndex = 9;
            label1.Text = "车辆租还系统";
            // 
            // table1
            // 
            table1.BadgeBorderWidth = 1F;
            table1.Bordered = true;
            table1.BorderWidth = 2F;
            table1.Gap = 12;
            table1.Location = new Point(62, 219);
            table1.Name = "table1";
            table1.Size = new Size(934, 212);
            table1.TabIndex = 10;
            table1.Text = "table1";
            // 
            // button1
            // 
            button1.Location = new Point(87, 112);
            button1.Name = "button1";
            button1.Size = new Size(138, 49);
            button1.TabIndex = 11;
            button1.Text = "新增车辆";
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(247, 112);
            button2.Name = "button2";
            button2.Size = new Size(138, 49);
            button2.TabIndex = 11;
            button2.Text = "新增客户";
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(407, 112);
            button3.Name = "button3";
            button3.Size = new Size(138, 49);
            button3.TabIndex = 11;
            button3.Text = "查看客户列表";
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(563, 112);
            button4.Name = "button4";
            button4.Size = new Size(138, 49);
            button4.TabIndex = 11;
            button4.Text = "查看租车记录";
            button4.Click += button4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 465);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(table1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label label1;
        private AntdUI.Table table1;
        private AntdUI.Button button1;
        private AntdUI.Button button2;
        private AntdUI.Button button3;
        private AntdUI.Button button4;
    }
}
