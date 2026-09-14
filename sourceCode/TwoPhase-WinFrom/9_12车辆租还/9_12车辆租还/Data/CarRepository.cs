using _8_29.Info;
using MySqlConnector;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Dynamic;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;

namespace _8_29.Data.Repositories
{
    internal class CarRepository : ICarRepository
    {
        private readonly MySqlExecutor _executor;

        public CarRepository()
        {
            _executor = new MySqlExecutor();
        }

        public CarRepository(MySqlDataSource dataSource)
        {
            _executor = new MySqlExecutor(dataSource);
        }

        public async Task<int> CarAddAsync(CardInfo cardInfo)
        {
            int res = 0;
            var sql = @"
                INSERT INTO car (card,type,status,price)
                VALUES (@Card,@Type,@Status,@Price)";

            await _executor.ConAndHandler(sql,
                async cmd =>
                {                    
                    cmd.Parameters.AddWithValue("@Card", cardInfo.Card);
                    cmd.Parameters.AddWithValue("@Type", cardInfo.Type);
                    cmd.Parameters.AddWithValue("@Price", cardInfo.Price);
                    cmd.Parameters.AddWithValue("@Status", false);
                    res = await cmd.ExecuteNonQueryAsync();
                }
            );            
            return res;
        }

        public async Task<int> UserAddAsync(UserInfo userInfo)
        {
            int res = 0;
            var sql = @"
                INSERT INTO user_info (name,id_card,reg_time,gender,tel,motto)
                VALUES (@Name,@IdCard,@Reg_time,@Gender,@Tel,@Motto)";

            await _executor.ConAndHandler(sql,
                async cmd =>
                {                    
                    cmd.Parameters.AddWithValue("@Name", userInfo.Name);
                    cmd.Parameters.AddWithValue("@IdCard", userInfo.IdCard);
                    cmd.Parameters.AddWithValue("@Reg_time", userInfo.RegTime);
                    cmd.Parameters.AddWithValue("@Gender", userInfo.Gender);
                    cmd.Parameters.AddWithValue("@Tel", userInfo.Tel);
                    cmd.Parameters.AddWithValue("@Motto", userInfo.Motto);
                    res = await cmd.ExecuteNonQueryAsync();
                }
            );
            return res;
        }

        public async Task<BindingList<CardInfo>> GetCarAsync()
        {
            var list = new BindingList<CardInfo>();
            await _executor.ConAndHandler(
                "SELECT * FROM car",
                async cmd =>
                {
                    MySqlDataReader mySqlDataReader = await cmd.ExecuteReaderAsync();
                    while (await mySqlDataReader.ReadAsync())
                    {
                        list.Add(new CardInfo(
                                mySqlDataReader.GetInt32("id")                                
                            )
                        {
                            Card = mySqlDataReader.GetString("card"),
                            Type = mySqlDataReader.GetString("type"),
                            Status = mySqlDataReader.GetBoolean("status"),                        
                            Price = mySqlDataReader.GetDouble("price")
                        }
                        );
                    }
                });            
            return list;
        }

        public async Task<BindingList<UserInfo>> GetUserAsync()
        {
            var list = new BindingList<UserInfo>();
            await _executor.ConAndHandler(
                "SELECT * FROM user_info",
                async cmd =>
                {
                    MySqlDataReader mySqlDataReader = await cmd.ExecuteReaderAsync();
                    while (await mySqlDataReader.ReadAsync())
                    {
                        list.Add(new UserInfo(
                                mySqlDataReader.GetInt32("id")
                            )
                        {                            
                            Name = mySqlDataReader.GetString("name"),
                            IdCard = mySqlDataReader.GetString("id_card"),
                            RegTime = mySqlDataReader.GetDateTime("reg_time"),
                            Gender = mySqlDataReader.GetString("gender"),
                            Tel = mySqlDataReader.GetString("tel"),
                            Motto = mySqlDataReader.GetString("motto")
                        }
                        );
                    }
                });

            return list;
        }

