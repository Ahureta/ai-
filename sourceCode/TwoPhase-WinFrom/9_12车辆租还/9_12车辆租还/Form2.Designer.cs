namespace _9_12车辆租还
{
    partial class Form2
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
            input1 = new AntdUI.Input();
            label1 = new AntdUI.Label();
            label2 = new AntdUI.Label();
            input2 = new AntdUI.Input();
            label3 = new AntdUI.Label();
            input3 = new AntdUI.Input();
            label4 = new AntdUI.Label();
            button1 = new AntdUI.Button();
            SuspendLayout();
            // 
            // input1
            // 
            input1.Location = new Point(242, 101);
            input1.Name = "input1";
            input1.Size = new Size(164, 50);
            input1.TabIndex = 0;
            // 
            // label1
            // 
            label1.Location = new Point(122, 107);
            label1.Name = "label1";
            label1.Size = new Size(101, 44);
            label1.TabIndex = 1;
            label1.Text = "车牌号";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Location = new Point(285, 12);
            label2.Name = "label2";
            label2.Size = new Size(101, 44);
            label2.TabIndex = 1;
            label2.Text = "车牌新增";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // input2
            // 
            input2.Location = new Point(242, 157);
            input2.Name = "input2";
            input2.Size = new Size(164, 50);
            input2.TabIndex = 0;
            // 
            // label3
            // 
            label3.Location = new Point(122, 163);
            label3.Name = "label3";
            label3.Size = new Size(101, 44);
            label3.TabIndex = 1;
            label3.Text = "车牌类型";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // input3
            // 
            input3.Location = new Point(242, 213);
            input3.Name = "input3";
            input3.Size = new Size(164, 50);
            input3.TabIndex = 0;
            // 
            // label4
            // 
            label4.Location = new Point(122, 219);
            label4.Name = "label4";
            label4.Size = new Size(101, 44);
            label4.TabIndex = 1;
            label4.Text = "车牌时费";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(183, 302);
            button1.Name = "button1";
            button1.Size = new Size(173, 55);
            button1.TabIndex = 2;
            button1.Text = "车牌新增";            
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(input3);
            Controls.Add(input2);
            Controls.Add(input1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Input input1;
        private AntdUI.Label label1;
        private AntdUI.Label label2;
        private AntdUI.Input input2;
        private AntdUI.Label label3;
        private AntdUI.Input input3;
        private AntdUI.Label label4;
        private AntdUI.Button button1;
    }
}