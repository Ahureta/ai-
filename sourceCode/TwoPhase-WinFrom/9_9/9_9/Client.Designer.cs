namespace _9_9
{
    partial class Client
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
            inputNumber1 = new AntdUI.InputNumber();
            sendDataBT = new AntdUI.Button();
            lostLinkBT = new AntdUI.Button();
            getLinkBT = new AntdUI.Button();
            input2 = new AntdUI.Input();
            panel1 = new AntdUI.Panel();
            label3 = new AntdUI.Label();
            label2 = new AntdUI.Label();
            label1 = new AntdUI.Label();
            label4 = new AntdUI.Label();
            input1 = new AntdUI.Input();
            SuspendLayout();
            // 
            // inputNumber1
            // 
            inputNumber1.Location = new Point(90, 67);
            inputNumber1.Name = "inputNumber1";
            inputNumber1.PlaceholderText = "请输入端口:";
            inputNumber1.Size = new Size(184, 40);
            inputNumber1.TabIndex = 13;
            inputNumber1.Text = "8848";
            inputNumber1.Value = new decimal(new int[] { 8848, 0, 0, 0 });
            // 
            // sendDataBT
            // 
            sendDataBT.Location = new Point(90, 354);
            sendDataBT.Name = "sendDataBT";
            sendDataBT.Size = new Size(108, 49);
            sendDataBT.TabIndex = 10;
            sendDataBT.Text = "发送";
            // 
            // lostLinkBT
            // 
            lostLinkBT.Location = new Point(204, 132);
            lostLinkBT.Name = "lostLinkBT";
            lostLinkBT.Size = new Size(108, 49);
            lostLinkBT.TabIndex = 11;
            lostLinkBT.Text = "断开";
            // 
            // getLinkBT
            // 
            getLinkBT.Location = new Point(90, 132);
            getLinkBT.Name = "getLinkBT";
            getLinkBT.Size = new Size(108, 49);
            getLinkBT.TabIndex = 12;
            getLinkBT.Text = "连接";
            // 
            // input2
            // 
            input2.Location = new Point(90, 205);
            input2.Multiline = true;
            input2.Name = "input2";
            input2.PlaceholderText = "请输入消息:";
            input2.Size = new Size(222, 132);
            input2.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.Location = new Point(440, 26);
            panel1.Name = "panel1";
            panel1.Size = new Size(331, 398);
            panel1.TabIndex = 8;
            panel1.Text = "panel1";
            // 
            // label3
            // 
            label3.Location = new Point(29, 214);
            label3.Name = "label3";
            label3.Size = new Size(68, 22);
            label3.TabIndex = 5;
            label3.Text = "消息";
            // 
            // label2
            // 
            label2.Location = new Point(351, 47);
            label2.Name = "label2";
            label2.Size = new Size(68, 22);
            label2.TabIndex = 6;
            label2.Text = "信息:";
            // 
            // label1
            // 
            label1.Location = new Point(29, 76);
            label1.Name = "label1";
            label1.Size = new Size(68, 22);
            label1.TabIndex = 7;
            label1.Text = "端口";
            // 
            // label4
            // 
            label4.Location = new Point(29, 30);
            label4.Name = "label4";
            label4.Size = new Size(68, 22);
            label4.TabIndex = 7;
            label4.Text = "IP:";
            // 
            // input1
            // 
            input1.Location = new Point(90, 21);
            input1.Name = "input1";
            input1.PlaceholderText = "请输入IP:";
            input1.Size = new Size(184, 40);
            input1.TabIndex = 9;
            input1.Text = "127.0.0.1";
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(inputNumber1);
            Controls.Add(sendDataBT);
            Controls.Add(lostLinkBT);
            Controls.Add(getLinkBT);
            Controls.Add(input1);
            Controls.Add(input2);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Client";
            Text = "Client";
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.InputNumber inputNumber1;
        private AntdUI.Button sendDataBT;
        private AntdUI.Button lostLinkBT;
        private AntdUI.Button getLinkBT;
        private AntdUI.Input input2;
        private AntdUI.Panel panel1;
        private AntdUI.Label label3;
        private AntdUI.Label label2;
        private AntdUI.Label label1;
        private AntdUI.Label label4;
        private AntdUI.Input input1;
    }
}