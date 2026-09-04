using _8_29.Info;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Text;

namespace _8_29.Data.Repositories
{
    public interface IBookRepository
    {
        Task<List<BookInfo>> GetAllAsync();
        Task<BookInfo>? GetByIdAsync(int id);
        Task<BookInfo> AddAsync(BookInfo BookInfo);         // 返回新ID
        Task<BookInfo> UpdateAsync(BookInfo BookInfo);     // 返回是否影响行数
        Task<BookInfo> DeleteAsync(int id);        // 返回是否影响行数
    }
}
