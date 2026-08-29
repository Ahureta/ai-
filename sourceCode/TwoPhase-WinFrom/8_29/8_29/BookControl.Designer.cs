namespace _8_29
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
            BookOperationLB = new Label();
            BookPriceTB = new AntdUI.InputNumber();
            BookNameTB = new AntdUI.Input();
            BookNameLB = new Label();
            BookAuthorLB = new Label();
            BookAuthorTB = new AntdUI.Input();
            BookPriceLB = new Label();
            BookTagTB = new AntdUI.Input();
            BookTagLB = new Label();
            BookOperationBT = new AntdUI.Button();
            SuspendLayout();
            // 
            // BookOperationLB
            // 
            BookOperationLB.AutoSize = true;
            BookOperationLB.Font = new Font("Microsoft YaHei UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 134);
            BookOperationLB.Location = new Point(248, 31);
            BookOperationLB.Name = "BookOperationLB";
            BookOperationLB.Size = new Size(129, 37);
            BookOperationLB.TabIndex = 0;
            BookOperationLB.Text = "图书操作";
            // 
            // BookPriceTB
            // 
            BookPriceTB.Location = new Point(205, 229);
            BookPriceTB.Name = "BookPriceTB";
            BookPriceTB.Size = new Size(225, 57);
            BookPriceTB.TabIndex = 1;
            BookPriceTB.Text = "请输入价格:";
            // 
            // BookNameTB
            // 
            BookNameTB.Location = new Point(205, 107);
            BookNameTB.Name = "BookNameTB";
            BookNameTB.Size = new Size(225, 55);
            BookNameTB.TabIndex = 2;
            BookNameTB.Text = "请输入图书名称:";
            // 
            // BookNameLB
            // 
            BookNameLB.AutoSize = true;
            BookNameLB.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            BookNameLB.Location = new Point(107, 120);
            BookNameLB.Name = "BookNameLB";
            BookNameLB.Size = new Size(97, 27);
            BookNameLB.TabIndex = 0;
            BookNameLB.Text = "图书名称:";
            // 
            // BookAuthorLB
            // 
            BookAuthorLB.AutoSize = true;
            BookAuthorLB.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            BookAuthorLB.Location = new Point(107, 181);
            BookAuthorLB.Name = "BookAuthorLB";
            BookAuthorLB.Size = new Size(97, 27);
            BookAuthorLB.TabIndex = 0;
            BookAuthorLB.Text = "图书作者:";
            // 
            // BookAuthorTB
            // 
            BookAuthorTB.Location = new Point(205, 168);
            BookAuthorTB.Name = "BookAuthorTB";
            BookAuthorTB.Size = new Size(225, 55);
            BookAuthorTB.TabIndex = 2;
            BookAuthorTB.Text = "请输入作者:";
            // 
            // BookPriceLB
            // 
            BookPriceLB.AutoSize = true;
            BookPriceLB.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            BookPriceLB.Location = new Point(107, 243);
            BookPriceLB.Name = "BookPriceLB";
            BookPriceLB.Size = new Size(97, 27);
            BookPriceLB.TabIndex = 0;
            BookPriceLB.Text = "图书价格:";
            // 
            // BookTagTB
            // 
            BookTagTB.Location = new Point(205, 304);
            BookTagTB.Name = "BookTagTB";
            BookTagTB.Size = new Size(225, 108);
            BookTagTB.TabIndex = 2;
            BookTagTB.Text = "请输入标签:";
            // 
            // BookTagLB
            // 
            BookTagLB.AutoSize = true;
            BookTagLB.Font = new Font("Microsoft YaHei UI Light", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            BookTagLB.Location = new Point(107, 304);
            BookTagLB.Name = "BookTagLB";
            BookTagLB.Size = new Size(92, 27);
            BookTagLB.TabIndex = 0;
            BookTagLB.Text = "图书标签";
            // 
            // BookOperationBT
            // 
            BookOperationBT.Location = new Point(205, 440);
            BookOperationBT.Name = "BookOperationBT";
            BookOperationBT.Size = new Size(172, 50);
            BookOperationBT.TabIndex = 3;
            BookOperationBT.Text = "图书操作按钮";
            // 
            // BookControl
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(BookOperationBT);
            Controls.Add(BookTagTB);
            Controls.Add(BookAuthorTB);
            Controls.Add(BookTagLB);
            Controls.Add(BookPriceLB);
            Controls.Add(BookNameTB);
            Controls.Add(BookAuthorLB);
            Controls.Add(BookPriceTB);
            Controls.Add(BookNameLB);
            Controls.Add(BookOperationLB);
            Name = "BookControl";
            Size = new Size(639, 532);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label BookOperationLB;
        private AntdUI.InputNumber BookPriceTB;
        private AntdUI.Input BookNameTB;
        private Label BookNameLB;
        private Label BookAuthorLB;
        private AntdUI.Input BookAuthorTB;
        private Label BookPriceLB;
        private AntdUI.Input BookTagTB;
        private Label BookTagLB;
        private AntdUI.Button BookOperationBT;
    }
}
