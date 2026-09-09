using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;

namespace _9_9
{
    public partial class Client : Form
    {
        private string IP = "127.0.0.1";
        private IPAddress? IPAddr;
        
        private TcpClient _tcpClient;
        private NetworkStream _stream;
        private CancellationTokenSource _cts = new();

        public Client()
        {
            InitializeComponent();
            this.Shown += Form1_Shown;
        }

        private void Form1_Shown(object? sender, EventArgs e)
        {
            inputNumber1.Value = 8848;

            if (getLinkBT != null)
                getLinkBT.Click += getLinkBT_Click;
            if (sendDataBT != null)
                sendDataBT.Click += SendDataBT_Click;
        }

        private void SendDataBT_Click(object? sender, EventArgs e)
        {
            if (_stream == null)
            {
                AntdUI.Message.info(this, "无连接");
                return;
            }

            string message = input2?.Text ?? string.Empty;
            byte[] SendData = Encoding.UTF8.GetBytes(message);
            _stream.Write(SendData, 0, SendData.Length);
            AntdUI.Message.info(this, "已发送消息", autoClose: 3);
        }

        private async void getLinkBT_Click(object? sender, EventArgs e)
        {
            if (_stream != null)
            {
                AntdUI.Message.info(this, "已有连接", autoClose: 3);
                return;
            }

            IP = input1?.Text ?? IP;

            if (!IPAddress.TryParse(IP, out IPAddr))
            {
                AntdUI.Message.info(this, "IP不合法", autoClose: 3);
                return;
            }

            int port = (int)inputNumber1.Value;
            if (port <= 0 || port > 65535)
            {
                AntdUI.Message.warn(this, "端口必须是 1~65535", autoClose: 2);
                return;
            }

            byte[] bytes = new byte[1024];

            try
            {
                _tcpClient = new TcpClient();
                AntdUI.Message.info(this, "正在连接中...", autoClose: 2);
                await _tcpClient.ConnectAsync(IPAddr!, port);

                _stream = _tcpClient.GetStream();

                AntdUI.Message.info(this, $"服务端 {IP} 已连接", autoClose: 2);

                while (true)
                {
                    int len = await _stream.ReadAsync(bytes, 0, bytes.Length);
                    if (len == 0) break;

                    string ReviceData = Encoding.UTF8.GetString(bytes, 0, len);

                    AntdUI.Label label = new AntdUI.Label
                    {
                        Text = ReviceData,
                        AutoSize = true,          // 让 label 根据文本自动调整大小
                        Location = new Point(10, panel1.Controls.Count * 30) // 手动定位，避免重叠
                    };

                    panel1?.Controls.Add(label);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("服务器连接失败");
                return;
            }
            finally
            {
                _stream?.Close();
                _tcpClient?.Close();
            }
        }
    }
}