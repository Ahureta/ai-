using AntdUI;
using Cognex.VisionPro;
using Cognex.VisionPro.ToolBlock;
using IndustrialVisionSort.Application;
using IndustrialVisionSort.Application.Implementation;
using IndustrialVisionSort.DoMain.Events;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndustrialVisionSort.ui.Controls.UC
{
    public partial class UcMain : UserControl
    {
        private RobotService _robotService;
        //private ArmTcpClient _armClient;
        private CameraService _cameraService;
        private ModbusService _modbusService;
        int Count;
        double X, Y;

        private bool _isLive = false;
        private CogToolBlock CTB { get; set; }      // 视觉检测方案(ToolBlock)

        public event EventHandler<FrameAcquiredEventArgs> FrameAcquired;

        internal UcMain(CameraService cameraService, ModbusService modbusService, RobotService robotService)
        {
            InitializeComponent();
            InitServices(cameraService, modbusService, robotService);
            
            Init();
            //_cameraService = cameraService;
            //_modbusService = modbusService;
            //_robotService = robotService;
        }
        // ---- 初始化 ----
        internal void InitServices(CameraService cameraService, ModbusService modbusService, RobotService robotService)
        {
            _cameraService = cameraService;
            _modbusService = modbusService;
            _robotService = robotService;
            //_armClient = new ArmTcpClient();

            InitEvent();
        }
        private void InitEvent()
        {
            _robotService.LogMessage += (sender, message) => {
                MessageBox.Show("连接状态"+message);
            };
        }

        public void Init() {
            //初始化VPP方案
            //string path = @"E:\pro\software\Github\GitRepository\ai视觉作业\sourceCode\Three-visionPro\IndustrialVisionSort\IndustrialVisionSort\bin\Debug\vpps\瓶盖检测new.vpp";
            string path = @".\vpps\瓶盖检测Down.vpp";
            CTB = CogSerializer.LoadObjectFromFile(path) as CogToolBlock;

            //事件触发VPP方案
            _cameraService.FrameAcquired += (s, e) => FrameAcquired.Invoke(s, e);
            FrameAcquired += async(s,e) =>
            {
                try
                {
                    Console.WriteLine("检测到");
                    //if (!_isLive) return;


                    //检测到后停止传输带
                    _modbusService.Stop();

                    //延迟原因传输带停止后再次拍照    不好搞
                    //_cameraService.SetManual();
                    //_cameraService.SetAuto();

                    // 将采集到的图形给到CTB
                    CTB.Inputs["InputImage"].Value = e.Image;

                    // 开始执行CTB
                    CTB.Run();

                    cogRecordDisplay.Image = e.Image;       //如果可以给CTB结果图

                    Count = (int)CTB.Outputs["Count"].Value;
                    X = (double)(CTB.Outputs["X"].Value);
                    Y = (double)(CTB.Outputs["Y"].Value);

                    Console.WriteLine("检测的瓶盖坐标---");
                    Console.WriteLine(X);
                    Console.WriteLine(Y);
                    Console.WriteLine("检测的瓶盖坐标---");

                    //拍照后上料位传输坐标由机械臂执行移动
                    await _robotService.PointMove((float)X, (float)Y, 80);
                    //await _robotService.SetHOMECmd();
                    //await _robotService.ClearAllAlarmsState();
                    //await _robotService.PointMove((float)200,(float)-17,80);

                    //重新开始传送带
                    await Task.Delay(TimeSpan.FromSeconds(2));      //先睡两秒·
                    _modbusService.Start();
                    //internal async Task PointMove(float goalX, float goalY, float goalZ)
                }
                catch (Exception err) {
                    Console.WriteLine(err);
                    MessageBox.Show("异常："+err);
                }
            };

        }
        private void Cleanup()
        {
            //_robotService?.Disconnect();
            _modbusService?.Dispose();
        }

        private void BTStopSort_Click(object sender, EventArgs e)
        {

        }

        private async void BTStartSort_Click(object sender, EventArgs e)
        {
            //await _robotService.PointMove((float)200, (float)-17, 50);

            //传送带启动
            //_modbusService.Connect();
            _modbusService.SetSpeed(200);
            _modbusService.Start();
            //相机开始自动拍照
            _cameraService.InitializeImageSource();
            _cameraService.SetAuto();
            //VPP方案检测
            //事件检测

            ////检测到后停止传输带
            //if (Count > 0)
            //    _modbusService.Stop();
            ////延迟原因传输带停止后再次拍照
            //_cameraService.SetManual();
            //_cameraService.SetAuto();
            ////拍照后上料位传输坐标由机械臂执行移动
            //await _robotService.SetHOMECmd();
            //await _robotService.ClearAllAlarmsState();
            ////await _robotService.PointMove((float)200,(float)-17,80);
            
            ////重新开始传送带
            //_modbusService.Start();
            ////internal async Task PointMove(float goalX, float goalY, float goalZ)
        }

        //public void ToPoint(Image image){
        //    // 将采集到的图形给到CTB
        //    CTB.Inputs["InputImage"].Value = image;

        //    // 开始执行CTB
        //    CTB.Run();
        //    // 获取到检测的结果
        //    int Count = (int)CTB.Outputs["Count"].Value;        
        //    if (Count > 0) // 检测到瓶盖
        //    {
        //        double x = (double)CTB.Outputs["X"].Value;
        //        double y = (double)CTB.Outputs["Y"].Value;
        //        Dictionary<string, float> Arms = new Dictionary<string, float>()
        //        {
        //            ["x"] = (float)x,
        //            ["y"] = (float)y
        //        };
        //        Console.WriteLine("检测的瓶盖坐标---");
        //        Console.WriteLine(Arms["x"]);
        //        Console.WriteLine(Arms["y"]);
        //        Console.WriteLine("检测的瓶盖坐标---");
        //        //需要将Arms传递给机械臂服务器
        //        // json转换(使用第三方库)
        //        string sendData = JsonConvert.SerializeObject(Arms);
        //        // 转成字节数组
        //        byte[] SendBytes = System.Text.Encoding.UTF8.GetBytes(sendData);
        //        // 发送数据
        //        Stream.Write(SendBytes, 0, SendBytes.Length);
        //    }
        //    else
        //    {
        //        // 没有检测到 继续启动传送带
        //        master.WriteSingleRegisterAsync(2, 100, (ushort)1);
        //    }
        //}
    }
}
