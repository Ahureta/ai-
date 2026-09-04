using _8_29.Info;
using MySqlConnector;
using System;
using System.Collections;
using System.Collections.Generic;
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

        public async Task<BookInfo> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<BookInfo>> GetAllAsync()
        {
            var list = new List<BookInfo>();

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
    }



    //internal class BookRepository : IBookRepository
    //{
    //    static readonly string ConnStr = "server=localhost;port=3306;database=testDB;uid=root;pwd=Qaz2109537;charset=utf8";

    //    private MySqlDataSourceBuilder builder;
    //    private MySqlDataSource dataSource;
    //    public BookRepository() {
    //        //自动工厂无需创建
    //        builder = new MySqlDataSourceBuilder(BookRepository.ConnStr);
    //        dataSource = builder.Build();

    //        // 每次需要连接时：
    //        //using var conn = dataSource.CreateConnection();
    //        //await conn.OpenAsync();
    //    }

    //    public async Task<int> Add(BookInfo BookInfo)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public async Task<bool> Delete(int id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public async Task<List<BookInfo>> GetAll()
    //    {
    //        using var conn = dataSource.CreateConnection();
    //        await conn.OpenAsync();                    // 连接数据库（I/O）→ await

    //        using var cmd = new MySqlCommand("SELECT * FROM book", conn);
    //        using var reader = await cmd.ExecuteReaderAsync();   // 查询（I/O）→ await

    //        var list = new List<BookInfo>();

    //        while (await reader.ReadAsync())          // 读取每行（I/O）→ await
    //        {                
    //            list.Add(new BookInfo(
    //                    id: reader.GetInt32("id"),
    //                    uid: reader.GetString("uid")                      
    //                ){
    //                    Name = reader.GetString("name"),
    //                    Author = reader.GetString("author"),
    //                    Price = reader.GetDouble("price"),
    //                    Label = reader.GetString("label"),
    //                    IsBorrow = reader.GetBoolean("is_borrow")
    //                }
    //            );
    //        }
    //        return list;            
    //    }

    //    public async Task<BookInfo>? GetById(int id)
    //    {
    //        throw new NotImplementedException();
    //    }

    //    public async Task<bool> Update(BookInfo BookInfo)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
