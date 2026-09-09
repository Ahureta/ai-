using System.Runtime.Intrinsics.X86;

namespace FontGame
{
    public partial class Form1 : Form
    {
        //全局计时器;
        private System.Windows.Forms.Timer globalTimer = new();
        //全局随机对象
        private Random random = new();
        //计时器字典
        private List<Dictionary<string, dynamic>> LbAndTimer = new();
        private int Score = 0;
        public Form1()
        {
            InitializeComponent();
            this.Shown += Form1_Shown;
            Init();
        }
        private void Init()
        {
            button1.Click += Button1_Click;
        }

        private void Button1_Click(object? sender, EventArgs e)
        {
            globalTimer.Start();
        }

        private void Form1_Shown(object? sender, EventArgs e)
        {
            globalTimer.Interval = 1000;
            globalTimer.Tick += GlobalTimer_Tick;

            // 移动焦点
            this.KeyPreview = true;
            // 绑定键盘事件
            this.KeyUp += WordGameV2_KeyUp;
        }

        private void WordGameV2_KeyUp(object? sender, KeyEventArgs e)
        {
            //// 敲键盘：遍历所有的label，跟当前敲键盘的字符判断是否相等
            //for (int i = 0; i < LbAndTimer.Count; i++)
            //{
            //    // 每个label LbAndTimer[i].label
            //    bool IsParsed = Enum.TryParse(LbAndTimer[i]["label"].Text, out Keys K);
            //    if (!IsParsed)
            //    {
            //        continue;
            //    }
            //    if (K == e.KeyCode)
            //    {
            //        // 敲中这个label了，删除label，停止他对应的timer
            //        panel1.Controls.Remove(LbAndTimer[i]["label"]);
            //        LbAndTimer.remove
            //        LbAndTimer[i]["timer"].Stop();
            //        Score++;
            //        label2.Text = Score.ToString();
            //        break;
            //    }
            //}

            for (int i = 65; i < 91; i++)
            {
                if (Enum.TryParse(((char)i).ToString(), out Keys key) && e.KeyCode == key)
                {
                    // 处理按键
                    var item = LbAndTimer.Find(item => item["label"].Text == e.KeyCode.ToString());
                    if (item == null) break;
                    panel1.Controls.Remove(item["label"]);
                    item["timer"].Stop();
                    LbAndTimer.Remove(item);
                    Score++;
                    label1.Text = Score.ToString();
                    break;
                }
            }
        }

        private void GlobalTimer_Tick(object? sender, EventArgs e)
        {
            //创建lable
            Label label = new();
            label.Size = new(25, 25);
            label.Text = ((char)random.Next(65, 90)).ToString();
            label.Font = new("微软雅黑", 14, FontStyle.Bold, GraphicsUnit.Point);
            label.TextAlign = ContentAlignment.MiddleCenter;
            panel1.Controls.Add(label);

            label.Location = new Point(random.Next(panel1.Width - label.Width), 0);
            System.Windows.Forms.Timer timer = new();
            timer.Interval = 200;
            timer.Tick += (Object sender, EventArgs e) => up(label);
            timer.Start();
            LbAndTimer.Add(new Dictionary<string, dynamic>()
            {
                ["label"] = label,
                ["timer"] = timer
            });
        }
        private void up(Label label)
        {
            label.Top += 2;
            if (label.Top >= panel1.Height - 30)
            {
                //label.Top = panel1.Height - 30;
                // 让所有的timer都停下来
                foreach (var item in LbAndTimer)
                {
                    item["timer"].Stop();
                }
                globalTimer.Stop();
                MessageBox.Show("GAME OVER!!!");                
            }
        }
    }
}
