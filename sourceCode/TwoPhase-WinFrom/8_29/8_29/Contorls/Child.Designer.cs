namespace _8_29.Contorls
{
    partial class Child
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
            userNameLB = new Label();
            userNamePT = new Label();
            delete = new Button();
            userAgeLB = new Label();
            userAgePT = new Label();
            SuspendLayout();
            // 
            // userNameLB
            // 
            userNameLB.AutoSize = true;
            userNameLB.Location = new Point(22, 21);
            userNameLB.Name = "userNameLB";
            userNameLB.Size = new Size(58, 20);
            userNameLB.TabIndex = 0;
            userNameLB.Text = "用户名:";
            // 
            // userNamePT
            // 
            userNamePT.AutoSize = true;
            userNamePT.Location = new Point(144, 21);
            userNamePT.Name = "userNamePT";
            userNamePT.Size = new Size(83, 20);
            userNamePT.TabIndex = 0;
            userNamePT.Text = "userName";
            // 
            // delete
            // 
            delete.Location = new Point(264, 36);
            delete.Name = "delete";
            delete.Size = new Size(87, 41);
            delete.TabIndex = 1;
            delete.Text = "delete";
            delete.UseVisualStyleBackColor = true;
            // 
            // userAgeLB
            // 
            userAgeLB.AutoSize = true;
            userAgeLB.Location = new Point(22, 71);
            userAgeLB.Name = "userAgeLB";
            userAgeLB.Size = new Size(40, 20);
            userAgeLB.TabIndex = 0;
            userAgeLB.Text = "age:";
            // 
            // userAgePT
            // 
            userAgePT.AutoSize = true;
            userAgePT.Location = new Point(144, 71);
            userAgePT.Name = "userAgePT";
            userAgePT.Size = new Size(70, 20);
            userAgePT.TabIndex = 0;
            userAgePT.Text = "userAge";
            // 
            // Child
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(delete);
            Controls.Add(userAgePT);
            Controls.Add(userNamePT);
            Controls.Add(userAgeLB);
            Controls.Add(userNameLB);
            Name = "Child";
            Size = new Size(392, 115);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userNameLB;
        private Label userNamePT;
        private Button delete;
        private Label userAgeLB;
        private Label userAgePT;
    }
}
