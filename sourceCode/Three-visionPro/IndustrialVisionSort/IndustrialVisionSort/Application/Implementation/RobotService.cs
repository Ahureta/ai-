using IndustrialVisionSort.DoMain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndustrialVisionSort.Application.Implementation
{
    internal class RobotService
    {
        private ArmTcpClient _armTcpClient = new ArmTcpClient();

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
    }
}
