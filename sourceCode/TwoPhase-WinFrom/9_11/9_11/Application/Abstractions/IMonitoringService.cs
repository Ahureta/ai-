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

/*
┌─────────────────────────────────────────────────────────────┐
│  Modbus 设备 (500ms/次)                                     │
└───────────────────────────┬─────────────────────────────────┘
                            │ 读取
┌───────────────────────────▼─────────────────────────────────┐
│  TemperatureProvider                                        │
│  返回 DeviceTempRecord                                      │
└───────────────────────────┬─────────────────────────────────┘
                            │
┌───────────────────────────▼─────────────────────────────────┐
│  MonitoringService (Service 层)                              │
│                                                             │
│  ┌─────────────┐    ┌─────────────────────────────────┐    │
│  │ Timer Tick  │───▶│ Channel<DeviceTempRecord>       │    │
│  │ (生产者)    │    │ 队列（上限1000，满了丢旧数据）   │    │
│  └─────────────┘    └──────────────┬──────────────────┘    │
│                                    │                        │
│                            ┌───────▼────────┐              │
│                            │ 后台消费者 Task │              │
│                            │ 攒50条 或 10秒  │              │
│                            │ → BulkInsert   │              │
│                            └────────────────┘              │
│                                    │                        │
│                            ┌───────▼────────┐              │
│                            │ TempRead 事件   │──────────────┼──▶ UI
│                            └────────────────┘              │
└─────────────────────────────────────────────────────────────┘
                            │
┌───────────────────────────▼─────────────────────────────────┐
│  MainForm (UI 层)                                           │
│  BulkBindingList（上限500条，滑动窗口）                      │
│  DataGridView 绑定显示                                      │
└─────────────────────────────────────────────────────────────┘
                            │
                    用户点"历史数据"
                            │
┌───────────────────────────▼─────────────────────────────────┐
│  历史查询界面                                                │
│  SELECT * FROM TempRecords                                  │
│  WHERE Time BETWEEN @start AND @end                         │
│  ORDER BY Time DESC                                         │
│  OFFSET @pageSize * (@page - 1) ROWS                        │
│  FETCH NEXT @pageSize ROWS ONLY                             │
│  （分页查询，从数据库取，不碰内存缓存）                       │
└─────────────────────────────────────────────────────────────┘
 */