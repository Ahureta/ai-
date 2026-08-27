using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Channels;
using System.Windows.Forms;

namespace _8_27
{
    public partial class ComItem : Form
    {
        public ComItem()
        {
            InitializeComponent();
            init();
        }
        List<string> list = ["11111222222","444444442222222","44444444555555","66666666677777","889089078979","24325345"];
        private void init() {
            listBox1.Items.Clear();
            listBox1.Items.AddRange(list.ToArray());
            textBox1.TextChanged += textBox1_TextChanged;
        }

        private void textBox1_TextChanged(object? sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            List<string> list2 = list.FindAll(item => item.Contains(tb.Text));
            listBox1.Items.Clear();
            listBox1.Items.AddRange(list2.ToArray());
        }
    }
}
