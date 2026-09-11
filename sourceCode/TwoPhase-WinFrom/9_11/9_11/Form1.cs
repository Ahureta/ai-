using _9_11.models;
using Modbus.Device;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.IO.Ports;

namespace _9_11
{
    public partial class Form1 : Form
    {
        private SerialPort? serialPort;     //串口对象
        //public SerialPort(string portName, int baudRate, System.IO.Ports.Parity parity, int dataBits, System.IO.Ports.StopBits stopBits
        private readonly string PortName = "COM1";
        private readonly int BaudRate = 9600;
        private readonly System.IO.Ports.Parity Parity = System.IO.Ports.Parity.None;
        private readonly int DataBits = 8;
        private readonly System.IO.Ports.StopBits StopBits = System.IO.Ports.StopBits.One;

        private IModbusSerialMaster? Master;
        //Task<ushort[]> ReadInputRegistersAsync(byte slaveAddress, ushort startAddress, ushort numberOfPoints);
        private ushort[]? Data;
        private readonly byte SlaveAddress = 1;
        private readonly ushort Offset = 0;
        private readonly ushort Count = 4;

        private readonly System.Windows.Forms.Timer GlobalTimer = new();

        private BindingList<DeviceTempRecord> DeviceTempRecordList = [];
        public Form1()
        {
            InitializeComponent();
            this.Shown += Form1_Shown;
        }

        private void Form1_Shown(object? sender, EventArgs e)
        {
            GlobalTimer.Interval = 500;
            GlobalTimer.Tick += GlobalTimer_Tick;

            RecordShow();
            dataRecordsTB.DataSource = DeviceTempRecordList;// new List<DeviceTempRecord>
            //{
            //    new DeviceTempRecord([0, 25, 25, 0])
            //};

            getConnectPLCBT.Click += GetLinkPLCBT_Click;
            lostConnectPLCBT.Click += LostConnectPLCBT_Click;
            deviceStartBT.Click += DeviceStartBT_Click;

            setTemperatureBT.Click += SetTemperatureBT_Click;
        }

        private void SetTemperatureBT_Click(object? sender, EventArgs e)
        {
            if (!IsConnect())
            {
                AntdUI.Message.error(this, "请先连接设备", autoClose: 3);
                return;
            }
            try
            {
                if (!ushort.TryParse(setTemperatureTB.Text, out ushort c))
                {
                    AntdUI.Message.error(this, "请输入设定温度", autoClose: 3);
                }
                Master.WriteSingleRegister(1, 1, c);

                logging($"设置目标温度={c}℃");
            }
            catch (Exception err)
            {
                MessageBox.Show($"设置目标温度异常" + err.Message);
            }
        }

        private void RecordShow()
        {
            dataRecordsTB.Columns.Clear();

            dataRecordsTB.Columns = new AntdUI.ColumnCollection {
                new AntdUI.Column("Id", "编号")
                {
                    Render = (object val,object cel,int index ) =>(index+1).ToString()
                },
                new AntdUI.Column("CollectTime", "采集时间"),
                new AntdUI.Column("DeviceStatus", "设备状态"),
                new AntdUI.Column("SetTemp", "设定温度"),
                new AntdUI.Column("RealTemp", "实际温度"),
                new AntdUI.Column("FaultCode", "故障码")
            };

            //数据为空时也显示表头
            dataRecordsTB.EmptyHeader = true;
            //强制刷新
            //dataRecordsTB.Invalidate();
        }

        private async void LostConnectPLCBT_Click(object? sender, EventArgs e)
        {
            try
            {
                // 1. 停止定时采集
                GlobalTimer.Stop();

                // 2. 尽力让设备停止运行，失败也不影响断开
                if (Master != null)
                {
                    try
                    {
                        await Master.WriteSingleRegisterAsync(SlaveAddress, 0, 0);
                    }
                    catch { }

                    Master.Dispose();
                    Master = null;
                }

                // 3. 关闭串口
                if (serialPort != null && serialPort.IsOpen)
                {
                    serialPort.Close();
                }
                serialPort?.Dispose();
                serialPort = null;

                // 4. 更新界面
                dataRecordsTB.Invalidate();
                //SetConnectUI(false);
                connectStatusLB.Text = "未连接";
                AntdUI.Message.success(this, "已断开 PLC", autoClose: 2);
            }
            catch (Exception ex)
            {
                AntdUI.Message.error(this, "断开异常：" + ex.Message, autoClose: 3);
            }
        }

