using _9_11.Application.Abstractions;
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

        public MainForm(IMonitoringService monitoring)
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
    }
}
