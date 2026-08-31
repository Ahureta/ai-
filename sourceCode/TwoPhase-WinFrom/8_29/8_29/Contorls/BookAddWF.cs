using _8_29.Info;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace _8_29.Contorls
{
    public partial class BookAddWF : Form
    {
        public BookAddWF()
        {
            InitializeComponent();
            // 绑定接受数据方法
            bookControl1.SendData += AddBook;
        }
        private void AddBook(BookInfo book)
        {
            //List<BookInfo> books = new List<BookInfo>();
            //string JsonStr = "";
            //if (File.Exists("./book.json"))
            //{
            //    JsonStr = File.ReadAllText("./book.json");
            //    books = JsonSerializer.Deserialize<List<BookInfo>>(JsonStr);
            //}
            //books.Add(book);

            //JsonStr = JsonSerializer.Serialize(books, new JsonSerializerOptions()
            //{
            //    WriteIndented = true,
            //    AllowTrailingCommas = true,
            //    Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            //});

            //File.WriteAllText("./book.json", JsonStr);

            MessageBox.Show("图书新增成功!!");
            this.Close();
        }
    }
}
