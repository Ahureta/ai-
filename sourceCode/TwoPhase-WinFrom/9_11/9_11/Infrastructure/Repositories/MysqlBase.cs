using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
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
        private string ConnStr = "";

        internal MysqlBase()
        {            
            ConnStr = $"server={IP};port={Port};database={DataBase};uid={Uid};password={Password};charset={Charset}";
        }
        internal MysqlBase(string db)
        {
            DataBase = db;
            ConnStr = $"server={IP};port={Port};database={DataBase};uid={Uid};password={Password};charset={Charset}";
        }

        protected async Task<MySqlConnection> GetOpenConnectionAsync()
        {
            var conn = new MySqlConnection(ConnStr);
            await conn.OpenAsync();
            return conn;
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
            using var conn = await GetOpenConnectionAsync();
            using var cmd = new MySqlCommand(sql, conn);
            cmd.Parameters.AddRange(parameters);
            using var adapter = new MySqlDataAdapter(cmd);
            adapter.Fill(dt);  // DataAdapter 没有 Async 版本，只能同步
            return dt;
        }


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
