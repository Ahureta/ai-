using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _8_26
{
    public partial class MouseMove : Form
    {
        public MouseMove()
        {
            InitializeComponent();
            this.MouseMove += MouseMove_MouseMove;
        }

        private void MouseMove_MouseMove(object? sender, MouseEventArgs e)
        {
            label1.Text = e.Location.X.ToString();
            label2.Text = e.Location.Y.ToString();
        }
    }
}
