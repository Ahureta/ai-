using AntdUI;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace _9_9
{
    public partial class Server : Form
    {
        private string IP = "127.0.0.1";
        private IPAddress? IPAddr;

        private TcpListener? _tcpListener;
        private TcpClient? _tcpClient;
        private NetworkStream? _stream;
        private CancellationTokenSource _cts = new();

        public Server()
        {
            InitializeComponent();
            this.Shown += Form1_Shown;
        }

        private void Form1_Shown(object? sender, EventArgs e)
        {
            new Client().Show();
            inputNumber1.Value = 8848;
            IPAddr = IPAddress.Parse(IP);


            getLinkBT.Click += getLinkBT_Click;
            sendDataBT.Click += SendDataBT_Click;
        }

        private void SendDataBT_Click(object? sender, EventArgs e)
        {            

            if (_tcpListener == null)
            {
                AntdUI.Message.info(this, "请先启动服务", autoClose: 3);
                return;
            }
            if (_stream == null)
            {
                AntdUI.Message.info(this, "无连接", autoClose: 3);
                return;
            }
            string message = input2.Text;            
            byte[] SendData = Encoding.UTF8.GetBytes(message);
            _stream.Write(SendData, 0, SendData.Length);
            AntdUI.Message.info(this, "已发送消息", autoClose: 3);
        }

        private async void getLinkBT_Click(object? sender, EventArgs e)
        {
            if (_tcpListener != null)
            {
                AntdUI.Message.info(this, "服务已启动", autoClose: 3);
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
                if (IPAddr == null) { AntdUI.Message.warn(this, "IP 地址未初始化", autoClose:2); return; }
                _tcpListener = new TcpListener(IPAddr, port);
                _tcpListener.Start();

                //// 同步阻塞代码等客户端连接
                //_tcpClient = _tcpListener.AcceptTcpClient();

                // 异步阻塞代码等客户端连接
                AntdUI.Message.info(this, "等待客户端连接...", autoClose: 2);
                _tcpClient = await _tcpListener.AcceptTcpClientAsync();
                _stream = _tcpClient.GetStream();

                string clientIp = _tcpClient?.Client?.RemoteEndPoint?.ToString() ?? "unknown";
                AntdUI.Message.info(this, $"客户端 {clientIp} 已连接", autoClose: 2);


                while (true)
                {
                    int len = await _stream.ReadAsync(bytes, 0, bytes.Length);
                    string ReviceData = System.Text.Encoding.UTF8.GetString(bytes, 0, len);


                    AntdUI.Label label = new AntdUI.Label
                    {
                        Text = ReviceData,
                        AutoSize = true,          // 让 label 根据文本自动调整大小
                        Location = new Point(10, panel1.Controls.Count * 30) // 手动定位，避免重叠
                    };                    
                    panel1.Controls.Add(label);
                }

                #region    //生产/作业推荐用异步多连接模式
                /*
                 private async void StartServer_Click(object sender, EventArgs e)
                {
                    _tcpListener = new TcpListener(IPAddress.Loopback, port);
                    _tcpListener.Start();

                    // 不断接受新连接，每个连接开一个 Task 处理
                    while (true)
                    {
                        var client = await _tcpListener.AcceptTcpClientAsync();

                        // 不等待处理结束，立即继续 accept
                        _ = HandleClientAsync(client);
                    }
                }

                private async Task HandleClientAsync(TcpClient client)
                {
                    using (client)
                    using (var stream = client.GetStream())
                    {
                        byte[] buffer = new byte[1024];
                        while (true)
                        {
                            int len = await stream.ReadAsync(buffer, 0, buffer.Length);
                            if (len == 0) break; // 客户端断开

                            string msg = Encoding.UTF8.GetString(buffer, 0, len);

                            // 这里更新 UI（如果有跨线程需求）
                            this.Invoke(() =>
                            {
                                panel1.Controls.Add(new AntdUI.Label { Text = msg, AutoSize = true });
                            });
                        }
                    }
                    // client 和 stream 在 using 里自动关闭
                }
                 */

                #endregion
            
            }
            catch (Exception)
            {
                MessageBox.Show("服务启动失败");
                return;
            }
            finally
            {
                // 清理
                _stream?.Close();
                _tcpClient?.Close();
                _tcpListener?.Stop();
            }
        }
    }
}
