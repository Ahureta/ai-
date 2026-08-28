using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace _8_28
{
    public partial class Move : Form
    {
        public Move()
        {
            InitializeComponent();
            init();
        }
        private void init() {
            button1.MouseDown += Button1_MouseDown;
            button1.MouseMove += Button1_MouseMove;
            button1.MouseUp += Button1_MouseUp;
        }

        private Point P;
        bool i = false;
        //// 将鼠标在控件上的坐标换算成鼠标在屏幕上的坐标
        //控件.PointToScreen(e.Location)
        //// 从原坐标上偏移
        //Point坐标.Offset(+1, -1)
        //// 将Point坐标换算成某个父容器内部的坐标
        //父容器.PointToClient(Point坐标);
        private void Button1_MouseMove(object? sender, MouseEventArgs e)
        {
            Button bt = sender as Button;
            if (i) {
                Point p = bt.PointToScreen(e.Location);
                p.Offset(-P.X,-P.Y);

                // 限定极限位置
                if (p.X <= 0) p.X = 0;
                if (p.Y <= 0) p.Y = 0;
                int MaxY = this.Height - button1.Height;
                int MaxX = this.Width - button1.Width;
                if (p.X >= MaxX) p.X = MaxX;
                if (p.Y >= MaxY) p.Y = MaxY;

                //bt.Location = this.PointToClient(p);
                button1.Location = this.PointToClient(p);
            }
        }

        private void Button1_MouseUp(object? sender, MouseEventArgs e)
        {
            i = false;
        }

        private void Button1_MouseDown(object? sender, MouseEventArgs e)
        {
            i = true;
            P = e.Location;
        }
    }
}
