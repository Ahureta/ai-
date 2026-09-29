using _9_29.CPlusDll;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_29
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Shown += Form1_Shown;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {}

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder fwType = new StringBuilder(128);
            StringBuilder version = new StringBuilder(128);
            int ret = DobotDll.ConnectDobot("DOM3", 115200, fwType, version);

            MessageBox.Show($"ConnectDobot 返回码：{ret}\n固件：{fwType}\n版本：{version}");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DobotDll.DisconnectDobot();
            MessageBox.Show("串口已断开");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HOMECmd homeCmd = new HOMECmd();
            UInt64 cmdIndex = 0;
            int ret = DobotDll.SetHOMECmd(ref homeCmd, false, ref cmdIndex);
            
            if (ret == 0)
            {
                MessageBox.Show("回零指令下发成功，请观察机械臂运动");
            }
            else {
                MessageBox.Show($"回零调用失败，返回码{ret}");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PTPCmd ptpCmd = new PTPCmd();
            ptpCmd.ptpMode = 0;
            ptpCmd.x = 200;
            ptpCmd.y = 0;
            ptpCmd.z = 80;
            ptpCmd.rHead = 0;
            UInt64 cmdIndex = 0;
            int ret = DobotDll.SetPTPCmd(ref ptpCmd, false, ref cmdIndex);
            if (ret == 0)
            {
                MessageBox.Show("移动指令下发成功");
            }
            else
            {
                MessageBox.Show($"移动失败，返回码:{ret}");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Pose pose = new Pose();
            int ret = DobotDll.GetPose(ref pose);
            if (ret == 0) {
                string info = $"X:{pose.x:F2}\nY:{pose.y:F2}\nZ:{pose.z:F2}\nrHead:{pose.rHead:F2}";
                label1.Text = info.ToString();
            }
        }


        /*
         参数1：布尔值，enableCtrl，表示是否启用吸盘控制，true开启，false不再管吸盘

        参数2：布尔值，suck，是否开启吸真空，treu表示开启，false表示放真空

        参数3：布尔值，isQueued，表示命令是否放入队列，true放入队列等待执行，false立即执行
         */
        private void button6_Click(object sender, EventArgs e)
        {
            UInt64 cmdIndex = 0;
            int ret = DobotDll.SetEndEffectorSuctionCup(true, true, false, ref cmdIndex);
            if (ret == 0)
            {
                MessageBox.Show("吸盘吸气开启");
            }
            else
            {
                MessageBox.Show($"吸盘控制失败，返回码:{ret}");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            UInt64 cmdIndex = 0;
            int ret = DobotDll.SetEndEffectorSuctionCup(true, false, false, ref cmdIndex);
            if (ret == 0)
            {
                MessageBox.Show("吸盘防空开启");
            }
            else
            {
                MessageBox.Show($"吸盘控制失败，返回码:{ret}");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int ret = DobotDll.SetQueuedCmdStopExec();
            MessageBox.Show($"停止队列引擎，返回值:{ret}");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int ret = DobotDll.SetQueuedCmdClear();
            if (ret == 0)
            {
                MessageBox.Show("队列已清空");
            }
            else
            {
                MessageBox.Show($"清空队列失败，返回码:{ret}");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //A
            PTPCmd ptpA = new PTPCmd();
            ptpA.ptpMode = 0;
            ptpA.x = 200;
            ptpA.y = -40;
            ptpA.z = 50;
            ptpA.rHead = 0;

            //B
            PTPCmd ptpB = new PTPCmd();
            ptpB.ptpMode = 0;
            ptpB.x = 200;
            ptpB.y = -40;
            ptpB.z = 80;
            ptpB.rHead = 0;

            //C
            PTPCmd ptpC = new PTPCmd();
            ptpC.ptpMode = 0;
            ptpC.x = 200;
            ptpC.y = -20;
            ptpC.z = 80;
            ptpC.rHead = 0;

            //D
            PTPCmd ptpD = new PTPCmd();
            ptpD.ptpMode = 0;
            ptpD.x = 200;
            ptpD.y = -20;
            ptpD.z = 50;
            ptpD.rHead = 0;

            UInt64 cmdIndex = 0;
            int ret;

            ret = DobotDll.SetPTPCmd(ref ptpA, true, ref cmdIndex);
            ret = DobotDll.SetPTPCmd(ref ptpB, true, ref cmdIndex);
            ret = DobotDll.SetPTPCmd(ref ptpC, true, ref cmdIndex);
            ret = DobotDll.SetPTPCmd(ref ptpD, true, ref cmdIndex);

            /*
             // 1.运动到A点
            ret = DobotDll.SetPTPCmd(ref ptpA, true, ref cmdIndex);
            MessageBox.Show($"1.运动到A点入队，索引:{cmdIndex} ret:{ret}");

            // 2.到达A点，打开吸盘
            ret = DobotDll.SetEndEffectorSuctionCup(true, true, true, ref cmdIndex);
            MessageBox.Show($"2.打开吸盘入队，索引:{cmdIndex} ret:{ret}");

            //【暂时注释WAITCmd延时，结构体字段名版本不一致，后续再查】
            //WAITCmd waitCmd = new WAITCmd();
            //waitCmd.xxx = 500;
            //ret = DobotDll.SetWAITCmd(ref waitCmd, true, ref cmdIndex);
            //MessageBox.Show($"3.延时500ms入队，索引:{cmdIndex} ret:{ret}");

            // 4.上升到B点
            ret = DobotDll.SetPTPCmd(ref ptpB, true, ref cmdIndex);
            MessageBox.Show($"4.上升到B点入队，索引:{cmdIndex} ret:{ret}");

            // 5.移动到C点
            ret = DobotDll.SetPTPCmd(ref ptpC, true, ref cmdIndex);
            MessageBox.Show($"5.移动到C点入队，索引:{cmdIndex} ret:{ret}");

            // 6.下降到D点
            ret = DobotDll.SetPTPCmd(ref ptpD, true, ref cmdIndex);
            MessageBox.Show($"6.下降到D点入队，索引:{cmdIndex} ret:{ret}");

            // 7.到达D点，关闭吸盘松开物料
            ret = DobotDll.SetEndEffectorSuctionCup(true, false, true, ref cmdIndex);
            MessageBox.Show($"7.关闭吸盘入队，索引:{cmdIndex} ret:{ret}");

            MessageBox.Show("整套A‑B‑C‑D抓取放置流程全部入队完毕！");
             */
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int ret = DobotDll.SetQueuedCmdStartExec();
            if (ret == 0)
            {
                MessageBox.Show("队列开始执行，机械臂自动跑点位");
            }
            else
            {
                MessageBox.Show($"启动队列失败，返回码:{ret}");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int ret = DobotDll.ClearAllAlarmsState();
            if (ret == 0)
            {
                MessageBox.Show("清除所有报警成功，观察指示灯变回绿色");
            }
            else
            {
                MessageBox.Show($"清除报警失败，返回码:{ret}");
            }
        }
    }
}
