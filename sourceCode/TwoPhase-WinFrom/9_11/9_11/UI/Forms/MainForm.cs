using _9_11.Application.Abstractions;
using _9_11.Application.Implementation;
using _9_11.Domain.Entities;
using _9_11.UI.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _9_11.UI.Forms
{
    public partial class MainForm : Form
    {
        private readonly IMonitoringService _monitoring;
        private readonly BulkBindingList<DeviceTempRecord> _tempList = new();

        public MainForm(MonitoringService monitoring)
        {
            InitializeComponent();
            _monitoring = monitoring;
            _monitoring.TempRead += OnTempRead;
            _monitoring.DeviceStatusChanged += OnDeviceStatusChanged;
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
            // 或者如果列表太长，限制行数
            if (_tempList.Count > 1000)
                _tempList.RemoveAt(0);
        }

        private async void setTemperatureBT_Click(object sender, EventArgs e)
        {            
            try
            {
                if (double.TryParse(setTemperatureTB.Text, out double temperature))
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
            }
            catch (Exception ex) {
                MessageBox.Show($"设备启动异常：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void deviceStopBT_Click(object sender, EventArgs e)
        {
            try { 
                await _monitoring.DeviceStopAsync();            
            } catch (Exception ex) {
                MessageBox.Show($"设备停止异常：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void getConnectPLCBT_Click(object sender, EventArgs e)
        {
            try
            {
                await _monitoring.GetConnectAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"设备连接异常：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void lostConnectPLCBT_Click(object sender, EventArgs e)
        {
            try
            {
                await _monitoring.LostConnectAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"设备断开异常：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchHistoryBT_Click(object sender, EventArgs e)
        {

        }
    }
}
