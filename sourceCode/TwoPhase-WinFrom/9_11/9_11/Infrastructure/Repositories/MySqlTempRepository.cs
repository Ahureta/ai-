using _9_11.Domain.Entities;
using _9_11.Domain.Enums;
using _9_11.Domain.Interfaces;
using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.Text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _9_11.Infrastructure.Repositories
{
    internal class MySqlTempRepository : MysqlBase, ITempRecordRepository
    {
        private static MysqlBase myBase = new MysqlBase("test");

        public async Task<List<DeviceTempRecord>> GetPageAsync(int page, int pageSize, DateTime? start, DateTime? end)
        {
            // 如果需要 DataTable 做 UI 绑定，可以在这里转
            //简写*
            /*
                Id
                CollectTime
                DeviceStatus
                SetTemp
                RealTemp
                FaultCode
             */

            var dt = await QueryDataTableAsync(
                @"SELECT * FROM DeviceTempRecord
                    WHERE CollectTime BETWEEN @start AND @end 
                    ORDER BY CollectTime DESC
                    LIMIT @offset, @pageSize",
                new MySqlParameter("@start", start),
                new MySqlParameter("@end", end),
                new MySqlParameter("@offset", (page - 1) * pageSize),
                new MySqlParameter("@pageSize", pageSize)
            );

            // 转成强类型
            var result = new List<DeviceTempRecord>();
            foreach (DataRow row in dt.Rows)
            {
                result.Add(new DeviceTempRecord
                (
                    id: (int)row["Id"],
                    collectTime: (DateTime)row["CollectTime"],
                    deviceStatus: (ushort)row["DeviceStatus"],
                    setTemp: (ushort)row["SetTemp"],
                    realTemp: (ushort)row["RealTemp"],
                    faultCode: (int)row["FaultCode"]
                ));
            }
            return result;
        }
        //{
        //    string sql = $"select * from DeviceTempRecord where CollectTime between '{t1}' and  '{t2}' order by CollectTime DESC";
        //    return await myBase.SearchData(sql);
        //    throw new NotImplementedException();
        //}

        public async Task FlushBatchAsync(List<DeviceTempRecord> batch)
        {
            ArgumentNullException.ThrowIfNull(batch);

            int count = batch.Count;
            if (count == 0)
                return;

            //string sql = $"insert into DeviceTempRecord(CollectTime,DeviceStatus,SetTemp,RealTemp,FaultCode) value('{CollectTimeVal}','{DeviceStatusVal}','{SetTempVal}','{RealTempVal}','{FaultCodeVal}') ";
            string sql1 = @"insert into DeviceTempRecord(CollectTime,DeviceStatus,SetTemp,RealTemp,FaultCode) ";
            string sql2 = "";
            List<MySqlParameter> mySqlParameters = new();

            for (int i = 0; i < count; i++)
            {
                sql2 += $"(@DeviceStatus{i},@SetTemp{i},@RealTemp{i},@FaultCode{i})";
                if (i < count - 1) sql2 += ",";
                mySqlParameters.AddRange([                
                    //new MySqlParameter($"@CollectTime{i}", batch[i].CollectTime), @CollectTime{i},
                    new MySqlParameter($"@DeviceStatus{i}", (byte)batch[i].DeviceStatus),
                    new MySqlParameter($"@SetTemp{i}", batch[i].SetTemp),
                    new MySqlParameter($"@RealTemp{i}", batch[i].RealTemp),
                    new MySqlParameter($"@FaultCode{i}", (byte)batch[i].FaultCode)
                ]);
            }
            
            var rowsAffected = await ExecuteAsync(
                sql1 + " Values" + sql2,
                [.. mySqlParameters]
            );
        }

        public Task InsertOneAsync(DeviceTempRecord record)
        {
            //var CollectTimeVal = DateTime.Now;
            //var DeviceStatusVal = record[0];
            //var SetTempVal = record[1];
            //var RealTempVal = record[2];
            //var FaultCodeVal = record[3];

            //string sql = $"insert into DeviceTempRecord(CollectTime,DeviceStatus,SetTemp,RealTemp,FaultCode) value('{CollectTimeVal}','{DeviceStatusVal}','{SetTempVal}','{RealTempVal}','{FaultCodeVal}') ";
            ////Console.WriteLine(sql);
            //return await myBase.Handler(sql);

            throw new NotImplementedException();
        }
    }
}
