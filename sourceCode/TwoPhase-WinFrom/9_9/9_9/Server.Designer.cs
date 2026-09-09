namespace _9_9
{
    partial class Server
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
            panel1 = new AntdUI.Panel();
            label2 = new AntdUI.Label();
            label3 = new AntdUI.Label();
            input2 = new AntdUI.Input();
            getLinkBT = new AntdUI.Button();
            sendDataBT = new AntdUI.Button();
            lostLinkBT = new AntdUI.Button();
            inputNumber1 = new AntdUI.InputNumber();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(26, 49);
            label1.Name = "label1";
            label1.Size = new Size(68, 22);
            label1.TabIndex = 0;
            label1.Text = "端口";
            // 
            // panel1
            // 
            panel1.Location = new Point(437, 28);
            panel1.Name = "panel1";
            panel1.Size = new Size(331, 398);
            panel1.TabIndex = 1;
            panel1.Text = "panel1";
            // 
            // label2
            // 
            label2.Location = new Point(348, 49);
            label2.Name = "label2";
            label2.Size = new Size(68, 22);
            label2.TabIndex = 0;
            label2.Text = "信息:";
            // 
            // label3
            // 
            label3.Location = new Point(26, 187);
            label3.Name = "label3";
            label3.Size = new Size(68, 22);
            label3.TabIndex = 0;
            label3.Text = "消息";
            // 
            // input2
            // 
            input2.Location = new Point(87, 178);
            input2.Multiline = true;
            input2.Name = "input2";
            input2.PlaceholderText = "请输入消息:";
            input2.Size = new Size(222, 126);
            input2.TabIndex = 2;
            // 
            // getLinkBT
            // 
            getLinkBT.Location = new Point(87, 105);
            getLinkBT.Name = "getLinkBT";
            getLinkBT.Size = new Size(108, 49);
            getLinkBT.TabIndex = 3;
            getLinkBT.Text = "启动服务";
            // 
            // sendDataBT
            // 
            sendDataBT.Location = new Point(87, 323);
            sendDataBT.Name = "sendDataBT";
            sendDataBT.Size = new Size(108, 49);
            sendDataBT.TabIndex = 3;
            sendDataBT.Text = "发送";
            // 
            // lostLinkBT
            // 
            lostLinkBT.Location = new Point(201, 105);
            lostLinkBT.Name = "lostLinkBT";
            lostLinkBT.Size = new Size(108, 49);
            lostLinkBT.TabIndex = 3;
            lostLinkBT.Text = "断开";
            // 
            // inputNumber1
            // 
            inputNumber1.Location = new Point(87, 40);
            inputNumber1.Name = "inputNumber1";
            inputNumber1.PlaceholderText = "请输入端口:";
            inputNumber1.Size = new Size(184, 40);
            inputNumber1.TabIndex = 4;
            inputNumber1.Text = "8848";
            inputNumber1.Value = new decimal(new int[] { 8848, 0, 0, 0 });
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(inputNumber1);
            Controls.Add(sendDataBT);
            Controls.Add(lostLinkBT);
            Controls.Add(getLinkBT);
            Controls.Add(input2);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Server";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label label1;
        private AntdUI.Panel panel1;
        private AntdUI.Label label2;
        private AntdUI.Label label3;
        private AntdUI.Input input2;
        private AntdUI.Button getLinkBT;
        private AntdUI.Button sendDataBT;
        private AntdUI.Button lostLinkBT;
        private AntdUI.InputNumber inputNumber1;
    }
}
