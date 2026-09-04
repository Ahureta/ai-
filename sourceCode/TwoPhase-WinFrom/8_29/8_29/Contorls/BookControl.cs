using _8_29.Info;
using AntdUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace _8_29.Contorls
{
    public partial class BookControl : UserControl
    {
        private string option { get; set; }
        private BookInfo bookInfo { get; set; } = new BookInfo{ };
        public BookControl()
        {
            InitializeComponent();
        }
        public BookControl(string Operation)
        {
            option = Operation;
            InitializeComponent();
            bookOperationLB.Text = option;
            bookOperationBT.Text = option;
        }
        public void SetBookControl(BookInfo bookInfo)
        {
            this.bookInfo = bookInfo;
            bookNameTB.Text = bookInfo.Name;
            bookAuthorTB.Text = bookInfo.Author;
            bookPriceTB.Value = (decimal)bookInfo.Price;
            bookLabelTB.Text = bookInfo.Label;
        }
        internal event Action<BookInfo> SendData;

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(bookNameTB.Text) || bookPriceTB.Value == 0)
            {
                nameTip.Visible = true;
                priceTip.Visible = true;
                return;
            }
            else {
                nameTip.Visible = false;
                priceTip.Visible = false;
            }

            bookInfo.Name = bookNameTB.Text;
            bookInfo.Author = bookAuthorTB.Text;
            bookInfo.Price = double.Parse(bookPriceTB.Text);
            bookInfo.Label = bookLabelTB.Text;
            bookInfo.IsBorrow = false;

            SendData.Invoke(bookInfo);
        }

        #region //关于book的检测
        private void bookNameTB_MouseLeave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(bookNameTB.Text)) nameTip.Visible = true;
            else nameTip.Visible = false;
        }

        private void bookPriceTB_MouseLeave(object sender, EventArgs e)
        {
            if (bookPriceTB.Value==0) priceTip.Visible = true;
            else priceTip.Visible = false;
        }
        #endregion
    }
}
