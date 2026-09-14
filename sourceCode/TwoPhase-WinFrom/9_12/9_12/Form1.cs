namespace _9_12
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            button2.Enabled = false;
            button3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string deviceName = input1.Text;
            AntdUI.Label label = new AntdUI.Label
            {
                Text = "设备名称:"+deviceName,
                AutoSize = true,          // 让 label 根据文本自动调整大小
                Location = new Point(10, panel4.Controls.Count * 30) // 手动定位，避免重叠
            };
            panel4.Controls.Add(label);

            string deviceType = comboBox1.SelectedText;
            AntdUI.Label label1 = new AntdUI.Label
            {
                Text = "设备类型:" + deviceType,
                AutoSize = true,          // 让 label 根据文本自动调整大小
                Location = new Point(10, panel4.Controls.Count * 30) // 手动定位，避免重叠
            };
            panel4.Controls.Add(label);

            // 原来的声明改为已初始化
            string? runModel = null;
            foreach (Control c in panel2.Controls)
            {
                if (c is AntdUI.Radio rb && rb.Checked) runModel = c.Text;
            }
            AntdUI.Label label3 = new AntdUI.Label
            {
                Text = "运行模式:" + runModel ?? string.Empty,
                AutoSize = true,
                Location = new Point(10, panel4.Controls.Count * 30)
            };
            panel4.Controls.Add(label3);

            bool tempWaring = checkbox2.Checked;
            AntdUI.Label label4 = new AntdUI.Label
            {
                Text = tempWaring?"已启动温度报警": "未启动温度报警",
                AutoSize = true,          // 让 label 根据文本自动调整大小
                Location = new Point(10, panel4.Controls.Count * 30) // 手动定位，避免重叠
            };
            panel4.Controls.Add(label4);

            int temp = (int)inputNumber1.Value;
            AntdUI.Label label5 = new AntdUI.Label
            {
                Text = "温度上限:" + temp.ToString(),
                AutoSize = true,          // 让 label 根据文本自动调整大小
                Location = new Point(10, panel4.Controls.Count * 30) // 手动定位，避免重叠
            };
            panel4.Controls.Add(label5);


            //AntdUI.Label label = new AntdUI.Label
            //{
            //    Text = deviceName,
            //    AutoSize = true,          // 让 label 根据文本自动调整大小
            //    Location = new Point(10, panel4.Controls.Count * 30) // 手动定位，避免重叠
            //};
            //panel4.Controls.Add(label);

            button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = true;
            string deviceName = input1.Text;
            AntdUI.Label label = new AntdUI.Label
            {
                Text = "设备名称:" + deviceName + "已启动",
                AutoSize = true,          // 让 label 根据文本自动调整大小
                Location = new Point(10, panel4.Controls.Count * 30) // 手动定位，避免重叠
            };
            panel4.Controls.Add(label);

            label8.Text = "运行中";
            label8.ForeColor = System.Drawing.Color.Blue;

            label9.Text = "已连接";
            label9.ForeColor = System.Drawing.Color.Blue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button2.Enabled = true;
            string deviceName = input1.Text;
            AntdUI.Label label = new AntdUI.Label
            {
                Text = "设备名称:" + deviceName + "已停止",
                AutoSize = true,          // 让 label 根据文本自动调整大小
                Location = new Point(10, panel4.Controls.Count * 30) // 手动定位，避免重叠
            };

            panel4.Controls.Add(label);
            label8.Text = "已停止";
            label8.ForeColor = System.Drawing.Color.Black;

            label9.Text = "未连接";
            label9.ForeColor = System.Drawing.Color.Black;
        }
    }
}
