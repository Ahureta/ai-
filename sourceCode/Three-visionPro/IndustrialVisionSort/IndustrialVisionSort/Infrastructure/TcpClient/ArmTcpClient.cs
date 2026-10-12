using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using IndustrialVisionSort.DoMain.Entities;
using IndustrialVisionSort.DoMain.Events;
using Newtonsoft.Json;

namespace IndustrialVisionSort.Application
{
    /// <summary>
    /// 机械臂 TCP 客户端 —— 只管通信，不碰视觉/相机
    /// </summary>
    public class ArmTcpClient
    {
        private TcpClient _client;
        private NetworkStream _stream;
        private bool _running = false;

        // 事件（UI 订阅）
        public event EventHandler<ArmStateChangedEventArgs> StateChanged;
        public event EventHandler<string> LogMessage;

        public bool IsConnected => _client != null && _client.Connected;

        /// <summary>
        /// 连接机械臂服务端
        /// </summary>
        public async Task ConnectAsync(string ip, int port)
        {
            if (IsConnected) return;

            _client = new TcpClient();
            await _client.ConnectAsync(ip, port);
            _stream = _client.GetStream();

            // 发送连接指令
            byte[] sendBytes = Encoding.UTF8.GetBytes("connect");
            await _stream.WriteAsync(sendBytes, 0, sendBytes.Length);

            LogMessage?.Invoke(this, "机械臂连接请求已发送");

            // 启动后台接收
            _running = true;
            _ = Task.Run(new Action(ReadLoop));
        }

        /// <summary>
        /// 发送坐标让机械臂运动
        /// </summary>
        public async Task SendPositionAsync(ArmPosition pos)
        {
            if (!IsConnected) throw new InvalidOperationException("机械臂未连接");

            string json = JsonConvert.SerializeObject(new
            {
                x = pos.X,
                y = pos.Y
            });

            byte[] sendBytes = Encoding.UTF8.GetBytes(json);
            await _stream.WriteAsync(sendBytes, 0, sendBytes.Length);
            LogMessage?.Invoke(this, $"已发送坐标: X={pos.X}, Y={pos.Y}");
        }

        /// <summary>
        /// 发送测试坐标
        /// </summary>
        public async Task SendTestPositionAsync()
        {
            var testPos = new ArmPosition(280, -25);
            await SendPositionAsync(testPos);
        }

        /// <summary>
        /// 断开连接
        /// </summary>
        public void Disconnect()
        {
            _running = false;
            _stream?.Close();
            _client?.Close();
            StateChanged?.Invoke(this, new ArmStateChangedEventArgs { State = "disconnected" });
            LogMessage?.Invoke(this, "机械臂已断开");
        }

        // ---- 私有：接收循环 ----
        private void ReadLoop()
        {
            byte[] buffer = new byte[1024];
            while (_running && IsConnected)
            {
                int len;
                try
                {
                    len = _stream.Read(buffer, 0, buffer.Length);
                }
                catch
                {
                    break;
                }

                if (len == 0) break;

                string msg = Encoding.UTF8.GetString(buffer, 0, len);
                LogMessage?.Invoke(this, $"收到: {msg}");

                StateChanged?.Invoke(this, new ArmStateChangedEventArgs { State = msg.Trim() });
            }
        }
    }
}