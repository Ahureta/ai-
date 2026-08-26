using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _8_26
{
    public partial class Esc : Form
    {
        public Esc()
        {
            InitializeComponent();
            this.KeyDown += Esc_KeyDown;
        }

        private void Esc_KeyDown(object? sender, KeyEventArgs e)
        {
            this.Close();
        }
    }
}
