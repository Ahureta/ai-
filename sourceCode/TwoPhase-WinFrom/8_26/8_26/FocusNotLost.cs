using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Channels;
using System.Windows.Forms;

namespace _8_26
{
    public partial class FocusNotLost : Form
    {
        public FocusNotLost()
        {
            InitializeComponent();
            textBox1.GotFocus += TextBox1_GotFocus;
            textBox1.Leave += TextBox1_LostFocus;

            //当用户试图从一个控件切换到另一个控件时，事件触发顺序如下：

            //Leave​ —— 表示焦点即将离开当前控件（在 Validating 之前触发）
            //Validating​ —— 开始验证。你可以在这里检查输入合法性，并通过设置 e.Cancel = true 阻止焦点离开。
            //Validated​ —— 验证通过后触发（仅当 Validating 未取消时）
            //LostFocus​ —— 控件正式失去焦点（仅当 Validating 未取消时）

            //所以，LostFocus 一定是发生在 Validated 之后，而 Validated 又发生在 Validating 未被取消的前提下。
        }

        private void TextBox1_LostFocus(object? sender, EventArgs e)
        {
            (sender as TextBox).BackColor = Color.White;
            (sender as TextBox).ForeColor = Color.Black;
            (sender as TextBox).BorderStyle = BorderStyle.FixedSingle;
        }

        private void TextBox1_GotFocus(object? sender, EventArgs e)
        {
            (sender as TextBox).BackColor = Color.Orange;
            (sender as TextBox).ForeColor = Color.Blue;
            (sender as TextBox).BorderStyle = BorderStyle.Fixed3D;
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (string.IsNullOrEmpty(tb.Text))
            {
                tb.Focus();
                label1.Visible = true;
            }
            else
            {
                label1.Visible = false;
            } 
        }
    }
}
