using Modbus.Device;
using System.IO.Ports;

namespace _9_10
{
    public partial class Form1 : Form
    {
        private int ToConnctID = 1;
        private SerialPort? serialPort;
        private IModbusMaster? master;
        public Form1()
        {
            InitializeComponent();
            this.Shown += Form1_Shown;
        }

        private void Form1_Shown(object? sender, EventArgs e)
        {
            getLinkBT.Click += GetLinkBT_Click;
            writeBT.Click += WriteBT_Click;
            readBT.Click += ReadBT_Click;
        }

        private void ReadBT_Click(object? sender, EventArgs e)
        {
            if (master == null)
            {
                AntdUI.Message.error(this, "请先连接", autoClose: 3);
                return;
            }
            ushort[]? registers = master?.ReadHoldingRegisters(
                slaveAddress: 1, // 从站地址1-247
                startAddress: 0, // 开始地址
                numberOfPoints: 5 // 读取数量
            );
            MessageBox.Show(string.Join(", ", registers));
        }

        private void WriteBT_Click(object? sender, EventArgs e)
        {
            if (writeRowIDTB.Value > 65535)
            {
                AntdUI.Message.error(this, "port不合法", autoClose: 3);
                return;
            }
            if (writeTB.Value > 65535)
            {
                AntdUI.Message.error(this, "内容不合法", autoClose: 3);
                return;
            }
            if (master == null)
            {
                AntdUI.Message.error(this, "请先连接", autoClose: 3);
                return;
            }
            master?.WriteSingleRegisterAsync((byte)ToConnctID, (ushort)writeRowIDTB.Value, (ushort)writeTB.Value);
        }

        private void GetLinkBT_Click(object? sender, EventArgs e)
        {
            try
            {
                serialPort = new("COM1", 9600, Parity.None, 8, StopBits.One);
                serialPort.Open();
                master = ModbusSerialMaster.CreateRtu(serialPort);
                AntdUI.Message.success(this, "连接成功", autoClose: 3);
            }
            catch (Exception err)
            {
                MessageBox.Show("连接失败:" + err.Message);
            }
        }
    }
}