        public async Task<int> BorrowAsync(RentRecordInfo rentRecordInfo)
        {
            int rows = 0;
            var sql = @"
                INSERT INTO rent_return (car_id,user_id,rent_time)
                VALUES (@CarId,@UserId,@RentTime)";

            await _executor.ConAndHandler(sql,
                async cmd =>
                {
                    cmd.Parameters.AddWithValue("@CarId", rentRecordInfo.CarId);
                    cmd.Parameters.AddWithValue("@UserId", rentRecordInfo.UserId);
                    cmd.Parameters.AddWithValue("@RentTime", rentRecordInfo.RentTime);
                    rows += await cmd.ExecuteNonQueryAsync();
                }
            );
            
            var sql2 = @"
                UPDATE car SET status=true WHERE id=@id";

            await _executor.ConAndHandler(sql2,
                async cmd =>
                {
                    cmd.Parameters.AddWithValue("@id", rentRecordInfo.CarId);
                    rows += await cmd.ExecuteNonQueryAsync();
                });
            return rows;

        }

        public async Task<int> ReturnAsync(CardInfo cardInfo)
        {
            int rows = 0;
            DateTime rentTime = new();

            var sql = @"SELECT rent_time FROM rent_return WHERE car_id = @CarId AND return_time IS NULL LIMIT 1";

            await _executor.ConAndHandler(sql,
                async cmd =>
                {
                    cmd.Parameters.AddWithValue("@CarId", cardInfo.Id);
                    using (var mySqlDataReader = await cmd.ExecuteReaderAsync())
                    {
                        if (!await mySqlDataReader.ReadAsync())  // ← 关键：判断有没有读到
                        {
                            throw new InvalidOperationException($"车辆 {cardInfo.Id} 没有未归还的租借记录");
                        }
                        rentTime = mySqlDataReader.GetDateTime("rent_time");
                    }  // ← using 自动关闭 reader，否则下面 sql2 复用连接会冲突
                }
            );

            var sql2 = @"UPDATE rent_return SET return_time = @ReturnTime, pay_money = @PayMoney WHERE car_id = @CarId";

            await _executor.ConAndHandler(sql2,
                async cmd =>
                {
                    cmd.Parameters.AddWithValue("@CarId", cardInfo.Id);       // ← 名字和 SQL 一致
                    cmd.Parameters.AddWithValue("@ReturnTime", DateTime.Now);
                    cmd.Parameters.AddWithValue("@PayMoney", (DateTime.Now - rentTime).TotalHours * cardInfo.Price);
                    rows += await cmd.ExecuteNonQueryAsync();
                }
            );
            //DateTime rentTime = new();

            //var sql = @"
            //    SELECT rent_time FROM rent_return WHERE car_id=@CarId";

            //await _executor.ConAndHandler(sql,
            //    async cmd =>
            //    {
            //        cmd.Parameters.AddWithValue("@CarId", cardInfo.Id);
            //        MySqlDataReader mySqlDataReader = await cmd.ExecuteReaderAsync();
            //        await mySqlDataReader.ReadAsync();
            //        rentTime = mySqlDataReader.GetDateTime("rent_time");
            //    }
            //);

            ////var sql2 = @"
            ////    SELECT rent_time FROM user_info WHERE car_id=@arId";

            ////await _executor.ConAndHandler(sql2,
            ////    async cmd =>
            ////    {
            ////        cmd.Parameters.AddWithValue("@id", cardInfo.Id);
            ////        rows += await cmd.ExecuteNonQueryAsync();
            ////    });

            //var sql2 = @"
            //    UPDATE rent_return SET return_time=@ReturnTime, pay_money=@PayMoney WHERE car_id=@carId";

            //await _executor.ConAndHandler(sql2,
            //    async cmd =>
            //    {
            //        cmd.Parameters.AddWithValue("@carId", cardInfo.Id);
            //        cmd.Parameters.AddWithValue("@ReturnTime", DateTime.Now);
            //        cmd.Parameters.AddWithValue("@PayMoney", (DateTime.Now-rentTime).TotalHours * cardInfo.Price);
            //        rows += await cmd.ExecuteNonQueryAsync();
            //    });

            var sql3 = @"
                UPDATE car SET status=false WHERE id=@id";

            await _executor.ConAndHandler(sql3,
                async cmd =>
                {
                    cmd.Parameters.AddWithValue("@id", cardInfo.Id);
                    rows += await cmd.ExecuteNonQueryAsync();
                });

            return rows;           
        }
    }
}
