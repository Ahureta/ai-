using DobotArms.Network;
using DobotArms.Services;

namespace Robot
{
    internal class Program
    {
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
