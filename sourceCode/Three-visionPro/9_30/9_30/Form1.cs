using Cognex.VisionPro;
using Cognex.VisionPro.ImageProcessing;
using Cognex.VisionPro.PMAlign;
using Cognex.VisionPro.ToolBlock;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_30
{
    public partial class Form1 : Form
    {
        //BlockTool
        private CogToolBlock CTB { get; set; }
        private CogFrameGrabbers grabbers;
        private ICogAcqFifo acq;

        private bool _closing = false;
        public Form1()
        {
            InitializeComponent();
            this.Shown += Form1_Shown1;
            this.FormClosing += Form1_FormClosing1; ;
        }

        // 窗体显示的时候加载vpp文件
        private void Form1_Shown1(object sender, EventArgs e)
        {
            // 拼接路径
            string VppPath = Path.Combine(Directory.GetCurrentDirectory(), "vpps", "九点标定后的硬币结果集.vpp");
            // 加载vpp
            object CS = CogSerializer.LoadObjectFromFile(VppPath);
            // 将object转成toolBlock
            CTB = CS as CogToolBlock;
            // 给CTB传入图像，得出结果
        }

        private void Form1_FormClosing1(object sender, FormClosingEventArgs e)
        {
            try
            {
                _closing = true;

                // 1) 停连续采集
                if (acq != null)
                {
                    try { acq.Complete -= Acq_Complete; } catch { }

                    try
                    {
                        // 清空 FIFO，取消挂起的采集
                        acq.Flush();

                        // 可选：等待设备不忙（最多等待一段时间）
                        acq.GetFifoState(out int numPending, out int numReady, out bool busy);
                        int wait = 0;
                        while (busy && wait++ < 20)
                        {
                            System.Threading.Thread.Sleep(50);
                            acq.GetFifoState(out numPending, out numReady, out busy);
                        }
                    }
                    catch { }
                }

                // 2) 清 UI 图像，避免关闭时还引用已释放图
                if (pictureBox1 != null)
                {
                    var old = pictureBox1.Image;
                    pictureBox1.Image = null;
                    old?.Dispose();
                }

                // 3) 释放 acq FIFO
                if (acq != null)
                {
                    try
                    {
                        // 只有当运行时对象实现 IDisposable 时才调用 Dispose
                        if (acq is IDisposable disposable)
                        {
                            disposable.Dispose();
                        }
                    }
                    catch { }
                    acq = null;
                }

                // 4) 断开/释放 grabber
                if (grabbers != null)
                {
                    try
                    {
                        foreach (ICogFrameGrabber g in grabbers)
                        {
                            try { g.Disconnect(false); } catch { }
                        }
                    }
                    catch { }
                    try
                    {
                        if (grabbers is IDisposable disp)
                            disp.Dispose();
                    }
                    catch { }
                    grabbers = null;
                }

                CTB.Dispose();
                // winform一旦加载vpp，就会有一个无法销毁的后台进程
                System.Diagnostics.Process.GetCurrentProcess().Kill(); // 强行结束当前进程
            }
            catch (Exception ex)
            {
                // 关闭阶段别再弹窗卡住，记录日志即可
                System.Diagnostics.Debug.WriteLine("释放出错:" + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            grabbers = new CogFrameGrabbers();
            foreach (ICogFrameGrabber item in grabbers) {
                MessageBox.Show(item.Name);
            }

            ICogFrameGrabber grabber = grabbers[0];
            acq = grabber.CreateAcqFifo("Generic GigEVision (Mono)",
                CogAcqFifoPixelFormatConstants.Format8Grey,
                0,
                true
                );

            acq.OwnedExposureParams.Exposure = 300;

            if (acq == null)
                MessageBox.Show("连接相机错误");
            acq.Complete += Acq_Complete;
            //acq.Complete += (object s, CogCompleteEventArgs ev) => {
            //    ICogAcqFifo acq = (ICogAcqFifo)s;

            //    acq.GetFifoState(out int numPendding, out int numReady, out bool busy);
            //    // 判断是否至少取到一张图片
            //    if (numReady <= 0)
            //        MessageBox.Show(numReady.ToString());
            //    ICogImage Img = acq.CompleteAcquireEx(new CogAcqInfo());

            //    // 为了能显示这张图，我们需要使用灰度图工具处理
            //    CogImageConvertTool CICT = new CogImageConvertTool
            //    {
            //        InputImage = Img
            //    };
            //    CICT.Run();
            //    // 让图片显示在PB中
            //    Bitmap bmp = CICT.OutputImage.ToBitmap();
            //    pictureBox1.Image = bmp as System.Drawing.Image;
            //};
        }

        private void Acq_Complete(object sender, CogCompleteEventArgs e)
        {
            ICogAcqFifo Acq = sender as ICogAcqFifo;
            Acq.GetFifoState(out int _, out int ReadyNum, out bool _);
            if (ReadyNum > 0)
            {
                //获取图像
                ICogImage Img = Acq.CompleteAcquireEx(new CogAcqInfo());
                // 让灰度图工具处理图片
                CogImageConvertTool CICT = new CogImageConvertTool();
                CICT.InputImage = Img;
                CICT.Run();

                //// 转换图片格式
                //Bitmap bm = CICT.OutputImage.ToBitmap();
                //// 在picturebox中显示
                //pictureBox1.Image = bm as System.Drawing.Image;
                pictureBox1.Invoke(new Action(() =>
                {
                    var old = pictureBox1.Image;
                    Bitmap bm = CICT.OutputImage.ToBitmap();
                    pictureBox1.Image = bm as System.Drawing.Image;
                    old?.Dispose();  // 释放旧图，避免内存泄漏
                }));

                // 传递给toolblock
                CTB.Inputs["OutputImage"].Value = Img;
                CTB.Run();
                CogPMAlignResults res = (CogPMAlignResults)CTB.Outputs["Results"].Value;

                // ===== UI 操作：全部 Invoke 回主线程 =====
                label2.Invoke(new Action(() =>
                {
                    label2.Text = res.Count.ToString();
                }));


                //this.Invoke(label2.Text = res.Count.ToString(););

            }
            else
            {
                MessageBox.Show("没有获取到图像");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            acq.StartAcquire();
        }
    }
}
