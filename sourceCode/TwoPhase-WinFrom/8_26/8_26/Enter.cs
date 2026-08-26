using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _8_26
{
    public partial class Enter : Form
    {
        public Enter()
        {
            InitializeComponent();
            textBox1.KeyUp += TextBox1_KeyUp;
        }

        private void TextBox1_KeyUp(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) MessageBox.Show("提交表单");
        }
    }
}
