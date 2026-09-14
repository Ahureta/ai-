using _8_29.Data.Repositories;
using _8_29.Info;
using AntdUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _9_12车辆租还
{
    public partial class Form4 : Form
    {
        private ICarRepository carRepository = new CarRepository();
        private BindingList<UserInfo> list = [];
        internal RentRecordInfo rentRecordInfo;
        internal CardInfo Card = new();

        public Form4()
        {
            InitializeComponent();
            this.Shown += Form4_Shown;
        }

        public Form4(CardInfo Card)
        {
            InitializeComponent();
            init();
            this.Shown += Form4_Shown;
        }
        private void init() { }

        private void Form4_Shown(object? sender, EventArgs e)
        {
            label5.Text = Card.Id.ToString();
            label6.Text = Card.Type;

            UserShowAsync();
            button1.Click += Button1_Click;
        }
        private async void UserShowAsync()
        {
            list = await carRepository.GetUserAsync();
            if (select1.InvokeRequired)
            {
                select1.Invoke(new MethodInvoker(() => FillUsers(list)));
            }
            else
            {
                FillUsers(list);
            }
        }
        private void FillUsers(BindingList<UserInfo> list)
        {
            select1.Items.Clear();

            foreach (var u in list)
            {
                // 第一个参数：下拉显示的文字；第二个参数：实际值（一般存主键）
                select1.Items.Add(new SelectItem(
                    $"{u.Name}（{u.Tel}）",   // 显示
                    u.Id             // 值
                ));
            }

            // 可选：默认不选 / 或选第一个
            select1.SelectedIndex = 0;
        }

        private async void Button1_Click(object? sender, EventArgs e)
        {
            rentRecordInfo = new()
            {
                CarId = Card.Id,
                UserId = (int)select1.SelectedValue,
                RentTime = DateTime.Now
            };

            if (await carRepository.BorrowAsync(rentRecordInfo) > 1) this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
