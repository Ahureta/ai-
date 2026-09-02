namespace _8_29
{
    partial class BookManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookManager));
            bookManagerLB = new AntdUI.Label();
            bookAddBT = new AntdUI.Button();
            bookEditBT = new AntdUI.Button();
            bookSearchBT = new AntdUI.Button();
            bookRemoveBT = new AntdUI.Button();
            exit = new AntdUI.Button();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            bookSearchIdTB = new TextBox();
            bookShowTB = new AntdUI.Table();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            SuspendLayout();
            // 
            // bookManagerLB
            // 
            bookManagerLB.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 134);
            bookManagerLB.Location = new Point(294, 12);
            bookManagerLB.Name = "bookManagerLB";
            bookManagerLB.Size = new Size(155, 35);
            bookManagerLB.TabIndex = 0;
            bookManagerLB.Text = "图书管理系统";
            // 
            // bookAddBT
            // 
            bookAddBT.Location = new Point(44, 383);
            bookAddBT.Name = "bookAddBT";
            bookAddBT.Size = new Size(89, 35);
            bookAddBT.TabIndex = 2;
            bookAddBT.Text = "图书添加";
            // 
            // bookEditBT
            // 
            bookEditBT.Location = new Point(303, 383);
            bookEditBT.Name = "bookEditBT";
            bookEditBT.Size = new Size(89, 35);
            bookEditBT.TabIndex = 2;
            bookEditBT.Text = "图书修改";
            // 
            // bookSearchBT
            // 
            bookSearchBT.Location = new Point(303, 327);
            bookSearchBT.Name = "bookSearchBT";
            bookSearchBT.Size = new Size(89, 35);
            bookSearchBT.TabIndex = 2;
            bookSearchBT.Text = "图书查找";
            // 
            // bookRemoveBT
            // 
            bookRemoveBT.Location = new Point(175, 383);
            bookRemoveBT.Name = "bookRemoveBT";
            bookRemoveBT.Size = new Size(89, 35);
            bookRemoveBT.TabIndex = 2;
            bookRemoveBT.Text = "图书删除";
            // 
            // exit
            // 
            exit.Location = new Point(447, 383);
            exit.Name = "exit";
            exit.Size = new Size(89, 35);
            exit.TabIndex = 2;
            exit.Text = "退出系统";
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(576, 327);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(312, 188);
            axWindowsMediaPlayer1.TabIndex = 4;
            // 
            // bookSearchIdTB
            // 
            bookSearchIdTB.Location = new Point(44, 327);
            bookSearchIdTB.Name = "bookSearchIdTB";
            bookSearchIdTB.Size = new Size(220, 27);
            bookSearchIdTB.TabIndex = 5;
            // 
            // bookShowTB
            // 
            bookShowTB.Gap = 12;
            bookShowTB.Location = new Point(44, 73);
            bookShowTB.Name = "bookShowTB";
            bookShowTB.Size = new Size(829, 239);
            bookShowTB.TabIndex = 6;
            bookShowTB.Text = "table1";
            // 
            // BookManager
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(925, 560);
            Controls.Add(bookShowTB);
            Controls.Add(bookSearchIdTB);
            Controls.Add(axWindowsMediaPlayer1);
            Controls.Add(bookRemoveBT);
            Controls.Add(exit);
            Controls.Add(bookSearchBT);
            Controls.Add(bookEditBT);
            Controls.Add(bookAddBT);
            Controls.Add(bookManagerLB);
            Name = "BookManager";
            Text = "BookManager";
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private AntdUI.Label bookManagerLB;
        private AntdUI.Button bookAddBT;
        private AntdUI.Button bookEditBT;
        private AntdUI.Button bookSearchBT;
        private AntdUI.Button bookRemoveBT;
        private AntdUI.Button exit;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private TextBox bookSearchIdTB;
        private AntdUI.Table bookShowTB;
    }
}