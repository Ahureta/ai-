using _8_29.Info;
using MySqlConnector;
using System;
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

        public async Task<int> Add(BookInfo BookInfo)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<BookInfo>> GetAll()
        {
            var list = new List<BookInfo>();

            await _executor.ConAndHandler(
                "SELECT id, uid, name, author, price, label, is_borrow FROM book",
                async reader =>
                {
                    while (await reader.ReadAsync())
                    {
                        list.Add(new BookInfo(
                                reader.GetInt32("id"),
                                reader.GetString("uid")
                            )
                        {
                            Name = reader.GetString("name"),
                            Author = reader.GetString("author"),
                            Price = reader.GetDouble("price"),
                            Label = reader.GetString("label"),
                            IsBorrow = reader.GetBoolean("is_borrow")
                        }
                        );
                    }
                });

            return list;
        }

        public async Task<BookInfo>? GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> Update(BookInfo BookInfo)
        {
            throw new NotImplementedException();
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
