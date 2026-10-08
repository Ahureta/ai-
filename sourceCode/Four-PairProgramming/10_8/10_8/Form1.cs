using Cognex.VisionPro;
using Cognex.VisionPro.FGGigE;
using Cognex.VisionPro.FGGigE.Implementation.Internal;
using Cognex.VisionPro.ImageFile;
using Cognex.VisionPro.Implementation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Windows.Forms.Form;

namespace _10_8
{
    public partial class Form1 : Form
    {
        private ICogAcqFifo cogAcqFifo { get; set; }

        public Form1()
        {
            InitializeComponent();
            //CogRecord
            //CogRecordDisplay rd = new CogRecordDisplay();
            //rd.Dock = DockStyle.Fill;
            //panel1.Controls.Add(rd);

            this.Shown += Form1_Shown;
            this.FormClosed += Form1_FormClosed;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //CogFrameGrabbers cogFrameGrabbers = new CogFrameGrabbers();
            CogFrameGrabberGigEs cogFrameGrabberGigEs = new CogFrameGrabberGigEs();
            ICogFrameGrabber cogFrameGrabber = cogFrameGrabberGigEs[0];
            Console.WriteLine("获取的相机名："+cogFrameGrabber.Name);
            // 使用 AvailableVideoFormats 获取第一个视频格式
            string videoFormat = cogFrameGrabber.AvailableVideoFormats[0];

            cogAcqFifo = cogFrameGrabber.CreateAcqFifo(
                videoFormat,
                CogAcqFifoPixelFormatConstants.Format8Grey,
                0,
                true
            );

            cogAcqFifo.OwnedExposureParams.Exposure = 400.0; // 曝光率是浮点类型
            cogAcqFifo.OwnedGigEVisionTransportParams.LatencyLevel = 1;
            cogAcqFifo.OwnedExposureParams.Exposure = 20;

            cogAcqFifo.Complete += cogAcqFifo_Complete;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 让相机拍照的方法
            Console.WriteLine("开始拍摄");
            cogRecordDisplay1.StartLiveDisplay(cogAcqFifo);
            //cogAcqFifo.StartAcquire();
        }

        private void cogAcqFifo_Complete(object sender, CogCompleteEventArgs e)
        {
            ICogAcqFifo cogAcqFifo = (ICogAcqFifo)sender;
            cogAcqFifo.GetFifoState(out int numppending,out int numRead,out bool busy);
            if (numRead > 0)
            {
                ICogImage cogImage = cogAcqFifo.CompleteAcquireEx(new CogAcqInfo());
            }
            else {
                Console.WriteLine("拍摄失败");
            }

            //CogImageFileTool cogImageFileTool = new CogImageFileTool();
            //cogImageFileTool.Operator.Open(ofd);

            cogRecordDisplay1.StartLiveDisplay(cogAcqFifo); // false表示是否连续采集
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cogRecordDisplay1.StopLiveDisplay();
        }
    }
}
