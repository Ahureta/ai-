using IndustrialVisionSort.Application.Implementation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndustrialVisionSort.ui.Controls.UC.ContolSetting
{
    public partial class UcRobotDeviceDebug : UserControl
    {
        private RobotService _robotServicel;
        internal UcRobotDeviceDebug(RobotService robotService)
        {
            InitializeComponent();
            InitAttribute(robotService);
        }

        internal void InitAttribute(RobotService robotService) {
            _robotServicel = robotService;
            //RobotServicel = new RobotService(
            //    IPIP.Text,
            //    IPPort.Text
            //);
        }
        private async void BTConnectRobot_Click(object sender, EventArgs e)
        {
            await _robotServicel.ConnectRobot();
            AntdUI.Message.info(new AntdUI.Target(this), "正在连接", autoClose: 2);
        }
        //private async Task BTConnectRobot_Click(object sender, EventArgs e)
        //{
        //    await _robotServicel.ConnectRobot();
        //    AntdUI.Message.info(new AntdUI.Target(this),"正在连接", autoClose: 2);
        //}

        private async void BTPointMove_Click(object sender, EventArgs e)
        {
            float GoalX = float.Parse(IPXGoal.Text);
            float GoalY = float.Parse(IPYGoal.Text);
            float GoalZ = float.Parse(IPZGoal.Text);
            await _robotServicel.PointMove(GoalX,GoalY,GoalZ);
        }

        private void BTLostRobot_Click(object sender, EventArgs e)
        {
            _robotServicel.LostRobot();
        }

        private async void BTSetHOMECmd_Click(object sender, EventArgs e)
        {
            await _robotServicel.SetHOMECmd();
        }

        private async void BTClearAllAlarmsState_Click(object sender, EventArgs e)
        {
            await _robotServicel.ClearAllAlarmsState();
        }
    }
}
