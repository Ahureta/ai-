using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;

namespace _9_11.Infrastructure.Repositories
{
    internal class MysqlBase
    {
        private string IP = "127.0.0.1";
        private int Port = 3306;
        private string DataBase = "testdb";
        private string Uid = "root";
        private string Password = "Qaz2109537";
        private string Charset = "utf8";
        private string _connStr = "";
        private MySqlDataSource mySqlDataSource;

        internal MysqlBase()
        {
            _connStr = $"server={IP};port={Port};database={DataBase};uid={Uid};password={Password};charset={Charset}";

            if (mySqlDataSource == null)    //最好Lazy懒加载数据库连接池，线程安全
            {                
                MySqlDataSourceBuilder builder = new(_connStr);
                mySqlDataSource = builder.Build();
            }
        }
        internal MysqlBase(string db)
        {
            DataBase = db;
            _connStr = $"server={IP};port={Port};database={DataBase};uid={Uid};password={Password};charset={Charset}";

            if (mySqlDataSource == null)
            {                
                MySqlDataSourceBuilder builder = new(_connStr);
                mySqlDataSource = builder.Build();
            }
        }

        protected async Task<MySqlConnection> GetOpenConnectionAsync()
        {
            return await mySqlDataSource.OpenConnectionAsync();
        }

        // 通用的 ExecuteNonQuery
        protected async Task<int> ExecuteAsync(string sql, params MySqlParameter[] parameters)
        {
            using var conn = await GetOpenConnectionAsync();
            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddRange(parameters);
            return await cmd.ExecuteNonQueryAsync();
        }

        // 通用的查询（返回 DataTable，给需要动态列的场景用）
        protected async Task<DataTable> QueryDataTableAsync(string sql, params MySqlParameter[] parameters)
        {
            var dt = new DataTable();
            await using var conn = await GetOpenConnectionAsync();
            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddRange(parameters);

            using var reader = await cmd.ExecuteReaderAsync();  // ← 真异步
            dt.Load(reader);  // ← Load 也是同步的，但 reader 读取是异步的

            //using var adapter = new MySqlDataAdapter(cmd);
            //adapter.Fill(dt);  // DataAdapter 没有 Async 版本，只能同步
            return dt;
        }

        public void Dispose()
        {
            mySqlDataSource?.Dispose();
            mySqlDataSource = null;
        }

        /*
         //事务加强版
         // ===== MysqlBase 里加这个 =====
        protected async Task<int> ExecuteInTransactionAsync(
            MySqlConnection conn,
            MySqlTransaction transaction,
            string sql,
            params MySqlParameter[] parameters)
        {
            using var cmd = new MySqlCommand(sql, conn, transaction);  // ← 绑定连接+事务
            cmd.Parameters.AddRange(parameters);
            return await cmd.ExecuteNonQueryAsync();
        }

        FlushBatchAsync 开始
            ↓
        1. 打开连接
            ↓
        2. BeginTransaction（MySQL 默认 REPEATABLE READ）
            ↓
        3. 拼 SQL + 参数
            ↓
        4. ExecuteNonQuery（在事务内执行 INSERT）
            ↓
            ├─ 成功 → Commit → 数据落盘
            └─ 失败 → Rollback → 数据库恢复原样，一条都没写进去
            ↓
        5. finally 释放连接

         */


        //// 封装一个连接数据库并查询数据的方法(返回一个datatable数据)
        //internal async Task<DataTable> SearchData(string sql)
        //{
        //    // 定义一个DataTable
        //    DataTable dt = new();
        //    using (MySqlConnection Conn = new MySqlConnection(ConnStr))
        //    {
        //        // 打开连接
        //        await Conn.OpenAsync();
        //        using (MySqlCommand CMD = new MySqlCommand(sql, Conn))
        //        {
        //            MySqlDataAdapter Ada = new MySqlDataAdapter(CMD);
        //            Ada.Fill(dt);
        //        }
        //    }
        //    return dt;
        //}

        //// 封装一个连接数据库并操作(新增,删除,修改)数据的方法(返回一个datatable数据)
        //internal async Task<bool> Handler(string sql)
        //{
        //    using (MySqlConnection Conn = new MySqlConnection(ConnStr))
        //    {
        //        // 打开连接
        //        await Conn.OpenAsync();
        //        using (MySqlCommand CMD = new MySqlCommand(sql, Conn))
        //        {
        //            int row = CMD.ExecuteNonQuery();
        //            if (row > 0) return true;
        //            return false;
        //        }
        //    }
        //}
    }
}
