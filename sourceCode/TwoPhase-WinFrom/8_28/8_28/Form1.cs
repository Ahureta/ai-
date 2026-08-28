using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _8_28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //button1.Location 相当于button1.Left
            //button1.Click += Button1_Click;
            //MouseEventArgs e1 = e as MouseEventArgs;
            //label1.Text = e1.Location.X.ToString();

            initChange();
            initCheckBox();
        }
        private void initCheckBox() {
            AllCb.CheckStateChanged += AllCb_CheckStateChanged;            
            foreach (var item in panel1.Controls) (item as CheckBox).CheckedChanged += Form1_CheckedChanged;
        }

        private void Form1_CheckedChanged(object? sender, EventArgs e)
        {            
            List<Control> list = panel1.Controls.OfType<Control>().ToList();

            List<Control> list2 = list.FindAll(item => ((CheckBox)item).Checked);
            int listCount = list2.Count;

            int panelCount = panel1.Controls.Count;

            if (listCount == 0)
            {
                AllCb.CheckState = CheckState.Unchecked;
            }
            else
            {
                if (listCount < panelCount) AllCb.CheckState = CheckState.Indeterminate;
                if (listCount == panelCount) AllCb.CheckState = CheckState.Checked;
            }
        }

        private void AllCb_CheckStateChanged(object? sender, EventArgs e)
        {
            CheckBox cb = sender as CheckBox;
            bool cd = cb.CheckState == CheckState.Checked;
            List<Control> list = panel1.Controls.OfType<Control>()?.ToList();
            if (cb.CheckState == CheckState.Indeterminate) return;
            list.ForEach(item => ((CheckBox)item).Checked=cd);
        }

        private Dictionary<string, List<string>> provinceCities = new()
        {
            ["广东"] = new List<string> { "广州", "深圳", "珠海" },
            ["浙江"] = new List<string> { "杭州", "宁波", "温州" }
        };
        private void initChange()
        {
            string[] provinces = provinceCities.Keys.ToArray();
            ProvinceCb.Items.Clear();
            ProvinceCb.Items.AddRange(provinces);
            CityCb.Items.Clear();

            ProvinceCb.SelectedIndexChanged += ProvinceCb_SelectedIndexChanged;
        }

        private void ProvinceCb_SelectedIndexChanged(object? sender, EventArgs e)
        {
            string selectedProvince = ProvinceCb.SelectedItem as string;
            if (selectedProvince != null && provinceCities.ContainsKey(selectedProvince))
            {
                CityCb.Items.Clear();
                CityCb.Text = "请选择市";
                CityCb.Items.AddRange(provinceCities[selectedProvince].ToArray());
            }
            else
            {
                CityCb.Items.Clear();
            }
        }
    }
}
