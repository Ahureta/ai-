using _8_29.Contorls;
using _8_29.Data.Repositories;
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
        private BindingList<BookInfo> listBook = new BindingList<BookInfo>{ };
        public BookManager()
        {
            InitializeComponent();
            init();
        }
        public void init()
        {
            //AntdUI.Button()类型
            //List<AntdUI.Button> btList = this.Controls.OfType<AntdUI.Button>().ToList();
            //btList.ForEach(item => item.Click += Item_Click);
            bookAddBT.Click += BookAddBT_Click;
            bookEditBT.Click += BookEditBT_Click;
            bookSearchBT.Click += BookSearchBT_Click;

            showBook();

            bookShowTBCellButtonClick();


        }
        private async void BookSearch() {
            IBookRepository book = new BookRepository();
            listBook = await book.GetAllAsync();
            bookShowTB.DataSource = listBook;
        }
        private async void BookSearchBT_Click(object? sender, EventArgs e)
        {
            BookSearch();
            showBook();
        }

        private async void BookAddBT_Click(object? sender, EventArgs e)
        {            
            using BookAddWF bookAddWF = new();            
           
            if (bookAddWF.ShowDialog() == DialogResult.OK)
            {
                BookSearch();
                BookInfo createdBook = bookAddWF.SavedBook;                
                
                if (createdBook != null)
                {
                    listBook.Add(createdBook);                    
                    AntdUI.Message.success(this, "新增成功", autoClose: 3);
                }
                else                                    
                    AntdUI.Message.error(this, "新增失败", autoClose: 3);
                
            }
            else
            {                
                AntdUI.Message.error(this, "新增失败", autoClose: 3);
            }            
        }

        private void BookEditBT_Click(object? sender, EventArgs e)
        {
            //BookEditWF bookEditF = new BookEditWF();
            //bookEditF.Show();            
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

        private void showBook()
        {            
            //bookShowTB.DataSource = listBook;

            bookShowTB.Columns.Clear();

            bookShowTB.Columns = new AntdUI.ColumnCollection {
                new AntdUI.Column("Id", "编号")
                {
                    Render = (object val,object cel,int index ) =>(index+1).ToString()
                },
                new AntdUI.Column("Name", "书名"),
                new AntdUI.Column("Author", "作者"),
                new AntdUI.Column("Price", "价格"),
                new AntdUI.Column("BookTag", "标签"),
                new AntdUI.Column("IsBorrow", "是否借阅"){
                    Render=(object val,object cel,int index )=> val.ToString()=="1"?"已借阅":"在书架"
                },

                // 操作列：在构造列时直接通过 Render 返回按钮数组
                new AntdUI.Column("OperateBtns", "操作")
                {
                    Align = AntdUI.ColumnAlign.Center,
                    Width = "200",
                    Render = (object val, object cel, int index) =>
                    {
                        var book = cel as BookInfo;
                        if (book == null) return null;

                        return new AntdUI.CellButton[]  
                        {
                            new AntdUI.CellButton($"edit_{book.Id}", "编辑", AntdUI.TTypeMini.Default),
                            new AntdUI.CellButton($"del_{book.Id}", "删除", AntdUI.TTypeMini.Default),
                            book.IsBorrow
                                ? new AntdUI.CellButton($"return_{book.Id}", "归还", AntdUI.TTypeMini.Default)
                                : new AntdUI.CellButton($"borrow_{book.Id}", "借阅", AntdUI.TTypeMini.Default),
                        };
                    }
                }
            };
        }

        private void bookShowTBCellButtonClick() {
            bookShowTB.CellButtonClick += async (s, e) =>
            {
                // e.Btn       —— 被点击的那个 CellButton（可以拿到 Text、ID）
                // e.record    —— 当前行的原始数据对象（就是你绑定的 BookInfo）
                // e.rowIndex  —— 行序号
                // e.columnIndex —— 列序号

                var btn = e.Btn;
                var book = e.Record as BookInfo;   // 直接拿到行数据
                if (book == null) return;

                // 方式1：通过按钮 ID 判断
                var btnId = btn.Id;  // 形如 "edit_3"、"borrow_5"
                var parts = btnId.Split('_');
                var action = parts[0];   // "edit" / "del" / "borrow" / "return"

                // 方式2：也可以直接通过 btn.Text 判断（中文文本）
                // switch (btn.Text) { case "编辑": ... }
                //var action = btn.Text;
                var bookId = int.Parse(parts[1]);

                switch (action)
                {
                    case "edit":
                        // 编辑逻辑，book 已经是当前行对象                        

                        //if (bookAddWF.ShowDialog() == DialogResult.OK)
                        //{
                        //    BookSearch();
                        //    BookInfo createdBook = bookAddWF.SavedBook;
                        //    listBook.Add(createdBook);
                        //    //bookShowTB.DataSource = listBook;   //局部更新刷新列表、显示提示等

                        //    MessageBox.Show($"新增成功，Id={createdBook.Id}");
                        //}
                        //showBook();

                        BookEditWF bookEditWF = new();
                        ((BookControl)(bookEditWF.Controls[0])).SetBookControl(book);
                        bookEditWF.Show();

                        if (bookEditWF.ShowDialog() == DialogResult.OK)
                        {
                            BookSearch();
                            BookInfo editedBook = bookEditWF.EditedBook;

                            var oldBook = listBook.FirstOrDefault(b => b.Id == editedBook.Id);

                            if (oldBook != null)
                            {
                                int index = listBook.IndexOf(oldBook);
                                listBook[index] = editedBook;
                                // 成功
                                AntdUI.Message.success(this, "编辑成功", autoClose: 3);
                            }
                            else                            
                                AntdUI.Message.error(this, "编辑失败", autoClose: 3);
                            
                        }
                        else
                        {                            
                            AntdUI.Message.error(this, "编辑失败", autoClose: 3);
                        }
                        break;
                    case "del":
                        // 删除逻辑
                        DialogResult res = AntdUI.Modal.open(new AntdUI.Modal.Config(this, "删除提示", "你确定要删除吗?", AntdUI.TType.Warn)
                        {
                            OkText = "删除"
                        });
                        if (res == DialogResult.No) return;
                        IBookRepository bookRepository = new BookRepository();
                        int rows = await bookRepository.DeleteAsync(book.Id);
                        if (rows > 0)                        
                            MessageBox.Show("删除成功!!");                                                    
                        else
                            MessageBox.Show("删除失败!!!");                        
                        break;
                    case "borrow":
                        // 借阅逻辑                        
                        IBookRepository bookRepository2 = new BookRepository();
                        int rows2 = await bookRepository2.BorrowAsync(book.Id);
                        if (rows2 > 0)
                            MessageBox.Show("借阅成功!!");
                        else
                            MessageBox.Show("借阅失败!!!");
                        break;
                    case "return":
                        // 归还逻辑
                        IBookRepository bookRepository3 = new BookRepository();
                        int rows3 = await bookRepository3.ReturnAsync(book.Id);
                        if (rows3 > 0)
                            MessageBox.Show("归还成功!!");
                        else
                            MessageBox.Show("归还失败!!!");                        
                        break;
                }
            };
        }
    }
}

