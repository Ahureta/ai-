 using _9_11.Domain.Entities;
using _9_11.Domain.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace _9_11.Domain.Interfaces
{
    internal interface ITemperatureProvider
    {        
        void Start();
        void Stop();
        event EventHandler<DeviceTempRecord>? DataReceived;
        event EventHandler<Exception>? ErrorOccurred;
        Task<DeviceTempRecord> LoopReadCurrentAsync();  // 循环返回当前采集记录        
    }
}
