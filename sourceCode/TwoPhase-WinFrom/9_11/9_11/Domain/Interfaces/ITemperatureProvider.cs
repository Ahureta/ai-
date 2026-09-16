using _9_11.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace _9_11.Domain.Interfaces
{
    public interface ITemperatureProvider
    {
        Task<DeviceTempRecord> ReadCurrentAsync();  // 返回当前采集记录
    }
}
