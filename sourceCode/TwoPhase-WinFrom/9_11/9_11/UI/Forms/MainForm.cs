using _9_11.Application.Abstractions;
using _9_11.Application.Implementation;
using _9_11.Domain.Entities;
using _9_11.Domain.Events;
using _9_11.UI.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _9_11.UI.Forms
{
    internal partial class MainForm : Form
    {
        private readonly IMonitoringService _monitoring = new MonitoringService();
        private readonly BulkBindingList<DeviceTempRecord> _tempList = new();

        public MainForm()
        {
            InitializeComponent();            
            _monitoring.TempRead += OnTempRead;
            DTRTB.DataSource = _tempList;
        }

        public MainForm(MonitoringService monitoring)
        {
            InitializeComponent();
            _monitoring = monitoring;
            _monitoring.TempRead += OnTempRead;
            //_monitoring.DeviceStatusChanged += OnDeviceStatusChanged;
            DTRTB.DataSource = _tempList;
        }

        private void OnTempRead(object? sender, TempReadEventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action(() => HandleTempRead(e.Record)));
                return;
            }
            HandleTempRead(e.Record);
        }

        private void HandleTempRead(DeviceTempRecord record)
        {
            _tempList.Add(record);
            DTRTB.Refresh();
            // 或者如果列表太长，限制行数
            if (_tempList.Count > 500)
                _tempList.RemoveAt(0);
        }

        private async void setTemperatureBT_Click(object sender, EventArgs e)
        {            
            try
            {
                if (!double.TryParse(setTemperatureTB.Text, out double temperature))
                    AntdUI.Message.info(this,"设定温度有误!",autoClose:3);
                await _monitoring.SetTemperatureAsync(temperature);                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"设定温度异常：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void deviceStartBT_Click(object sender, EventArgs e)
        {
            try
            {
                await _monitoring.DeviceStartAsync();
                logging("设备置运行状态");
            }
            catch (Exception ex) {
                MessageBox.Show($"设备启动异常：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void deviceStopBT_Click(object sender, EventArgs e)
        {
            try { 
                await _monitoring.DeviceStopAsync();
                logging("设备待机状态");
            } catch (Exception ex) {
                MessageBox.Show($"设备停止异常：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void getConnectPLCBT_Click(object sender, EventArgs e)
        {
            getConnectPLCBT.Enabled = false;
            try
            {
                await _monitoring.GetConnectAsync();
                connectStatusLB.Text = "已连接";                                    
                logging("连接设备成功，开始采集");
            }
            catch (Exception ex)
            {
                connectStatusLB.Text = "连接失败";
                connectStatusLB.ForeColor = Color.Red;
                MessageBox.Show($"设备连接异常：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                getConnectPLCBT.Enabled = true;
            }
        }

        private async void lostConnectPLCBT_Click(object sender, EventArgs e)
        {
            try
            {
                await _monitoring.LostConnectAsync();
                connectStatusLB.Text = "未连接";
                logging($"设备断开连接");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"设备断开异常：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchHistoryBT_Click(object sender, EventArgs e)
        {
            if (!ushort.TryParse(setTemperatureTB.Text, out ushort c))
            {
                AntdUI.Message.error(this, "请输入设定温度", autoClose: 3);
            }
            //Master.WriteSingleRegister(1, 1, c);

            logging($"设置目标温度={c}℃");
        }


        private void logging(string logString)
        {

            AntdUI.Label label = new AntdUI.Label
            {
                Text = logString,
                AutoSize = true,          // 让 label 根据文本自动调整大小
                Location = new Point(10, loggingPN.Controls.Count * 30) // 手动定位，避免重叠
            };

            loggingPN.Controls.Add(label);
        }
    }
}
