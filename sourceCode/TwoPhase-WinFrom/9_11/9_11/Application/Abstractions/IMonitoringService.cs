using _9_11.Domain.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace _9_11.Application.Abstractions
{
    internal interface IMonitoringService
    {
        //internal Action<object?, TempReadEventArgs> TempRead { get; set; }
        internal event EventHandler<TempReadEventArgs>? TempRead;
        internal Task DeviceStartAsync();
        internal Task DeviceStopAsync();
        internal Task GetConnectAsync();
        internal Task LostConnectAsync();
        internal Task SetTemperatureAsync(double temperature);
    }
}
