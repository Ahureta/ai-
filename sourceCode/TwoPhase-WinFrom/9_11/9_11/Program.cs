using _9_11.UI.Forms;
using System.Configuration;
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _9_11
{
    internal static class Program
    {
        [DllImport("kernel32.dll")]
        public static extern bool AllocConsole();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AllocConsole();   //控制台
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            System.Windows.Forms.Application.Run(new MainForm());

            //MainForm 加载
            //→ 调用 _monitoring.Start()
            //→ MonitoringService 启动 Timer
            //→ 每 500ms 调用 ITemperatureProvider.ReadCurrentAsync()
            //    → 具体实现读取 Modbus 寄存器，解析出 DeviceTempRecord
            //→ 触发 TempRead 事件
            //    → MainForm 收到事件，更新 BindingList
            //→ 异步调用 ITempRecordRepository.InsertAsync(record)
            //    → SQLite / MySQL 保存历史记录

            //MainForm 点击“历史查询”
            //→ 调用 _repository.GetPageAsync(page, pageSize, startTime, endTime)
            //→ UI 用 BulkBindingList.ReplaceAll(records) 刷新表格

            //关注点 实现建议
            //配置管理 appsettings.json + IConfiguration，或自研 AppConfig 类
            //日志  接口 IAppLogger，实现写文件 / 事件日志，可轮转
            //异常处理    每层捕获边界异常，UI 层只弹窗提示，不能崩溃
            //断线重连    TemperatureProvider 内部捕获 IO 异常，定时重试，改变设备状态
            //防数据风暴   MonitoringService 用 _isReading 防重入，失败时自动降频
            //单元测试    用 SimulatedTemperatureProvider 和 mock Repository 测试应用层逻辑
        }
    }
}


/*
 [STAThread]
static void Main()
{
    ApplicationConfiguration.Initialize();

    var services = new ServiceCollection();
    ConfigureServices(services);

    using var serviceProvider = services.BuildServiceProvider();
    var mainForm = serviceProvider.GetRequiredService<MainForm>();
    Application.Run(mainForm);
}

private static void ConfigureServices(IServiceCollection services)
{
    // 配置文件
    var config = AppConfig.Load("appsettings.json");

    // 基础设施
    services.AddSingleton<IModbusClient>(sp => 
        new ModbusRtuClient(config.ComPort, config.BaudRate, config.DataBits, config.Parity, config.StopBits));
    services.AddSingleton<ITemperatureProvider, TemperatureProvider>();
    services.AddSingleton<ITempRecordRepository, SqliteTempRepository>();
    services.AddSingleton<IAppLogger, FileLogger>();

    // 应用服务
    services.AddSingleton<IMonitoringService, MonitoringService>();
    services.AddSingleton<IDeviceCommandService, DeviceCommandService>();

    // UI
    services.AddTransient<MainForm>();
}
 */