        private async void GlobalTimer_Tick(object? sender, EventArgs e)
        {
            if (!IsConnect())
            {
                AntdUI.Message.error(this, "请先连接设备", autoClose: 3);
                return;
            }
            try
            {
                Data = await Master.ReadHoldingRegistersAsync(SlaveAddress, Offset, Count);
                if (Data == null)
                {
                    MessageBox.Show("读取异常");
                    return;
                }
                //AntdUI.Message.error(this, "数据"+ string.Join(",", Data), autoClose: 3);

                DeviceTempRecordList.Add(new DeviceTempRecord(Data));

                //AntdUI.Message.error(this, "列表"+string.Join(",", DeviceTempRecordList), autoClose: 3);
            }
            catch (Exception err)
            {
                MessageBox.Show("读取异常" + err.Message);
            }
        }

        private async void DeviceStartBT_Click(object? sender, EventArgs e)
        {
            if (!IsConnect())
            {
                AntdUI.Message.error(this, "请先连接设备", autoClose: 3);
                return;
            }
            try
            {
                Master.WriteSingleRegister(1, 0, 1);
                deviceStartBT.Enabled = false;

                GlobalTimer.Start();

                logging("设备置运行状态");
            }
            catch (Exception err)
            {
                MessageBox.Show("启动异常" + err.Message);
            }
        }

        [MemberNotNullWhen(true, nameof(serialPort))]
        [MemberNotNullWhen(true, nameof(Master))]
        private bool IsConnect()
        {
            if (serialPort == null || Master == null) return false;
            return true;
        }

        private void GetLinkPLCBT_Click(object? sender, EventArgs e)
        {
            if (IsConnect())
            {
                AntdUI.Message.error(this, "设备已连接", autoClose: 3);
                return;
            }
            try
            {
                serialPort = new SerialPort(PortName, BaudRate, Parity, DataBits, StopBits);
                serialPort.Open();

                Master = ModbusSerialMaster.CreateRtu(serialPort);
                Master.Transport.ReadTimeout = 2000;
                Master.Transport.Retries = 3;

                connectStatusLB.Text = "已连接";
                logging("连接设备成功，开始采集");

                DeviceSimulation();
            }
            catch (Exception err)
            {
                MessageBox.Show("连接异常" + err.Message);
            }
        }

        private async void DeviceSimulation()          //模拟设备
        {
            if (!IsConnect())
            {
                AntdUI.Message.error(this, "模拟设备异常", autoClose: 3);
                return;
            }

            ushort initialTemp = 30;
            ushort maxTemp = 80;     // 最高到 80℃
            ushort minTemp = 30;     // 最低回到 30℃
            ushort stepSize = 2;     // 每次变化 2℃

            var state = new SimState { CurrentTemp = initialTemp };

            var timer = new System.Windows.Forms.Timer
            {
                Interval = 200,
                Tag = state    // ← 把整个状态对象塞进 Tag
            };

            timer.Tick += async (object? sender, EventArgs e) =>
            {
                var t = (System.Windows.Forms.Timer)sender!;
                var s = (SimState)t.Tag!;   // ← 取出来

                if (s.IsRising)
                {
                    s.CurrentTemp += stepSize;
                    if (s.CurrentTemp >= maxTemp)
                    {
                        s.CurrentTemp = maxTemp;
                        s.IsRising = false;   // ← 到顶了，开始下降
                    }
                }
                else
                {
                    s.CurrentTemp -= stepSize;
                    if (s.CurrentTemp <= minTemp)
                    {
                        s.CurrentTemp = minTemp;
                        s.IsRising = true;    // ← 到底了，开始上升
                    }
                }

                s.Step++;
                t.Tag = s;   // 写回去

                // 写入 PLC 寄存器
                await Master.WriteSingleRegisterAsync(SlaveAddress, 2, s.CurrentTemp);
            };

            try
            {
                //初始状态                
                await Master.WriteSingleRegisterAsync(SlaveAddress, 0, 0);      // 状态停止
                await Master.WriteSingleRegisterAsync(SlaveAddress, 2, initialTemp); // 初始温度 30
                await Master.WriteSingleRegisterAsync(SlaveAddress, 3, 0);      // 故障码 0

                timer.Start();
            }
            catch (Exception err)
            {
                timer?.Stop();
                MessageBox.Show("模拟设备异常" + err.Message);
            }
        }

        private void logging(string logString)
        {

            AntdUI.Label label = new AntdUI.Label
            {
                Text = logString,
                AutoSize = true,          // 让 label 根据文本自动调整大小
                Location = new Point(10, loggingPN.Controls.Count * 30) // 手动定位，避免重叠
            };

            loggingPN.Controls.Add(label);
        }
    }
}
