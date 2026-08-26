using System;
using System.Windows.Forms;

namespace _8_25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //object as Type 安全转换类型 失败为空不报错
            initTab();
        }


        private void Form1_Load(object? sender, EventArgs e)
        {
            // 窗体加载时的初始化逻辑（当前为空）
        }

        public string[] picArr = [@"./images/cat.jpg", @"./images/bird.jpg", @"./images/eagle.jpg"];

        public void initTab()
        {

            // 设置初始值
            pictureBox4.Image = Image.FromFile(picArr[0]);
            tableLayoutPanel1.Controls[0].BackColor = Color.Cyan;
            tableLayoutPanel1.Controls[0].ForeColor = Color.White;

            // 绑定事件
            for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            {
                tableLayoutPanel1.Controls[i].Click += button_Click;

            }
        }

        private void button_Click(object sender, EventArgs e)
        {            
            //// 先将所有的按钮的高亮效果移除
            //for (int i = 0; i < tableLayoutPanel1.Controls.Count; i++)
            //{
            //    tableLayoutPanel1.Controls[i].BackColor = Color.DarkGray;
            //    tableLayoutPanel1.Controls[i].ForeColor = Color.Black;
            //}
            //// 将当前这个按钮的高亮添加
            //Button btn = (Button)sender;
            //btn.BackColor = Color.Cyan;
            //btn.ForeColor = Color.White;

            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is Button button)
                {
                    control.BackColor = Color.DarkGray;
                    control.ForeColor = Color.Black;
                }
            }

            // 将当前这个按钮的高亮添加
            Button btn = (Button)sender;
            btn.BackColor = Color.Cyan;
            btn.ForeColor = Color.White;

            // 修改图片地址: 当前按钮和对应的图片地址的索引一致
            // 获取 btn按钮在容器中的下标
            int index = tableLayoutPanel1.Controls.IndexOf(btn);

            pictureBox4.Image = Image.FromFile(picArr[index]);
        }
    }
}
