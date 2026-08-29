using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _8_29
{
    public partial class BookManager : Form
    {
        public BookManager()
        {
            InitializeComponent();
            init();
        }
        public void init() {
            //AntdUI.Button()类型
            List<AntdUI.Button> btList = this.Controls.OfType<AntdUI.Button>().ToList();
            btList.ForEach(item => item.Click += Item_Click);
        }

        private void Item_Click(object? sender, EventArgs e)
        {
            //BookControl bc = new BookControl((sender as Button).Text);
            //bc.Show();
            if (sender is not AntdUI.Button btn) return;

            BookControl bc = new BookControl(btn.Text) { Dock = DockStyle.Fill };
            Form host = new Form
            {
                Text = btn.Text,
                Size = new Size(400, 300)
            };
            host.Controls.Add(bc);
            host.Show(this);
        }
        //public BookControl(string bookName,string author,double price,string tag)
        //{            
        //    InitializeComponent();
        //    BookNameTB.Text = bookName;
        //    BookAuthorTB.Text = author;
        //    BookPriceTB.Text = price.ToString();
        //    BookTagTB.Text = tag;
        //}
    }
}
