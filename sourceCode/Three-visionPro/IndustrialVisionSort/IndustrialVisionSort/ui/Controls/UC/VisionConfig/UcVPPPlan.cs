using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndustrialVisionSort.ui.Controls.UC.ControlConfig
{
    public partial class UcVPPPlan : UserControl
    {
        public UcVPPPlan()
        {
            InitializeComponent();
            Init();
        }
        private void Init() {
            BTLoadVPPPlan.Click += BTLoadVPPPlan_Click;
            BTSaveVPPPlan.Click += BTSaveVPPPlan_Click;
        }

        private void BTSaveVPPPlan_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog SFD = new SaveFileDialog())
            {
                SFD.RestoreDirectory = false;
                SFD.Filter = "文本|*.txt";
                SFD.InitialDirectory = System.Windows.Forms.Application.StartupPath;
                if (SFD.ShowDialog() == DialogResult.OK)
                {
                    //File.WriteAllText(SFD.FileName, "123");
                    MessageBox.Show("保存成功,路径："+SFD.FileName);
                }
            }
        }

        private void BTLoadVPPPlan_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Title = "请选择文件", // 弹窗标题
                Filter = "VPP文件(*.vpp)|*.vpp",
                //Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*", // 文件筛选器
                InitialDirectory = System.Windows.Forms.Application.StartupPath, // 默认打开程序所在文件夹
                Multiselect = true // 开启多文件选择
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 获取选中文件完整路径
                string filePath = openFileDialog.FileName;
                LBCurrentVPPPath.Text = filePath;
            }
        }
    }
}
