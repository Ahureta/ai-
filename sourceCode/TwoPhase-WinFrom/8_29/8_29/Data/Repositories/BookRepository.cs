using _8_29.Info;
using MySqlConnector;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;

namespace _8_29.Data.Repositories
{
    internal class BookRepository : IBookRepository
    {
        private readonly MySqlExecutor _executor;

        public BookRepository()
        {
            _executor = new MySqlExecutor();
        }

        public BookRepository(MySqlDataSource dataSource)
        {
            _executor = new MySqlExecutor(dataSource);
        }

        public async Task<BookInfo> AddAsync(BookInfo bookInfo)
        {
            var sql = @"
                INSERT INTO Book (uid, name, author, price, label, is_borrow)
                VALUES (@uid, @name, @author, @price, @label, @is_borrow);
        
                SELECT * FROM book WHERE id=LAST_INSERT_ID();";

            await _executor.ConAndHandler(sql,
                async cmd =>
                {
                    cmd.Parameters.AddWithValue("@uid", bookInfo.Uid);
                    cmd.Parameters.AddWithValue("@name", bookInfo.Name);
                    cmd.Parameters.AddWithValue("@author", bookInfo.Author);
                    cmd.Parameters.AddWithValue("@price", bookInfo.Price);
                    cmd.Parameters.AddWithValue("@label", bookInfo.Label);
                    cmd.Parameters.AddWithValue("@is_borrow", bookInfo.IsBorrow);
                    using MySqlDataReader mySqlDataReader = await cmd.ExecuteReaderAsync();
                                        
                    if (!await mySqlDataReader.ReadAsync())
                    {
                        if (!await mySqlDataReader.NextResultAsync())
                            throw new Exception("更新后未返回数据");

                        if (!await mySqlDataReader.ReadAsync())
                            throw new Exception("更新后未返回数据");
                    }
                    //if (!await mySqlDataReader.ReadAsync()) throw new Exception("插入失败，未返回数据");
                    //await mySqlDataReader.ReadAsync();
                    bookInfo = new BookInfo(
                                    mySqlDataReader.GetInt32("id"),
                                    mySqlDataReader.GetString("uid")
                                )
                    {
                        Name = mySqlDataReader.GetString("name"),
                        Author = mySqlDataReader.GetString("author"),
                        Price = mySqlDataReader.GetDouble("price"),
                        Label = mySqlDataReader.GetString("label"),
                        IsBorrow = mySqlDataReader.GetBoolean("is_borrow")
                    };
                }
            );
            //MessageBox.Show(bookInfo.Name);
            return bookInfo;

            //接口的另实现
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
            //return book;
        }

        public async Task<int> DeleteAsync(int id)
        {
            int rows = 0;

            await _executor.ConAndHandler(
            "DELETE FROM book WHERE id = @id",            
            async cmd =>
            {
                cmd.Parameters.AddWithValue("@id", id);
                rows = await cmd.ExecuteNonQueryAsync();
            });
            return rows;
        }

        public async Task<BindingList<BookInfo>> GetAllAsync()
        {
            var list = new BindingList<BookInfo>();
            await _executor.ConAndHandler(
                "SELECT id, uid, name, author, price, label, is_borrow FROM book",
                async cmd =>
                {
                    MySqlDataReader mySqlDataReader = await cmd.ExecuteReaderAsync();
                    while (await mySqlDataReader.ReadAsync())
                    {
                        list.Add(new BookInfo(
                                mySqlDataReader.GetInt32("id"),
                                mySqlDataReader.GetString("uid")
                            )
                        {
                            Name = mySqlDataReader.GetString("name"),
                            Author = mySqlDataReader.GetString("author"),
                            Price = mySqlDataReader.GetDouble("price"),
                            Label = mySqlDataReader.GetString("label"),
                            IsBorrow = mySqlDataReader.GetBoolean("is_borrow")
                        }
                        );
                    }
                });

            return list;
        }

        public async Task<BookInfo>? GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }
        public async Task<BookInfo> UpdateAsync(BookInfo bookInfo)
        {
            var sql = @"
                UPDATE book SET name=@name,author=@author,price=@price,label=@label WHERE id=@id;                
        
                SELECT * FROM book WHERE id=@id;";

            await _executor.ConAndHandler(sql,
                async cmd =>
                {                                        
                    cmd.Parameters.AddWithValue("@id", bookInfo.Id);
                    cmd.Parameters.AddWithValue("@name", bookInfo.Name);
                    cmd.Parameters.AddWithValue("@author", bookInfo.Author);
                    cmd.Parameters.AddWithValue("@price", bookInfo.Price);
                    cmd.Parameters.AddWithValue("@label", bookInfo.Label); 
                    using MySqlDataReader mySqlDataReader = await cmd.ExecuteReaderAsync();

                    // 如果当前结果集没有行，跳到下一个结果集（SELECT 的结果）
                    if (!await mySqlDataReader.ReadAsync())
                    {
                        if (!await mySqlDataReader.NextResultAsync())
                            throw new Exception("更新后未返回数据");

                        if (!await mySqlDataReader.ReadAsync())
                            throw new Exception("更新后未返回数据");
                    }
                    //await mySqlDataReader.ReadAsync();

                    //await mySqlDataReader.ReadAsync();
                    bookInfo = new BookInfo(
                                    mySqlDataReader.GetInt32("id"),
                                    mySqlDataReader.GetString("uid")
                                )
                    {
                        Name = mySqlDataReader.GetString("name"),
                        Author = mySqlDataReader.GetString("author"),
                        Price = mySqlDataReader.GetDouble("price"),
                        Label = mySqlDataReader.GetString("label"),
                        IsBorrow = mySqlDataReader.GetBoolean("is_borrow")
                    };
                }
            );
            //MessageBox.Show(bookInfo.Name);
            return bookInfo;
        }
        
        public async Task<int> BorrowAsync(int id) {
            int rows = 0;
            var sql = @"
                UPDATE book SET is_borrow=true WHERE id=@id";

            await _executor.ConAndHandler(sql,
                async cmd =>
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    rows = await cmd.ExecuteNonQueryAsync();
                });
            return rows;
        }
        
        public async Task<int> ReturnAsync(int id) {
            int rows = 0;
            var sql = @"
                UPDATE book SET is_borrow=false WHERE id=@id";

            await _executor.ConAndHandler(sql,
                async cmd =>
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    rows = await cmd.ExecuteNonQueryAsync();
                });
            return rows;
        }
    }
}
