namespace _8_26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Enter → GotFocus → Leave → Validating → Validated → LostFocus执行顺序
            initTab();
        }

        public string[] picArr = [@"../images/cat.jpg", @"./images/bird.jpg", @"./images/eagle.jpg"];

        public void initTab()
        {

            // 设置初始值
            pictureBox1.Image = Image.FromFile(picArr[0]);
            panel2.Controls[0].BackColor = Color.Cyan;
            panel2.Controls[0].ForeColor = Color.White;

            // 绑定事件
            for (int i = 0; i < panel2.Controls.Count; i++)
            {
                panel2.Controls[i].Click += button_Click;

            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            //// 先将所有的按钮的高亮效果移除
            //for (int i = 0; i < panel2.Controls.Count; i++)
            //{
            //    panel2.Controls[i].BackColor = Color.DarkGray;
            //    panel2.Controls[i].ForeColor = Color.Black;
            //}
            //// 将当前这个按钮的高亮添加
            //Button btn = (Button)sender;
            //btn.BackColor = Color.Cyan;
            //btn.ForeColor = Color.White;

            foreach (Control control in panel2.Controls)
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
            int index = panel2.Controls.IndexOf(btn);

            pictureBox1.Image = Image.FromFile(picArr[index]);
        }
    }
}
