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
            bookManagerLB = new AntdUI.Label();
            bookSearchTB = new AntdUI.Table();
            bookAddBT = new AntdUI.Button();
            bookEditBT = new AntdUI.Button();
            bookSearchBT = new AntdUI.Button();
            bookRemoveBT = new AntdUI.Button();
            exit = new AntdUI.Button();
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
            // bookSearchTB
            // 
            bookSearchTB.BorderWidth = 4F;
            bookSearchTB.Gap = 12;
            bookSearchTB.Location = new Point(44, 73);
            bookSearchTB.Name = "bookSearchTB";
            bookSearchTB.Size = new Size(714, 212);
            bookSearchTB.TabIndex = 1;
            bookSearchTB.Text = "table1";
            // 
            // bookAddBT
            // 
            bookAddBT.Location = new Point(44, 368);
            bookAddBT.Name = "bookAddBT";
            bookAddBT.Size = new Size(89, 35);
            bookAddBT.TabIndex = 2;
            bookAddBT.Text = "图书添加";
            // 
            // bookEditBT
            // 
            bookEditBT.Location = new Point(316, 368);
            bookEditBT.Name = "bookEditBT";
            bookEditBT.Size = new Size(89, 35);
            bookEditBT.TabIndex = 2;
            bookEditBT.Text = "图书修改";
            // 
            // bookSearchBT
            // 
            bookSearchBT.Location = new Point(422, 327);
            bookSearchBT.Name = "bookSearchBT";
            bookSearchBT.Size = new Size(89, 35);
            bookSearchBT.TabIndex = 2;
            bookSearchBT.Text = "图书查找";
            // 
            // bookRemoveBT
            // 
            bookRemoveBT.Location = new Point(175, 368);
            bookRemoveBT.Name = "bookRemoveBT";
            bookRemoveBT.Size = new Size(89, 35);
            bookRemoveBT.TabIndex = 2;
            bookRemoveBT.Text = "图书删除";
            // 
            // exit
            // 
            exit.Location = new Point(520, 368);
            exit.Name = "exit";
            exit.Size = new Size(89, 35);
            exit.TabIndex = 2;
            exit.Text = "退出系统";
            // 
            // BookManager
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bookRemoveBT);
            Controls.Add(exit);
            Controls.Add(bookSearchBT);
            Controls.Add(bookEditBT);
            Controls.Add(bookAddBT);
            Controls.Add(bookSearchTB);
            Controls.Add(bookManagerLB);
            Name = "BookManager";
            Text = "BookManager";
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label bookManagerLB;
        private AntdUI.Table bookSearchTB;
        private AntdUI.Button bookAddBT;
        private AntdUI.Button bookEditBT;
        private AntdUI.Button bookSearchBT;
        private AntdUI.Button bookRemoveBT;
        private AntdUI.Button exit;
    }
}