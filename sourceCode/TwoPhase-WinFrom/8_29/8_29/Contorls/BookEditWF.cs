using _8_29.Data.Repositories;
using _8_29.Info;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _8_29.Contorls
{
    public partial class BookEditWF : Form
    {
        public BookEditWF()
        {
            InitializeComponent();
            // 绑定接受数据方法
            bookControl1.SendData += EditBook;
        }
        
        private async void EditBook(BookInfo book)
        {
            try
            {                
                IBookRepository bookRepository = new BookRepository();
                await bookRepository.UpdateAsync(book);
                this.DialogResult = DialogResult.OK;                

                MessageBox.Show("图书修改成功!!");
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
