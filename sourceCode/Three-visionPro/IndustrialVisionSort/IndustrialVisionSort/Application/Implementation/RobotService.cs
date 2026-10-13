using IndustrialVisionSort.DoMain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialVisionSort.Application.Implementation
{
    /*
     // UI/业务层只入队
    _cmdQueue.Enqueue(new ArmCommand(ArmCmdType.MoveL, x,y,z,r));

    // 消费者线程：等机械臂空闲再发下一条
    while (_cmdQueue.TryDequeue(out cmd))
    {
        SendToArm(cmd);
        WaitUntilQueueIndexReached(cmd.Index);
    }
     */

    internal class RobotService
    {
        public event EventHandler<string> LogMessage;
        private ArmTcpClient _armTcpClient = new ArmTcpClient();

        public RobotService(){
            //_armTcpClient.LogMessage += (sender,message) => LogMessage.Invoke(sender,message);
        }
        internal async Task ConnectRobot(string ip = "127.0.0.1", int port = 8989 )
        {
            await _armTcpClient.ConnectAsync(ip,port);
        }

        internal void LostRobot()
        {
            _armTcpClient.Disconnect();
        }

        internal async Task PointMove(float goalX, float goalY, float goalZ)
        {
            await _armTcpClient.SendPositionAsync(new ArmPosition(goalX,goalY,goalZ));
        }

        internal async Task SetHOMECmd()
        {
            await _armTcpClient.SetHOMECmd();
        }

        internal async Task ClearAllAlarmsState()
        {
            await _armTcpClient.ClearAllAlarmsState();
        }
    }
}
