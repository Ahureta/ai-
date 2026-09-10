namespace _9_10
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
            getLinkBT = new AntdUI.Button();
            lostLinkBT = new AntdUI.Button();
            writeBT = new AntdUI.Button();
            readBT = new AntdUI.Button();
            panel1 = new AntdUI.Panel();
            writeTB = new AntdUI.InputNumber();
            writeRowIDTB = new AntdUI.InputNumber();
            readRowIDTB = new AntdUI.InputNumber();
            SuspendLayout();
            // 
            // getLinkBT
            // 
            getLinkBT.Location = new Point(42, 39);
            getLinkBT.Name = "getLinkBT";
            getLinkBT.Size = new Size(106, 47);
            getLinkBT.TabIndex = 1;
            getLinkBT.Text = "连接";
            // 
            // lostLinkBT
            // 
            lostLinkBT.Location = new Point(172, 39);
            lostLinkBT.Name = "lostLinkBT";
            lostLinkBT.Size = new Size(106, 47);
            lostLinkBT.TabIndex = 1;
            lostLinkBT.Text = "断开连接";
            // 
            // writeBT
            // 
            writeBT.Location = new Point(42, 127);
            writeBT.Name = "writeBT";
            writeBT.Size = new Size(106, 47);
            writeBT.TabIndex = 1;
            writeBT.Text = "写入内容";
            // 
            // readBT
            // 
            readBT.Location = new Point(42, 222);
            readBT.Name = "readBT";
            readBT.Size = new Size(106, 47);
            readBT.TabIndex = 1;
            readBT.Text = "读取内容";
            // 
            // panel1
            // 
            panel1.Location = new Point(316, 232);
            panel1.Name = "panel1";
            panel1.Size = new Size(359, 174);
            panel1.TabIndex = 2;
            panel1.Text = "panel1";
            // 
            // writeTB
            // 
            writeTB.Location = new Point(316, 129);
            writeTB.Name = "writeTB";
            writeTB.PlaceholderText = "请输入内容";
            writeTB.Size = new Size(154, 45);
            writeTB.TabIndex = 3;
            // 
            // writeRowIDTB
            // 
            writeRowIDTB.Location = new Point(172, 129);
            writeRowIDTB.Name = "writeRowIDTB";
            writeRowIDTB.PlaceholderText = "请输入行ID";
            writeRowIDTB.Size = new Size(106, 45);
            writeRowIDTB.TabIndex = 3;
            // 
            // readRowIDTB
            // 
            readRowIDTB.Location = new Point(172, 222);
            readRowIDTB.Name = "readRowIDTB";
            readRowIDTB.PlaceholderText = "请输入行ID";
            readRowIDTB.Size = new Size(106, 45);
            readRowIDTB.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(readRowIDTB);
            Controls.Add(writeRowIDTB);
            Controls.Add(writeTB);
            Controls.Add(panel1);
            Controls.Add(lostLinkBT);
            Controls.Add(readBT);
            Controls.Add(writeBT);
            Controls.Add(getLinkBT);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private AntdUI.Button getLinkBT;
        private AntdUI.Button lostLinkBT;
        private AntdUI.Button writeBT;
        private AntdUI.Button readBT;
        private AntdUI.Panel panel1;
        private AntdUI.InputNumber writeTB;
        private AntdUI.InputNumber writeRowIDTB;
        private AntdUI.InputNumber readRowIDTB;
    }
}
