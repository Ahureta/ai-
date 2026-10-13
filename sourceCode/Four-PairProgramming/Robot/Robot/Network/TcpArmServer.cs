using DobotArms.Services;
using Newtonsoft.Json.Linq;
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

        /*
 {
  "seq": 1,
  "cmd": "move",
  "code": 0,
  "status": "ok",
  "message": "执行完成",
  "data": {
    "x": 200.0,
    "y": -17.0,
    "z": 50.0,
    "currentPose": [ ... ]
  },
  "ts": "2026-10-13T19:22:12.123"
}

字段含义：
seq：回包对应哪条请求（客户端发 seq，服务端原样带回），多条指令并发时有用
cmd：当前这条响应对应的指令名
code：数字状态码，0=成功，非0=错误
status：人看的简写，ok / error
message：描述，成功可写空或"done"，失败写原因
data：业务数据，没有就返回 {}，别返回 null
ts：服务端时间戳，排错用
 */

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
            /*
                connect
                SetHOMECmd
                ClearAllAlarmsState
                PickAndPlace
                Disconnect
             */
            try
            {
                var json = JObject.Parse(message);
                string? cmd = json["cmd"]?.ToString();                
                
                var paramsObj = json["params"] as JObject;
                if (paramsObj == null)
                {
                    paramsObj = new JObject();   // 无参命令统一变成空对象
                }

                switch (cmd)
                {
                    case "connect":
                        return _armService.Connect();                                                
                    case "SetHOMECmd":
                        return _armService.SetHOMECmd();                        
                    case "ClearAllAlarmsState":
                        return _armService.ClearAllAlarmsState();                        
                    case "PickAndPlace":
                        return GetArmPosition(paramsObj);                        
                    case "Disconnect":
                        _armService.Disconnect();
                        return "断开成功";
                    default:
                        return "空参数";
                }
                //return "操作成功";
            }
            catch(Exception err)
            {
                Console.WriteLine("异常" + err);
            }

            return string.Empty;  // 无响应
        }

        private string GetArmPosition(JObject paramsObj)
        {
            // 坐标指令（JSON）
            try
            {
                // 必要参数存在性检查
                if (!paramsObj.TryGetValue("X", out JToken? xToken) ||
                    !paramsObj.TryGetValue("Y", out JToken? yToken) ||
                    !paramsObj.TryGetValue("Z", out JToken? zToken))
                {
                    Console.WriteLine("缺少坐标参数");
                    return string.Empty;
                }

                // 安全地把 JToken 转为 float（会在解析失败时抛异常，catch 中处理）
                float x = xToken!.ToObject<float>();
                float y = yToken!.ToObject<float>();
                float z = zToken!.ToObject<float>();
                float rHead = paramsObj.TryGetValue("RHead", out JToken? rToken) && rToken != null
                    ? rToken.ToObject<float>()
                    : 0f;

                var pos = new ArmPosition(x, y, z, rHead);

                // 简单判断有效坐标
                if (pos.X != 0)
                {
                    return _armService.PickAndPlace(pos);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("JSON 解析失败: " + ex.Message);
            }

            return string.Empty;  // 无响应
        }
    }
}