namespace _8_29.Contorls
{
    partial class BookControl
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            bookOperationLB = new Label();
            bookPriceTB = new AntdUI.InputNumber();
            bookNameTB = new AntdUI.Input();
            bookNameLB = new Label();
            bookAuthorLB = new Label();
            bookAuthorTB = new AntdUI.Input();
            bookPriceLB = new Label();
            bookTagTB = new AntdUI.Input();
            bookTagLB = new Label();
            bookOperationBT = new AntdUI.Button();
            SuspendLayout();
            // 
            // bookOperationLB
            // 
            bookOperationLB.AutoSize = true;
            bookOperationLB.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 134);
            bookOperationLB.Location = new Point(151, 14);
            bookOperationLB.Name = "bookOperationLB";
            bookOperationLB.Size = new Size(129, 37);
            bookOperationLB.TabIndex = 0;
            bookOperationLB.Text = "图书操作";
            // 
            // bookPriceTB
            // 
            bookPriceTB.Location = new Point(108, 212);
            bookPriceTB.Name = "bookPriceTB";
            bookPriceTB.Size = new Size(225, 57);
            bookPriceTB.TabIndex = 1;
            bookPriceTB.Text = "0";
            // 
            // bookNameTB
            // 
            bookNameTB.Location = new Point(108, 90);
            bookNameTB.Name = "bookNameTB";
            bookNameTB.Size = new Size(225, 55);
            bookNameTB.TabIndex = 2;
            bookNameTB.Text = "请输入图书名称:";
            // 
            // bookNameLB
            // 
            bookNameLB.AutoSize = true;
            bookNameLB.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            bookNameLB.Location = new Point(10, 103);
            bookNameLB.Name = "bookNameLB";
            bookNameLB.Size = new Size(97, 27);
            bookNameLB.TabIndex = 0;
            bookNameLB.Text = "图书名称:";
            // 
            // bookAuthorLB
            // 
            bookAuthorLB.AutoSize = true;
            bookAuthorLB.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            bookAuthorLB.Location = new Point(10, 164);
            bookAuthorLB.Name = "bookAuthorLB";
            bookAuthorLB.Size = new Size(97, 27);
            bookAuthorLB.TabIndex = 0;
            bookAuthorLB.Text = "图书作者:";
            // 
            // bookAuthorTB
            // 
            bookAuthorTB.Location = new Point(108, 151);
            bookAuthorTB.Name = "bookAuthorTB";
            bookAuthorTB.Size = new Size(225, 55);
            bookAuthorTB.TabIndex = 2;
            bookAuthorTB.Text = "请输入作者:";
            // 
            // bookPriceLB
            // 
            bookPriceLB.AutoSize = true;
            bookPriceLB.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            bookPriceLB.Location = new Point(10, 226);
            bookPriceLB.Name = "bookPriceLB";
            bookPriceLB.Size = new Size(97, 27);
            bookPriceLB.TabIndex = 0;
            bookPriceLB.Text = "图书价格:";
            // 
            // bookTagTB
            // 
            bookTagTB.Location = new Point(108, 287);
            bookTagTB.Name = "bookTagTB";
            bookTagTB.Size = new Size(225, 108);
            bookTagTB.TabIndex = 2;
            bookTagTB.Text = "请输入标签:";
            // 
            // bookTagLB
            // 
            bookTagLB.AutoSize = true;
            bookTagLB.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            bookTagLB.Location = new Point(10, 287);
            bookTagLB.Name = "bookTagLB";
            bookTagLB.Size = new Size(92, 27);
            bookTagLB.TabIndex = 0;
            bookTagLB.Text = "图书标签";
            // 
            // bookOperationBT
            // 
            bookOperationBT.Location = new Point(108, 423);
            bookOperationBT.Name = "bookOperationBT";
            bookOperationBT.Size = new Size(172, 50);
            bookOperationBT.TabIndex = 3;
            bookOperationBT.Text = "图书操作按钮";
            // 
            // BookControl
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(bookOperationBT);
            Controls.Add(bookTagTB);
            Controls.Add(bookAuthorTB);
            Controls.Add(bookTagLB);
            Controls.Add(bookPriceLB);
            Controls.Add(bookNameTB);
            Controls.Add(bookAuthorLB);
            Controls.Add(bookPriceTB);
            Controls.Add(bookNameLB);
            Controls.Add(bookOperationLB);
            Name = "BookControl";
            Size = new Size(344, 477);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label bookOperationLB;
        private AntdUI.InputNumber bookPriceTB;
        private AntdUI.Input bookNameTB;
        private Label bookNameLB;
        private Label bookAuthorLB;
        private AntdUI.Input bookAuthorTB;
        private Label bookPriceLB;
        private AntdUI.Input bookTagTB;
        private Label bookTagLB;
        private AntdUI.Button bookOperationBT;
    }
}
