using _8_29.Data.Repositories;
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
        public BookInfo SavedBook { get; private set; }
        public BookAddWF()
        {
            InitializeComponent();
            // 绑定接受数据方法
            bookControl1.SendData += AddBook;
        }
        private async void AddBook(BookInfo book)
        {
            try
            {
                IBookRepository bookRepository = new BookRepository();
                this.SavedBook = await bookRepository.AddAsync(book);
                if (SavedBook == null) return;
                this.DialogResult = DialogResult.OK;
                this.Close();                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"保存失败：{ex.Message}");
                // 不设置 DialogResult.OK，子窗体保持打开，用户可修改后重试
            }
        }
    }
}
