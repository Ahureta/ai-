using _8_29.Contorls;
using _8_29.Info;
using AntdUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json;
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
            //List<AntdUI.Button> btList = this.Controls.OfType<AntdUI.Button>().ToList();
            //btList.ForEach(item => item.Click += Item_Click);
            bookAddBT.Click += BookAddBT_Click;
            bookEditBT.Click += BookEditBT_Click;
            bookSearchBT.Click += BookSearchBT_Click;
            showBook();
        }

        private void BookSearchBT_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BookEditBT_Click(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void BookAddBT_Click(object? sender, EventArgs e)
        {
            new BookAddWF().Show();
        }

        //private void Item_Click(object? sender, EventArgs e)
        //{
        //    //BookControl bc = new BookControl((sender as Button).Text);
        //    //bc.Show();
        //    if (sender is not AntdUI.Button btn) return;

        //    BookControl bc = new BookControl(btn.Text) { Dock = DockStyle.Fill };
        //    Form host = new Form
        //    {
        //        Text = btn.Text,
        //        Size = new Size(400, 300)
        //    };
        //    host.Controls.Add(bc);
        //    host.Show(this);
        //}

        //public BookShow()
        //{
        //    InitializeComponent();
        //    showBook();
        //}

        private void showBook()
        {
            //string JsonStr = File.ReadAllText("./book.json");
            //List<BookInfo> books = JsonSerializer.Deserialize<List<BookInfo>>(JsonStr);
            List<BookInfo> books = new List<BookInfo>() { };
            bookSearchTB.DataSource = books;

            // 重置表头
            bookSearchTB.Columns.Clear();

            bookSearchTB.Columns = new AntdUI.ColumnCollection {
                        new AntdUI.Column("Id", "编号")
                        {
                            Render = (object val,object cel,int index ) =>index.ToString()

                        },
                        new AntdUI.Column("Name", "书名"),
                        new AntdUI.Column("Author", "作者"),
                        new AntdUI.Column("Price", "价格"),
                        new AntdUI.Column("BookLabel", "标签"),
                        new AntdUI.Column("IsBorrow", "是否借阅"),
                    };

            bookSearchTB.Columns.Add(new AntdUI.Column("Handler", "操作")
            {
                Render = (object val, object cel, int index) => "编辑"
            });

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

