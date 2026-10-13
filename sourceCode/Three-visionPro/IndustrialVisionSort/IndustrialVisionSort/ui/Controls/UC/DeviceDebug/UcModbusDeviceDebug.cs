using IndustrialVisionSort.Application.Implementation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IndustrialVisionSort.ui.Controls.UC.ContolSetting
{
    public partial class UcModbusDeviceDebug : UserControl
    {
        private ModbusService _modbusService;

        internal UcModbusDeviceDebug(ModbusService modbusService)
        {
            _modbusService = modbusService;
            InitializeComponent();
            InitAttribute();
            Init();
        }
        public void InitAttribute() {
            sliderSpeed.SetMinMax(1, 2000);
            sliderSpeed.Value = 200;

            _modbusService = new ModbusService(
                byte.Parse(IPIP.Text),
                int.Parse(IPDeviceStatus.Text),
                int.Parse(IPForwardAndReverse.Text),
                int.Parse(IPSpleed.Text)
            );
        }

        public void Init() {
            sliderSpeed.ValueChanged += (object sender, AntdUI.IntEventArgs e) => {
                LBCurrentSpeed.Text = sliderSpeed.Value + " 转/分";
            };
            sliderSpeed.MouseUp += (object sender, MouseEventArgs e) =>{
                _modbusService.SetSpeed(sliderSpeed.Value);
            };
        }

        private void BTConnectModbus_Click(object sender, EventArgs e)
        {
            _modbusService.Connect();
            LBConnectStatus.Text = "已连接";
        }

        private void BTLostModbus_Click(object sender, EventArgs e)
        {
            _modbusService.DisConnect();
            LBConnectStatus.Text = "已断开";
        }

        private void TBForwardRotation_Click(object sender, EventArgs e)
        {
            _modbusService.ForwardRotation();
            LBMoveStatus.Text = "正转";
        }

        private void BTReverse_Click(object sender, EventArgs e)
        {
            _modbusService.Reverse();
            LBMoveStatus.Text = "反转";
        }

        private void BTStop_Click(object sender, EventArgs e)
        {
            _modbusService.Stop();
            LBMoveStatus.Text = "停止";
        }

        private void BTStart_Click(object sender, EventArgs e)
        {
            _modbusService.Start();
            LBMoveStatus.Text = "启动";
        }
    }
}
