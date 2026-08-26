using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _8_26
{
    public partial class FocusIsNull : Form
    {
        public FocusIsNull()
        {
            InitializeComponent();
            textBox1.Validating += TextBox1_Validating;
        }

        private void TextBox1_Validating(object? sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text)) textBox1.Focus();
        }
    }
}
