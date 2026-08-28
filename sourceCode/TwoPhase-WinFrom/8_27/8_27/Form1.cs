using System.Reflection.Emit;

namespace _8_27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            init();
        }
        private List<Dictionary<string, Control>>? listDic = new List<Dictionary<string, Control>>() { };
        private void init() {
            listDic?.Add(new Dictionary<string, Control>()
            {
                ["label"] = label5,
                ["number"] = textBox1,
                ["delete"] = button1,
                ["add"] = button2,
            });
            listDic?.Add(new Dictionary<string, Control>()
            {
                ["label"] = label7,
                ["number"] = textBox2,
                ["delete"] = button3,
                ["add"] = button4,
            });

            foreach (Dictionary<string, Control> dic in listDic) {
                dic["number"].TextChanged += Form1_TextChanged;
                dic["delete"].Click += Form1_Click;
                dic["add"].Click += Form1_Click1;
            }
        }

        private void Form1_Click1(object? sender, EventArgs e)
        {
            Button bt = sender as Button;
            //得其数量
            TextBox tb = (TextBox)listDic.Find(item => ((Button)item["add"]) == bt)?["number"];
            string number = tb?.Text;
            int.TryParse(number, out int num);
            num++;            //为空时默认值自增
            tb.Text = num.ToString();

            //计算总价格
            totals();
        }

        private void Form1_Click(object? sender, EventArgs e)
        {
            Button bt = sender as Button;
            //得其数量
            TextBox tb = (TextBox)listDic.Find(item => ((Button)item["delete"]) == bt)?["number"];
            string number = tb.Text;
            int.TryParse(number, out int num);
            num--;
            if (num < 0) num = 0;
            tb.Text = num.ToString();

            //计算总价格
            totals();
        }

        private void Form1_TextChanged(object? sender, EventArgs e)
        {
            totals();
        }

        private void totals() {
            Double total = 0;            
            foreach (Dictionary<string, Control> dic in listDic)
            {
                //访问其单价
                string price = dic["label"].Text;
                Double.TryParse(price, out Double pri);
                int.TryParse(dic["number"].Text, out int num);
                total += pri * num;
            }

            label9.Text = total.ToString();
        }
    }
}
