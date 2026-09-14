using _8_29.Info;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace _8_29.Data.Repositories
{
    public interface ICarRepository
    {
        Task<BindingList<CardInfo>> GetCarAsync();
        Task<BindingList<UserInfo>> GetUserAsync();
        Task<int> CarAddAsync(CardInfo cardInfo);
        Task<int> UserAddAsync(UserInfo userInfo);
        Task<int> BorrowAsync(RentRecordInfo rentRecordInfo);
        Task<int> ReturnAsync(CardInfo cardInfo);        
    }
}
