using DobotArms.Network;
using DobotArms.Services;

namespace Robot
{
    internal class Program
    {
        /*
         立即指令：下位机收到马上执行
        队列指令：收到后进下位机队列，串行执行
        运动类指令（PTP/MovJ/MovL）都是队列指令
        下发时立刻返回「已入队」，但机械臂还没动
        要调 SetQueuedCmdStartExec 才真正开始跑队列
         */

        static void Main(string[] args)
        {
            // 1. 创建服务实例
            DobotArmService armService = new DobotArmService();
            TcpArmServer server = new TcpArmServer(armService);

            // 2. 注册退出处理
            Console.CancelKeyPress += (s, e) =>
            {
                e.Cancel = true;
                Console.WriteLine("正在关闭...");
                server.Stop();
                armService.Disconnect();
            };

            // 3. 启动（阻塞）
            server.Start("127.0.0.1", 8989);

            // 4. 退出时清理
            armService.Disconnect();
            Console.WriteLine("服务已停止");
        }
    }
}
