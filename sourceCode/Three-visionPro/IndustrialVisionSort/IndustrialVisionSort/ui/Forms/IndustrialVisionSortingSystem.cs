using AntdUI;
using IndustrialVisionSort.ui.Controls;
using IndustrialVisionSort.ui.Controls.UC;
using IndustrialVisionSort.ui.Controls.UC.ContolSetting;
using IndustrialVisionSort.ui.Controls.UC.ControlConfig;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MenuItem = AntdUI.MenuItem;

namespace IndustrialVisionSort.ui.Forms
{
    public partial class IndustrialVisionSortingSystem : Form
    {
        // 用于缓存已创建的 UserControl（关键！防止重复New导致卡顿和数据丢失）
        // 懒加载缓存：key -> Lazy<UserControl>
        private readonly Dictionary<string, Lazy<UserControl>> _pages =
            new Dictionary<string, Lazy<UserControl>>(StringComparer.OrdinalIgnoreCase);        
        public IndustrialVisionSortingSystem()
        {
            InitializeComponent();

            // 注册懒加载工厂（此时不new，只是登记）
            Register("Main", () => new UcMain());

            Register("DeviceDebug", () => new UcDeviceDebug());
            Register("Log", () => new UcLog());

            Register("CameraSetting", () => new UcCameraSetting());
            Register("ImageSaveConfig", () => new UcImageSaveConfig());
            Register("PMATemplateTraining", () => new UcPMATemplateTraining());
            Register("VPPPlan", () => new UcVPPPlan());

            Register("ModbusConfig", () => new UcModbusConfig());
            Register("RobotConfig", () => new UcRobotConfig());
            Register("SQLConfig", () => new UcSQLConfig());
            Register("VisionParamConfig", () => new UcVisionConfig());

            this.Shown += IndustrialVisionSortingSystem_Shown;
        }
        private void IndustrialVisionSortingSystem_Shown(object sender, EventArgs e)
        {
            MenuSet();
            ShowPage("Main");

            // 绑定菜单事件
            menu.SelectChanged += Menu_SelectChanged;
        }
        private void MenuSet() {
            //menu.Items[0].Sub[0].Tag = menu.Items[0].Sub[0].Name;
            MenuSetCore(menu.Items);
        }
        private void MenuSetCore(IEnumerable<MenuItem> items)
        {
            if (items == null) return;

            foreach (var item in items)
            {
                // 把当前项的 Tag 设为 Name
                // 如果 Name 为空就跳过（或者给个兜底值）
                if (!string.IsNullOrEmpty(item.Name))
                {
                    item.Tag = item.Name;
                }
                else
                {
                    // Name 为空时，用 Text 兜底（或者生成一个唯一ID）
                    item.Tag = item.Text;
                }

                // 如果有子项，递归处理
                if (item.Sub != null && item.Sub.Count > 0)
                {
                    MenuSetCore(item.Sub);
                }
            }
        }
        private void Register(string key, Func<UserControl> factory)
        {
            // 默认 ExecutionAndPublication：线程安全，只创建一次
            _pages[key] = new Lazy<UserControl>(factory);
        }
        private void Menu_SelectChanged(object sender, MenuSelectEventArgs e)
        {
            var item = e.Value; // 获取当前选中的 MenuItem
            if (item == null) return;

            // 获取菜单的唯一标识（用 Tag 最稳）
            string pageKey = item.Tag?.ToString();
            if (string.IsNullOrEmpty(pageKey)) return;

            // 如果是父菜单（有子项），可以选择只展开不换页
             if (item.Sub != null && item.Sub.Count > 0) return;

            // 切换到对应的页面
            ShowPage(pageKey);
        }
        // 核心：显示页面（带缓存逻辑）
        private void ShowPage(string pageKey)
        {
            PNView.SuspendLayout();

            // 先尝试以 Lazy<UserControl> 取出
            if (!_pages.TryGetValue(pageKey, out Lazy<UserControl> lazy))
            {
                // 取不到：说明 Tag 写错了或忘注册了，给个提示就行
                MessageBox.Show($"未找到页面: {pageKey}");
                return;
            }

            // 使用 Lazy.Value 获取真实控件
            UserControl uc = lazy.Value;
            uc.Dock = DockStyle.Fill;           // ← 不加这个控件不会填满 Panel

            // 替换 Panel 的内容
            PNView.Controls.Clear();
            PNView.Controls.Add(uc);
            uc.BringToFront();

            PNView.ResumeLayout(true);
          }
    }
}