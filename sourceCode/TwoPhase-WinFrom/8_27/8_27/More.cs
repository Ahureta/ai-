using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _8_27
{
    public partial class More : Form
    {
        public More()
        {
            InitializeComponent();
            button1.MouseEnter += Button1_MouseEnter;
            button1.MouseLeave += Button1_MouseLeave;
        }

        private void Button1_MouseLeave(object? sender, EventArgs e)
        {
            Button bt = sender as Button;
            bt.Width -= 250;
            bt.Height -= 250;
        }

        private void Button1_MouseEnter(object? sender, EventArgs e)
        {
            Button bt = sender as Button;
            bt.Width += 250;
            bt.Height += 250;
        }
    }
}
