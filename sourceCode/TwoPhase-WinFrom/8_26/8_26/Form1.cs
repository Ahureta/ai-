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

        public string[] picArr = [@"./images/cat.jpg", @"./images/bird.jpg", @"./images/eagle.jpg"];        
        public int index = 0;
        public void initTab()
        {
            // 设置初始值
            pictureBox1.Image = Image.FromFile(picArr[index]);
            panel1.Controls[0].BackColor = Color.Cyan;
            panel1.Controls[0].ForeColor = Color.White;

            // 绑定事件
            for (int i = 0; i < 3; i++)
            {
                panel1.Controls[i].Click += button_Click;

            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            //// 先将所有的按钮的高亮效果移除
            //for (int i = 0; i < panel1.Controls.Count; i++)
            //{
            //    panel1.Controls[i].BackColor = Color.DarkGray;
            //    panel1.Controls[i].ForeColor = Color.Black;
            //}
            //// 将当前这个按钮的高亮添加
            //Button btn = (Button)sender;
            //btn.BackColor = Color.Cyan;
            //btn.ForeColor = Color.White;

            Button btn = (Button)sender;

            for (int i = 0; i < 3; i++)
            {
                panel1.Controls[i].BackColor = Color.DarkGray;
                panel1.Controls[i].ForeColor = Color.Black;
            }

            // 将当前这个按钮的高亮添加    
            btn.BackColor = Color.Cyan;
            btn.ForeColor = Color.White;

            // 修改图片地址: 当前按钮和对应的图片地址的索引一致
            // 获取 btn按钮在容器中的下标
            index = panel1.Controls.IndexOf(btn);

            pictureBox1.Image = Image.FromFile(picArr[index]);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int len = picArr.Length;
            index = (index - 1  + len) % len;
            pictureBox1.Image = Image.FromFile(picArr[index]);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int len = picArr.Length;
            index = (index + 1 + len) % len;
            pictureBox1.Image = Image.FromFile(picArr[index]);
        }
    }
}
