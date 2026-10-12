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
        public UcRobotDeviceDebug()
        {
            InitializeComponent();
            InitAttribute();
        }

        public void InitAttribute() {
            _robotServicel = new RobotService();
            //RobotServicel = new RobotService(
            //    IPIP.Text,
            //    IPPort.Text
            //);
        }
        private async Task BTConnectRobot_Click(object sender, EventArgs e)
        {
            await _robotServicel.ConnectRobot();
        }

        private void BTPointMove_Click(object sender, EventArgs e)
        {
            float GoalX = float.Parse(IPXGoal.Text);
            float GoalY = float.Parse(IPYGoal.Text);
            float GoalZ = float.Parse(IPZGoal.Text);
            _robotServicel.PointMove(GoalX,GoalY,GoalZ);
        }

        private void BTLostRobot_Click(object sender, EventArgs e)
        {
            _robotServicel.LostRobot();
        }

        private void BTZero_Click(object sender, EventArgs e)
        {

        }

        private void BTClearErr_Click(object sender, EventArgs e)
        {

        }

        private void BTClearQueue_Click(object sender, EventArgs e)
        {

        }
    }
}
