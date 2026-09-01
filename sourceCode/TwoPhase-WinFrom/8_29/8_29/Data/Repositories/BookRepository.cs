using _8_29.Info;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using System.Xml.Linq;

namespace _8_29.Data.Repositories
{
    internal class BookRepository : IBookRepository
    {
        static readonly string ConnStr = "server=localhost;port=3306;database=testDB;uid=root;pwd=Qaz2109537;charset=utf8";

        private MySqlDataSourceBuilder builder;
        private MySqlDataSource dataSource;
        public BookRepository() {
            //自动工厂无需创建
            builder = new MySqlDataSourceBuilder(BookRepository.ConnStr);
            dataSource = builder.Build();

            // 每次需要连接时：
            //using var conn = dataSource.CreateConnection();
            //await conn.OpenAsync();
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
            using var conn = dataSource.CreateConnection();
            await conn.OpenAsync();                    // 连接数据库（I/O）→ await

            using var cmd = new MySqlCommand("SELECT * FROM book", conn);
            using var reader = await cmd.ExecuteReaderAsync();   // 查询（I/O）→ await

            var list = new List<BookInfo>();
            
            while (await reader.ReadAsync())          // 读取每行（I/O）→ await
            {
                bool.TryParse(reader.GetString("is_borrow"), out bool is_borrow);
                list.Add(new BookInfo(
                            reader.GetInt32("id"),
                            reader.GetString("name"),
                            reader.GetString("author"),
                            reader.GetDouble("price"),

                            reader.GetString("label"),
                            is_borrow                        
                        )
                    );
            }
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
}
