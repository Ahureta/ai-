using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _8_27
{
    public partial class MaxLength : Form
    {
        public MaxLength()
        {
            InitializeComponent();
            textBox1.KeyPress += TextBox1_KeyPress;
        }

        private void TextBox1_KeyPress(object? sender, KeyPressEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb.Text.Length > 10) tb.Text = tb.Text.Substring(0,10);
            tb.SelectionStart = tb.Text.Length;
        }
    }
}
