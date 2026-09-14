using _8_29.Data.Repositories;
using _8_29.Info;
using System.ComponentModel;

namespace _9_12车辆租还
{
    public partial class Form1 : Form
    {
        private BindingList<CardInfo> CarList = [];
        private BindingList<UserInfo> UserList = [];
        private CarRepository carRepository = new();
        public Form1()
        {
            InitializeComponent();
            this.Shown += Form1_Shown;
        }

        private void Form1_Shown(object? sender, EventArgs e)
        {
            //绑定按钮点击事件
            bookShowTBCellButtonClick();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            using Form2 carAddWF = new();

            if (carAddWF.ShowDialog() == DialogResult.OK)
            {
                AntdUI.Message.success(this, "新增成功", autoClose: 3);
            }
            else
            {
                AntdUI.Message.error(this, "新增失败", autoClose: 3);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using Form3 userAddWF = new();

            if (userAddWF.ShowDialog() == DialogResult.OK)
            {
                AntdUI.Message.success(this, "新增成功", autoClose: 3);
            }
            else
            {
                AntdUI.Message.error(this, "新增失败", autoClose: 3);
            }
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            ICarRepository bookRepository = new CarRepository();

            UserList = await bookRepository.GetUserAsync();
            //MessageBox.Show(string.Join(",",UserList));
            if (UserList == null) MessageBox.Show("查询失败");

            table1.DataSource = UserList;

            table1.Columns.Clear();
            table1.Columns = new AntdUI.ColumnCollection {
                new AntdUI.Column("Id", "编号")
                {
                    Render = (object val, object cel, int index) => (index + 1).ToString()
                },
                new AntdUI.Column("Name", "客户姓名"),
                new AntdUI.Column("IdCard", "身份证号"),
                new AntdUI.Column("RegTime", "注册时间"),
                new AntdUI.Column("Gender", "性别"),
                new AntdUI.Column("Tel", "手机号码"),
                new AntdUI.Column("Motto", "座右铭")
            };

        }

        private async void button4_Click(object sender, EventArgs e)
        {
            ICarRepository bookRepository = new CarRepository();

            CarList = await bookRepository.GetCarAsync();
            //MessageBox.Show(string.Join(",", UserList));
            if (UserList == null) MessageBox.Show("查询失败");

            table1.DataSource = CarList;

            table1.Columns.Clear();
            table1.Columns = new AntdUI.ColumnCollection {
                new AntdUI.Column("Id", "编号")
                {
                    Render = (object val, object cel, int index) => (index + 1).ToString()
                },
                new AntdUI.Column("Card", "车牌号"),
                new AntdUI.Column("Type", "车辆类型"),
                new AntdUI.Column("Status", "出租状态"),
                new AntdUI.Column("Price", "每小时租赁费用"),
                                new AntdUI.Column("OperateBtns", "操作")
                {
                    Align = AntdUI.ColumnAlign.Center,
                    Width = "200",
                    Render = (object val, object cel, int index) =>
                    {
                        var card = cel as CardInfo;
                        if (card == null) return null;

                        return new AntdUI.CellButton[]
                        {
                            card.Status
                                ? new AntdUI.CellButton($"return_{card.Id}", "归还", AntdUI.TTypeMini.Default)
                                : new AntdUI.CellButton($"borrow_{card.Id}", "借车", AntdUI.TTypeMini.Default),
                        };
                    }
                }
            };
        }

        private void bookShowTBCellButtonClick()
        {
            table1.CellButtonClick += async (s, e) =>
            {
                // e.Btn       —— 被点击的那个 CellButton（可以拿到 Text、ID）
                // e.record    —— 当前行的原始数据对象（就是你绑定的 BookInfo）
                // e.rowIndex  —— 行序号
                // e.columnIndex —— 列序号

                var btn = e.Btn;
                var card = e.Record as CardInfo;   // 直接拿到行数据
                if (card == null) return;

                // 方式1：通过按钮 ID 判断
                var btnId = btn.Id;  // 形如 "edit_3"、"borrow_5"
                var parts = btnId.Split('_');
                var action = parts[0];   // "edit" / "del" / "borrow" / "return"

                // 方式2：也可以直接通过 btn.Text 判断（中文文本）
                // switch (btn.Text) { case "编辑": ... }
                //var action = btn.Text;
                var bookId = int.Parse(parts[1]);

                switch (action)
                {
                    case "borrow":
                        // 租车逻辑                        
                        Form4 form4 = new()
                        {
                            Card = card
                        };
                        if (form4.ShowDialog() == DialogResult.OK)
                            AntdUI.Message.success(this, "租车成功", autoClose: 3);
                        else
                            AntdUI.Message.error(this, "租车失败", autoClose: 3);
                        break;
                    case "return":
                        // 归还逻辑
                        var r = AntdUI.Modal.open(this, "提示", "确定要归还吗？", AntdUI.TType.Warn);
                        if (r == DialogResult.OK) {
                            if (await carRepository.ReturnAsync(card) > 2) this.DialogResult = DialogResult.OK;
                                AntdUI.Message.success(this, "归还成功", autoClose: 3);
                            //else
                            //    AntdUI.Message.error(this, "归还失败", autoClose: 3);
                        }
                        break;
                }
            };
        }
    }
}
