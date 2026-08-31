namespace _8_29.Contorls
{
    partial class BookAddWF
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
            bookControl1 = new BookControl("图书添加");
            SuspendLayout();
            // 
            // bookControl1
            // 
            bookControl1.Location = new Point(155, 12);
            bookControl1.Name = "bookControl1";
            bookControl1.Size = new Size(359, 485);
            bookControl1.TabIndex = 0;
            // 
            // BookAddWF
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(848, 616);
            Controls.Add(bookControl1);
            Name = "BookAddWF";
            Text = "BookAddWF";
            ResumeLayout(false);
        }

        #endregion

        private BookControl bookControl1;
    }
}