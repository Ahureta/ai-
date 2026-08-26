using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _8_26
{
    public partial class KeyMove : Form
    {
        public KeyMove()
        {
            InitializeComponent();
            this.KeyDown += KeyMove_KeyDown;
        }

        private void KeyMove_KeyDown(object? sender, KeyEventArgs e)
        {
            int speed = 5;
            Point location = panel1.Location;
            switch (e.KeyCode) {
                case Keys.W:
                    location.Y -= speed;
                    break;
                case Keys.S:
                    location.Y += speed;
                    break;
                case Keys.A:
                    location.X -= speed;
                    break;
                case Keys.D:
                    location.X += speed;
                    break;
                default:
                    break;
            }
            panel1.Location = location;
        }
    }
}
