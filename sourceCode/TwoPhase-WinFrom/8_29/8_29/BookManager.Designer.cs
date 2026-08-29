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
            BookManagerLB = new AntdUI.Label();
            table1 = new AntdUI.Table();
            BookAdd = new AntdUI.Button();
            BookEdit = new AntdUI.Button();
            BookSearch = new AntdUI.Button();
            BookRemove = new AntdUI.Button();
            exit = new AntdUI.Button();
            SuspendLayout();
            // 
            // BookManagerLB
            // 
            BookManagerLB.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 134);
            BookManagerLB.Location = new Point(294, 12);
            BookManagerLB.Name = "BookManagerLB";
            BookManagerLB.Size = new Size(155, 35);
            BookManagerLB.TabIndex = 0;
            BookManagerLB.Text = "图书管理系统";
            // 
            // table1
            // 
            table1.BorderWidth = 4F;
            table1.Gap = 12;
            table1.Location = new Point(44, 73);
            table1.Name = "table1";
            table1.Size = new Size(714, 212);
            table1.TabIndex = 1;
            table1.Text = "table1";
            // 
            // BookAdd
            // 
            BookAdd.Location = new Point(44, 330);
            BookAdd.Name = "BookAdd";
            BookAdd.Size = new Size(89, 35);
            BookAdd.TabIndex = 2;
            BookAdd.Text = "图书添加";
            // 
            // BookEdit
            // 
            BookEdit.Location = new Point(316, 330);
            BookEdit.Name = "BookEdit";
            BookEdit.Size = new Size(89, 35);
            BookEdit.TabIndex = 2;
            BookEdit.Text = "图书修改";
            // 
            // BookSearch
            // 
            BookSearch.Location = new Point(456, 330);
            BookSearch.Name = "BookSearch";
            BookSearch.Size = new Size(89, 35);
            BookSearch.TabIndex = 2;
            BookSearch.Text = "图书查找";
            // 
            // BookRemove
            // 
            BookRemove.Location = new Point(175, 330);
            BookRemove.Name = "BookRemove";
            BookRemove.Size = new Size(89, 35);
            BookRemove.TabIndex = 2;
            BookRemove.Text = "图书删除";
            // 
            // exit
            // 
            exit.Location = new Point(594, 330);
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
            Controls.Add(BookRemove);
            Controls.Add(exit);
            Controls.Add(BookSearch);
            Controls.Add(BookEdit);
            Controls.Add(BookAdd);
            Controls.Add(table1);
            Controls.Add(BookManagerLB);
            Name = "BookManager";
            Text = "BookManager";
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Label BookManagerLB;
        private AntdUI.Table table1;
        private AntdUI.Button BookAdd;
        private AntdUI.Button BookEdit;
        private AntdUI.Button BookSearch;
        private AntdUI.Button BookRemove;
        private AntdUI.Button exit;
    }
}