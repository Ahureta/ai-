using _8_29.Info;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace _8_29.Data.Repositories
{
    internal class MySqlExecutor
    {
        // 连接数据 属性
        private string server { get; set; } = "127.0.0.1";
        private string port { get; set; } = "3306";
        private string database { get; set; } = "testdb";
        private string uid { get; set; } = "root";
        private string password { get; set; } = "Qaz2109537";
        private string charset { get; set; } = "utf8";

        private string connStr { get; set; }
        private MySqlDataSource mySqlDataSource;

        public MySqlExecutor(MySqlDataSource mySqlDataSource)
        {
            this.mySqlDataSource = mySqlDataSource;
        }

        public MySqlExecutor()
        {
        }

        private MySqlDataSource GetMySqlDataSource()
        {
            if (mySqlDataSource == null)
            {
                connStr = $"server={server};port={port};database={database};uid={uid};password={password};charset={charset}";
                // 组合根：创建一次 dataSource，全局共享
                MySqlDataSourceBuilder builder = new(connStr);
                mySqlDataSource = builder.Build();
            }
            return mySqlDataSource;
        }

        public async Task ConAndHandler(string sql, Func<MySqlDataReader, Task> handlerCall)
        {


            // 注入到 MySqlExecutor
            MySqlDataSource getMySqlDataSource = GetMySqlDataSource();

            await using var conn = await getMySqlDataSource.OpenConnectionAsync(); // 从池中获取连接
            await using var cmd = new MySqlCommand(sql, conn);
            await using var exe = await cmd.ExecuteReaderAsync();
            await handlerCall(exe);
            //// 连接数据库
            //using (MySqlConnection Conn = new MySqlConnection(connStr))
            //{
            //    // 打开连接
            //    await Conn.OpenAsync();
            //    // 创建命令对象
            //    using (MySqlCommand Cmd = new MySqlCommand(sql, Conn))
            //    {
            //        handlerCall(Cmd); // 执行后续操作
            //    }
            //}
        }
    }
}
