using DobotClientDemo.CPlusDll;
using Robot.Models;
using System;
using System.Text;
using System.Threading;

namespace DobotArms.Services
{
    /// <summary>
    /// 机械臂服务层 —— 只管机械臂SDK调用，不碰网络
    /// </summary>
    public class DobotArmService
    {
        private bool _isConnected = false;

        /// <summary>
        /// 连接机械臂
        /// </summary>
        public string Connect(string port = "COM8", int baudRate = 115200)
        {
            if (_isConnected)
                return "already_connected";

            StringBuilder fwType = new StringBuilder(128);
            StringBuilder version = new StringBuilder(128);

            int ret = DobotDll.ConnectDobot(port, baudRate, fwType, version);
            if (ret == 0)
            {
                _isConnected = true;
                Console.WriteLine($"连接成功！固件:{fwType} 版本:{version}");
                return "connected";
            }
            else
            {
                Console.WriteLine($"连接失败，返回码:{ret}");
                return "connect_failed";
            }
        }

        /// <summary>
        /// 取料→放料 完整流程
        /// </summary>
        public string PickAndPlace(ArmPosition pickPos)
        {
            if (!_isConnected)
                return "not_connected";

            try
            {
                // 1. 取料位上方
                MoveTo(pickPos.X, pickPos.Y, 80, 0, 1);

                // 2. 下降到取料位
                MoveTo(pickPos.X, pickPos.Y, -18, 0, 2);

                // 3. 开启吸盘
                UInt64 idx3 = 3;
                DobotDll.SetEndEffectorSuctionCup(true, true, true, ref idx3);

                // 4. 抬起到取料位上方
                MoveTo(pickPos.X, pickPos.Y, 80, 0, 4);

                // 5. 移动到下料位上方
                MoveTo(8, 218, 80, 0, 5);

                // 6. 释放吸盘
                UInt64 idx6 = 6;
                DobotDll.SetEndEffectorSuctionCup(true, false, true, ref idx6);

                // 7. 启动队列执行
                int ret = DobotDll.SetQueuedCmdStartExec();
                if (ret != 0)
                    return "queue_start_failed";

                Console.WriteLine("队列开始执行，等待机械臂完成...");
                Thread.Sleep(7000);

                // 8. 清空并停止队列
                DobotDll.SetQueuedCmdClear();
                DobotDll.SetQueuedCmdStopExec();

                Console.WriteLine("动作完成，队列已清空");
                return "moveEnd";
            }
            catch (Exception ex)
            {
                Console.WriteLine($"运动异常: {ex.Message}");
                return "move_error";
            }
        }

        /// <summary>
        /// 断开连接
        /// </summary>
        public void Disconnect()
        {
            if (_isConnected)
            {
                try { DobotDll.DisconnectDobot(); } catch { }
                _isConnected = false;
                Console.WriteLine("机械臂已断开");
            }
        }

        public bool IsConnected => _isConnected;

        // ---- 私有辅助 ----
        private void MoveTo(float x, float y, float z, float r, UInt64 cmdIndex)
        {
            PTPCmd cmd = new PTPCmd();
            cmd.ptpMode = 1;  // MoveJ
            cmd.x = x;
            cmd.y = y;
            cmd.z = z;
            cmd.rHead = r;
            DobotDll.SetPTPCmd(ref cmd, true, ref cmdIndex);
        }
    }
}