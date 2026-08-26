using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _8_26
{
    public partial class ComboBoxOpen : Form
    {
        public ComboBoxOpen()
        {
            InitializeComponent();
            comboBox1.GotFocus += ComboBox_GotFocus;
            comboBox2.Leave += ComboBox2_Leave; 
        }

        private void ComboBox2_Leave(object? sender, EventArgs e)
        {
            comboBox1.DroppedDown = false;
        }

        private void ComboBox_GotFocus(object? sender, EventArgs e)
        {
            comboBox1.DroppedDown = true;
        }
    }
}
