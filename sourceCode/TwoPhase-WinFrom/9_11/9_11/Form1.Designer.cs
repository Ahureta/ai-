namespace _9_11
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainPanel = new AntdUI.Panel();
            deviceControlPN = new AntdUI.Panel();
            setTemperatureTB = new AntdUI.Input();
            setTemperatureBT = new AntdUI.Button();
            deviceStopBT = new AntdUI.Button();
            deviceStartBT = new AntdUI.Button();
            deviceControlLB = new AntdUI.Label();
            logOutputPN = new AntdUI.Panel();
            loggingPN = new AntdUI.Panel();
            logOutputLB = new AntdUI.Label();
            dataRecordsPN = new AntdUI.Panel();
            searchHistoryBT = new AntdUI.Button();
            dataRecordsTB = new AntdUI.Table();
            dataRecordsLB = new AntdUI.Label();
            listenerPainPN = new AntdUI.Panel();
            listenerPainLB = new AntdUI.Label();
            connectControlPN = new AntdUI.Panel();
            lostConnectPLCBT = new AntdUI.Button();
            getConnectPLCBT = new AntdUI.Button();
            connectControlLB = new AntdUI.Label();
            connectStatusLB = new AntdUI.Label();
            currentStatusLB = new AntdUI.Label();
            TCBMMLB = new AntdUI.Label();
            mainPanel.SuspendLayout();
            deviceControlPN.SuspendLayout();
            logOutputPN.SuspendLayout();
            dataRecordsPN.SuspendLayout();
            listenerPainPN.SuspendLayout();
            connectControlPN.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            mainPanel.BorderWidth = 2F;
            mainPanel.Controls.Add(deviceControlPN);
            mainPanel.Controls.Add(logOutputPN);
            mainPanel.Controls.Add(dataRecordsPN);
            mainPanel.Controls.Add(listenerPainPN);
            mainPanel.Controls.Add(connectControlPN);
            mainPanel.Controls.Add(TCBMMLB);
            mainPanel.Location = new Point(28, 26);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(964, 469);
            mainPanel.TabIndex = 0;
            mainPanel.Text = "panel1";
            // 
            // deviceControlPN
            // 
            deviceControlPN.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            deviceControlPN.BorderWidth = 1F;
            deviceControlPN.Controls.Add(setTemperatureTB);
            deviceControlPN.Controls.Add(setTemperatureBT);
            deviceControlPN.Controls.Add(deviceStopBT);
            deviceControlPN.Controls.Add(deviceStartBT);
            deviceControlPN.Controls.Add(deviceControlLB);
            deviceControlPN.Location = new Point(640, 50);
            deviceControlPN.Name = "deviceControlPN";
            deviceControlPN.Size = new Size(311, 189);
            deviceControlPN.TabIndex = 2;
            deviceControlPN.Text = "panel2";
            // 
            // setTemperatureTB
            // 
            setTemperatureTB.Location = new Point(25, 114);
            setTemperatureTB.Name = "setTemperatureTB";
            setTemperatureTB.PlaceholderText = "请输入设定温度";
            setTemperatureTB.Size = new Size(160, 53);
            setTemperatureTB.TabIndex = 6;
            // 
            // setTemperatureBT
            // 
            setTemperatureBT.BorderWidth = 1F;
            setTemperatureBT.Location = new Point(191, 114);
            setTemperatureBT.Name = "setTemperatureBT";
            setTemperatureBT.Size = new Size(96, 53);
            setTemperatureBT.TabIndex = 4;
            setTemperatureBT.Text = "设定温度";
            // 
            // deviceStopBT
            // 
            deviceStopBT.BorderWidth = 1F;
            deviceStopBT.Location = new Point(167, 46);
            deviceStopBT.Name = "deviceStopBT";
            deviceStopBT.Size = new Size(120, 53);
            deviceStopBT.TabIndex = 4;
            deviceStopBT.Text = "停止";
            // 
            // deviceStartBT
            // 
            deviceStartBT.BorderWidth = 1F;
            deviceStartBT.Location = new Point(25, 46);
            deviceStartBT.Name = "deviceStartBT";
            deviceStartBT.Size = new Size(120, 53);
            deviceStartBT.TabIndex = 5;
            deviceStartBT.Text = "启动";
            // 
            // deviceControlLB
            // 
            deviceControlLB.Dock = DockStyle.Top;
            deviceControlLB.Location = new Point(2, 2);
            deviceControlLB.Name = "deviceControlLB";
            deviceControlLB.Size = new Size(307, 38);
            deviceControlLB.TabIndex = 2;
            deviceControlLB.Text = "设备控制区";
            deviceControlLB.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // logOutputPN
            // 
            logOutputPN.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            logOutputPN.BorderWidth = 1F;
            logOutputPN.Controls.Add(loggingPN);
            logOutputPN.Controls.Add(logOutputLB);
            logOutputPN.Location = new Point(478, 245);
            logOutputPN.Name = "logOutputPN";
            logOutputPN.Size = new Size(473, 224);
            logOutputPN.TabIndex = 2;
            logOutputPN.Text = "panel2";
            // 
            // loggingPN
            // 
            loggingPN.AutoScroll = true;
            loggingPN.BorderWidth = 1F;
            loggingPN.Location = new Point(5, 44);
            loggingPN.Name = "loggingPN";
            loggingPN.Size = new Size(463, 177);
            loggingPN.TabIndex = 3;
            loggingPN.Text = "panel7";
            // 
            // logOutputLB
            // 
            logOutputLB.Dock = DockStyle.Top;
            logOutputLB.Location = new Point(2, 2);
            logOutputLB.Name = "logOutputLB";
            logOutputLB.Size = new Size(469, 38);
            logOutputLB.TabIndex = 2;
            logOutputLB.Text = "日志输出区";
            logOutputLB.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataRecordsPN
            // 
            dataRecordsPN.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            dataRecordsPN.BorderWidth = 1F;
            dataRecordsPN.Controls.Add(searchHistoryBT);
            dataRecordsPN.Controls.Add(dataRecordsTB);
            dataRecordsPN.Controls.Add(dataRecordsLB);
            dataRecordsPN.Location = new Point(6, 245);
            dataRecordsPN.Name = "dataRecordsPN";
            dataRecordsPN.Size = new Size(466, 221);
            dataRecordsPN.TabIndex = 2;
            dataRecordsPN.Text = "panel2";
            // 
            // searchHistoryBT
            // 
            searchHistoryBT.BorderWidth = 1F;
            searchHistoryBT.Location = new Point(317, 0);
            searchHistoryBT.Name = "searchHistoryBT";
            searchHistoryBT.Size = new Size(144, 40);
            searchHistoryBT.TabIndex = 3;
            searchHistoryBT.Text = "查看历史记录";
            // 
            // dataRecordsTB
            // 
            dataRecordsTB.Gap = 12;
            dataRecordsTB.Location = new Point(2, 44);
            dataRecordsTB.Name = "dataRecordsTB";
            dataRecordsTB.Size = new Size(459, 174);
            dataRecordsTB.TabIndex = 4;
            dataRecordsTB.Text = "table1";
            // 
            // dataRecordsLB
            // 
            dataRecordsLB.Dock = DockStyle.Top;
            dataRecordsLB.Location = new Point(2, 2);
            dataRecordsLB.Name = "dataRecordsLB";
            dataRecordsLB.Size = new Size(462, 38);
            dataRecordsLB.TabIndex = 2;
            dataRecordsLB.Text = "数据记录区";
            dataRecordsLB.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // listenerPainPN
            // 
            listenerPainPN.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            listenerPainPN.BorderWidth = 1F;
            listenerPainPN.Controls.Add(listenerPainLB);
            listenerPainPN.Location = new Point(321, 50);
            listenerPainPN.Name = "listenerPainPN";
            listenerPainPN.Size = new Size(313, 189);
            listenerPainPN.TabIndex = 2;
            listenerPainPN.Text = "panel2";
            // 
            // listenerPainLB
            // 
            listenerPainLB.Dock = DockStyle.Top;
            listenerPainLB.Location = new Point(2, 2);
            listenerPainLB.Name = "listenerPainLB";
            listenerPainLB.Size = new Size(309, 38);
            listenerPainLB.TabIndex = 2;
            listenerPainLB.Text = "监控画面区";
            listenerPainLB.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // connectControlPN
            // 
            connectControlPN.BorderStyle = System.Drawing.Drawing2D.DashStyle.Custom;
            connectControlPN.BorderWidth = 1F;
            connectControlPN.Controls.Add(lostConnectPLCBT);
            connectControlPN.Controls.Add(getConnectPLCBT);
            connectControlPN.Controls.Add(connectControlLB);
            connectControlPN.Controls.Add(connectStatusLB);
            connectControlPN.Controls.Add(currentStatusLB);
            connectControlPN.Location = new Point(6, 50);
            connectControlPN.Name = "connectControlPN";
            connectControlPN.Size = new Size(309, 189);
            connectControlPN.TabIndex = 2;
            connectControlPN.Text = "panel2";
            // 
            // lostConnectPLCBT
            // 
            lostConnectPLCBT.BorderWidth = 1F;
            lostConnectPLCBT.Location = new Point(155, 46);
            lostConnectPLCBT.Name = "lostConnectPLCBT";
            lostConnectPLCBT.Size = new Size(120, 53);
            lostConnectPLCBT.TabIndex = 3;
            lostConnectPLCBT.Text = "断开PLC";
            // 
            // getConnectPLCBT
            // 
            getConnectPLCBT.BorderWidth = 1F;
            getConnectPLCBT.Location = new Point(29, 46);
            getConnectPLCBT.Name = "getConnectPLCBT";
            getConnectPLCBT.Size = new Size(120, 53);
            getConnectPLCBT.TabIndex = 3;
            getConnectPLCBT.Text = "连接PLC";
            // 
            // connectControlLB
            // 
            connectControlLB.Dock = DockStyle.Top;
            connectControlLB.Location = new Point(2, 2);
            connectControlLB.Name = "connectControlLB";
            connectControlLB.Size = new Size(305, 38);
            connectControlLB.TabIndex = 2;
            connectControlLB.Text = "连接控制区";
            connectControlLB.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // connectStatusLB
            // 
            connectStatusLB.Location = new Point(135, 114);
            connectStatusLB.Name = "connectStatusLB";
            connectStatusLB.Size = new Size(90, 38);
            connectStatusLB.TabIndex = 1;
            connectStatusLB.Text = "未连接";
            connectStatusLB.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // currentStatusLB
            // 
            currentStatusLB.Location = new Point(39, 114);
            currentStatusLB.Name = "currentStatusLB";
            currentStatusLB.Size = new Size(90, 38);
            currentStatusLB.TabIndex = 1;
            currentStatusLB.Text = "当前状态:";
            currentStatusLB.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TCBMMLB
            // 
            TCBMMLB.Dock = DockStyle.Top;
            TCBMMLB.Location = new Point(3, 3);
            TCBMMLB.Name = "TCBMMLB";
            TCBMMLB.Size = new Size(958, 38);
            TCBMMLB.TabIndex = 0;
            TCBMMLB.Text = "温控设备监控主页面";
            TCBMMLB.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 538);
            Controls.Add(mainPanel);
            Name = "Form1";
            Text = "Form1";
            mainPanel.ResumeLayout(false);
            deviceControlPN.ResumeLayout(false);
            logOutputPN.ResumeLayout(false);
            dataRecordsPN.ResumeLayout(false);
            listenerPainPN.ResumeLayout(false);
            connectControlPN.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Panel mainPanel;
        private AntdUI.Panel connectControlPN;
        private AntdUI.Label currentStatusLB;
        private AntdUI.Label TCBMMLB;
        private AntdUI.Panel deviceControlPN;
        private AntdUI.Label deviceControlLB;
        private AntdUI.Panel logOutputPN;
        private AntdUI.Label logOutputLB;
        private AntdUI.Panel dataRecordsPN;
        private AntdUI.Panel listenerPainPN;
        private AntdUI.Label listenerPainLB;
        private AntdUI.Label connectControlLB;
        private AntdUI.Label dataRecordsLB;
        private AntdUI.Table dataRecordsTB;
        private AntdUI.Button lostConnectPLCBT;
        private AntdUI.Button getConnectPLCBT;
        private AntdUI.Input setTemperatureTB;
        private AntdUI.Button setTemperatureBT;
        private AntdUI.Button deviceStopBT;
        private AntdUI.Button deviceStartBT;
        private AntdUI.Panel loggingPN;
        private AntdUI.Label connectStatusLB;
        private AntdUI.Button searchHistoryBT;
    }
}
