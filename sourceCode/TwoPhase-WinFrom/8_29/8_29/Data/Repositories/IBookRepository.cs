using _8_29.Info;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace _8_29.Data.Repositories
{
    public interface IBookRepository
    {
        Task<List<BookInfo>> GetAll();
        Task<BookInfo>? GetById(int id);
        Task<int> Add(BookInfo BookInfo);         // 返回新ID
        Task<bool> Update(BookInfo BookInfo);     // 返回是否影响行数
        Task<bool> Delete(int id);        // 返回是否影响行数
    }
}
