using DobotArms.Services;
using Robot.Models;
using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;

namespace DobotArms.Network
{
    /// <summary>
    /// TCP 通信层 —— 只管网络收发和消息分发，不碰机械臂逻辑
    /// </summary>
    public class TcpArmServer
    {
        private readonly DobotArmService _armService;
        private TcpListener _listener;
        private bool _running = false;

        public TcpArmServer(DobotArmService armService)
        {
            _armService = armService;
        }

        /// <summary>
        /// 启动服务（阻塞，直到 Stop 被调用）
        /// </summary>
        public void Start(string ip, int port)
        {
            _listener = new TcpListener(IPAddress.Any, port);
            _listener.Start();
            _running = true;

            Console.WriteLine($"机械臂服务端启动 [{ip}:{port}]，等待客户端连接...");

            while (_running)
            {
                try
                {
                    TcpClient client = _listener.AcceptTcpClient();
                    Console.WriteLine("客户端已连接");
                    HandleClient(client);
                    client.Close();
                    Console.WriteLine("客户端已断开");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"监听异常: {ex.Message}");
                }
            }
        }

        /// <summary>
        /// 停止服务
        /// </summary>
        public void Stop()
        {
            _running = false;
            _listener?.Stop();
        }

        // ---- 私有：处理单个客户端 ----
        private void HandleClient(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            byte[] buffer = new byte[1024];

            while (true)
            {
                int len;
                try
                {
                    len = stream.Read(buffer, 0, buffer.Length);
                }
                catch
                {
                    break;
                }

                if (len == 0) break;

                string receivedData = Encoding.UTF8.GetString(buffer, 0, len);
                Console.WriteLine($"收到: {receivedData}");

                string response = DispatchMessage(receivedData, stream);
                if (!string.IsNullOrEmpty(response))
                {
                    byte[] sendData = Encoding.UTF8.GetBytes(response);
                    stream.Write(sendData, 0, sendData.Length);
                }
            }
        }

        // ---- 私有：消息分发 ----
        private string DispatchMessage(string message, NetworkStream stream)
        {
            // 连接指令
            if (message == "connect")
            {
                return _armService.Connect();
            }

            // 坐标指令（JSON）
            try
            {
                ArmPosition pos = JsonSerializer.Deserialize<ArmPosition>(message);
                if (pos != null && pos.X != 0)  // 简单判断有效坐标
                {
                    return _armService.PickAndPlace(pos);
                }
            }
            catch
            {
                Console.WriteLine("JSON 解析失败");
            }

            return string.Empty;  // 无响应
        }
    }
}