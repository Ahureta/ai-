using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _8_26
{
    public partial class LikeLink : Form
    {
        public LikeLink()
        {
            InitializeComponent();
            label1.MouseEnter += Label1_MouseEnter;
            label1.MouseLeave += Label1_MouseLeave; ;
        }

        private void Label1_MouseLeave(object? sender, EventArgs e)
        {
            // 高亮 默认
            label1.ForeColor = Color.Blue;
            label1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
        }

        private void Label1_MouseEnter(object? sender, EventArgs e)
        {
            // 高亮 下划线
            label1.ForeColor = Color.Purple;
            // 字体  大小 样式  单位
            label1.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
        }
    }
}
