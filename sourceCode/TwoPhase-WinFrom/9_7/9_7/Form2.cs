using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _9_7
{
    public partial class Form2 : Form
    {
        private int RadiusX = 150;
        private int RadiusY = 150;

        private int Radius = 100;
        private int LineStartX = 250;
        private int LineStartY = 150;
        private int LineEndX = 150+80;
        private int LineEndY = 150;
        private int LongScale = 10;
        private int ScaleCount = 60;
        private int Num = 0;

        private System.Windows.Forms.Timer SecondTimer = new System.Windows.Forms.Timer();        
        public Form2()
        {
            InitializeComponent();

            DateTime Now = DateTime.Now;
            Num = Now.Second;
            panel1.Paint += Panel1_Paint;
            SecondTimer.Interval = 1000;
            SecondTimer.Tick += SecondTimer_Tick;
            SecondTimer.Start();
        }

        private void SecondTimer_Tick(object? sender, EventArgs e)
        {
            Num++;
            // 让画图程序重新画一次
            panel1.Invalidate();
        }

        private void Panel1_Paint(object? sender, PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            using var pen = new Pen(Color.Black, 2);
            g.DrawArc(pen,50,50,200,200,0,360);
            var EveryDeg = 360 / ScaleCount;
            for (int i = 0; i < ScaleCount; i++) {
                var TempScale = LongScale;
                if (i % 5 == 0) TempScale = LongScale + 10;
                var StartX = Math.Cos(i * EveryDeg * Math.PI / 180) * Radius + RadiusX;
                var StartY = Math.Sin(i * EveryDeg * Math.PI / 180) * Radius + RadiusY;

                var EndX = Math.Cos(i * EveryDeg * Math.PI / 180) * (Radius - TempScale) + RadiusX;
                var EndY = Math.Sin(i * EveryDeg * Math.PI / 180) * (Radius - TempScale) + RadiusY;

                g.DrawLine(pen, (int)StartX, (int)StartY, (int)EndX, (int)EndY);
            }
            using var SecondLine = new Pen(Color.Red, 2);
            var SecondStartX = Math.Cos((Num * 6 + 270) * Math.PI / 180) * Radius + RadiusX;
            var SecondStartY = Math.Sin((Num * 6 + 270) * Math.PI / 180) * Radius + RadiusY;

            g.DrawLine(SecondLine, (int)SecondStartX, (int)SecondStartY, RadiusX, RadiusY);
        }
    }

    public class DoubleBufferPanel2 : Panel
    {
        public DoubleBufferPanel2()
        {
            //开启双缓冲，消除闪烁
            this.SetStyle(ControlStyles.UserPaint
                | ControlStyles.AllPaintingInWmPaint
                | ControlStyles.OptimizedDoubleBuffer, true);
            UpdateStyles();
        }
    }
}
