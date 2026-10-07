using _9_11.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace _9_11.Domain.Interfaces
{
    public interface ITempRecordRepository
    {
        Task InsertOneAsync(DeviceTempRecord record);
        Task<List<DeviceTempRecord>> GetPageAsync(int page, int pageSize, DateTime? start, DateTime? end);
        Task FlushBatchAsync(List<DeviceTempRecord> batch);
    }
}
