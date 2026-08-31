using _8_29.Info;
using AntdUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _8_29.Contorls
{
    public partial class BookControl : UserControl
    {
        public BookControl()
        {
            InitializeComponent();
        }
        public BookControl(string Operation)
        {
            InitializeComponent();
            bookOperationLB.Text = Operation;
            bookOperationBT.Text = Operation;
        }

        internal event Action<BookInfo> SendData;

        private void button1_Click(object sender, EventArgs e)
        {
            SendData.Invoke(new BookInfo()
            {
                Id = Guid.NewGuid().ToString(),
                BookName = bookNameTB.Text,
                BookAuthor = bookAuthorTB.Text,
                BookPrice = double.Parse(bookPriceTB.Text),
                BookTag = bookTagTB.Text,
                IsBorrow = false
            });
        }
    }
}
