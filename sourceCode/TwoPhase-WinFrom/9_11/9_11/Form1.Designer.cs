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
            deviceControlLB = new AntdUI.Label();
            LogOutputPN = new AntdUI.Panel();
            LogOutputLB = new AntdUI.Label();
            dataRecordsPN = new AntdUI.Panel();
            dataRecordsLB = new AntdUI.Label();
            listenerPainPN = new AntdUI.Panel();
            label8listenerPainLB = new AntdUI.Label();
            linkControlPN = new AntdUI.Panel();
            linkControlLB = new AntdUI.Label();
            currentStatusLB = new AntdUI.Label();
            TCBMMLB = new AntdUI.Label();
            dataRecordsTB = new AntdUI.Table();
            linkPLCBT = new AntdUI.Button();
            lostPLCBT = new AntdUI.Button();
            deviceStopBT = new AntdUI.Button();
            deviceStartBT = new AntdUI.Button();
            setTemperatureBT = new AntdUI.Button();
            setTemperatureTB = new AntdUI.Input();
            loginPN = new AntdUI.Panel();
            linkStatusLB = new AntdUI.Label();
            searchHistoryBT = new AntdUI.Button();
            mainPanel.SuspendLayout();
            deviceControlPN.SuspendLayout();
            LogOutputPN.SuspendLayout();
            dataRecordsPN.SuspendLayout();
            listenerPainPN.SuspendLayout();
            linkControlPN.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BorderWidth = 2F;
            mainPanel.Controls.Add(deviceControlPN);
            mainPanel.Controls.Add(LogOutputPN);
            mainPanel.Controls.Add(dataRecordsPN);
            mainPanel.Controls.Add(listenerPainPN);
            mainPanel.Controls.Add(linkControlPN);
            mainPanel.Controls.Add(TCBMMLB);
            mainPanel.Location = new Point(28, 26);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(964, 469);
            mainPanel.TabIndex = 0;
            mainPanel.Text = "panel1";
            // 
            // deviceControlPN
            // 
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
            // LogOutputPN
            // 
            LogOutputPN.BorderWidth = 1F;
            LogOutputPN.Controls.Add(loginPN);
            LogOutputPN.Controls.Add(LogOutputLB);
            LogOutputPN.Location = new Point(478, 245);
            LogOutputPN.Name = "LogOutputPN";
            LogOutputPN.Size = new Size(473, 224);
            LogOutputPN.TabIndex = 2;
            LogOutputPN.Text = "panel2";
            // 
            // LogOutputLB
            // 
            LogOutputLB.Dock = DockStyle.Top;
            LogOutputLB.Location = new Point(2, 2);
            LogOutputLB.Name = "LogOutputLB";
            LogOutputLB.Size = new Size(469, 38);
            LogOutputLB.TabIndex = 2;
            LogOutputLB.Text = "日志输出区";
            LogOutputLB.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataRecordsPN
            // 
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
            listenerPainPN.BorderWidth = 1F;
            listenerPainPN.Controls.Add(label8listenerPainLB);
            listenerPainPN.Location = new Point(321, 50);
            listenerPainPN.Name = "listenerPainPN";
            listenerPainPN.Size = new Size(313, 189);
            listenerPainPN.TabIndex = 2;
            listenerPainPN.Text = "panel2";
            // 
            // label8listenerPainLB
            // 
            label8listenerPainLB.Dock = DockStyle.Top;
            label8listenerPainLB.Location = new Point(2, 2);
            label8listenerPainLB.Name = "label8listenerPainLB";
            label8listenerPainLB.Size = new Size(309, 38);
            label8listenerPainLB.TabIndex = 2;
            label8listenerPainLB.Text = "监控画面区";
            label8listenerPainLB.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // linkControlPN
            // 
            linkControlPN.BorderWidth = 1F;
            linkControlPN.Controls.Add(lostPLCBT);
            linkControlPN.Controls.Add(linkPLCBT);
            linkControlPN.Controls.Add(linkControlLB);
            linkControlPN.Controls.Add(linkStatusLB);
            linkControlPN.Controls.Add(currentStatusLB);
            linkControlPN.Location = new Point(6, 50);
            linkControlPN.Name = "linkControlPN";
            linkControlPN.Size = new Size(309, 189);
            linkControlPN.TabIndex = 2;
            linkControlPN.Text = "panel2";
            // 
            // linkControlLB
            // 
            linkControlLB.Dock = DockStyle.Top;
            linkControlLB.Location = new Point(2, 2);
            linkControlLB.Name = "linkControlLB";
            linkControlLB.Size = new Size(305, 38);
            linkControlLB.TabIndex = 2;
            linkControlLB.Text = "连接控制区";
            linkControlLB.TextAlign = ContentAlignment.MiddleCenter;
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
            // dataRecordsTB
            // 
            dataRecordsTB.Gap = 12;
            dataRecordsTB.Location = new Point(2, 44);
            dataRecordsTB.Name = "dataRecordsTB";
            dataRecordsTB.Size = new Size(459, 174);
            dataRecordsTB.TabIndex = 4;
            dataRecordsTB.Text = "table1";
            // 
            // linkPLCBT
            // 
            linkPLCBT.BorderWidth = 1F;
            linkPLCBT.Location = new Point(29, 46);
            linkPLCBT.Name = "linkPLCBT";
            linkPLCBT.Size = new Size(120, 53);
            linkPLCBT.TabIndex = 3;
            linkPLCBT.Text = "连接PLC";
            // 
            // lostPLCBT
            // 
            lostPLCBT.BorderWidth = 1F;
            lostPLCBT.Location = new Point(155, 46);
            lostPLCBT.Name = "lostPLCBT";
            lostPLCBT.Size = new Size(120, 53);
            lostPLCBT.TabIndex = 3;
            lostPLCBT.Text = "断开PLC";
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
            // setTemperatureBT
            // 
            setTemperatureBT.BorderWidth = 1F;
            setTemperatureBT.Location = new Point(191, 114);
            setTemperatureBT.Name = "setTemperatureBT";
            setTemperatureBT.Size = new Size(96, 53);
            setTemperatureBT.TabIndex = 4;
            setTemperatureBT.Text = "设定温度";
            // 
            // setTemperatureTB
            // 
            setTemperatureTB.Location = new Point(25, 114);
            setTemperatureTB.Name = "setTemperatureTB";
            setTemperatureTB.PlaceholderText = "请输入设定温度";
            setTemperatureTB.Size = new Size(160, 53);
            setTemperatureTB.TabIndex = 6;
            // 
            // loginPN
            // 
            loginPN.BorderWidth = 1F;
            loginPN.Location = new Point(5, 44);
            loginPN.Name = "loginPN";
            loginPN.Size = new Size(463, 175);
            loginPN.TabIndex = 3;
            loginPN.Text = "panel7";
            // 
            // linkStatusLB
            // 
            linkStatusLB.Location = new Point(135, 114);
            linkStatusLB.Name = "linkStatusLB";
            linkStatusLB.Size = new Size(90, 38);
            linkStatusLB.TabIndex = 1;
            linkStatusLB.Text = "未连接";
            linkStatusLB.TextAlign = ContentAlignment.MiddleCenter;
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
            LogOutputPN.ResumeLayout(false);
            dataRecordsPN.ResumeLayout(false);
            listenerPainPN.ResumeLayout(false);
            linkControlPN.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private AntdUI.Panel mainPanel;
        private AntdUI.Panel linkControlPN;
        private AntdUI.Label currentStatusLB;
        private AntdUI.Label TCBMMLB;
        private AntdUI.Panel deviceControlPN;
        private AntdUI.Label deviceControlLB;
        private AntdUI.Panel LogOutputPN;
        private AntdUI.Label LogOutputLB;
        private AntdUI.Panel dataRecordsPN;
        private AntdUI.Panel listenerPainPN;
        private AntdUI.Label label8listenerPainLB;
        private AntdUI.Label linkControlLB;
        private AntdUI.Label dataRecordsLB;
        private AntdUI.Table dataRecordsTB;
        private AntdUI.Button lostPLCBT;
        private AntdUI.Button linkPLCBT;
        private AntdUI.Input setTemperatureTB;
        private AntdUI.Button setTemperatureBT;
        private AntdUI.Button deviceStopBT;
        private AntdUI.Button deviceStartBT;
        private AntdUI.Panel loginPN;
        private AntdUI.Label linkStatusLB;
        private AntdUI.Button searchHistoryBT;
    }
}
