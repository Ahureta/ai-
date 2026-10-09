namespace IndustrialVisionSort.ui.Forms
{
    partial class IndustrialVisionSortingSystem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AntdUI.MenuItem menuItem1 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem2 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem3 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem4 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem5 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem6 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem7 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem8 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem9 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem10 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem11 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem12 = new AntdUI.MenuItem();
            AntdUI.MenuItem menuItem13 = new AntdUI.MenuItem();
            this.panel1 = new AntdUI.In.Panel();
            this.LBTitle = new AntdUI.Label();
            this.PNView = new AntdUI.In.Panel();
            this.menu = new AntdUI.Menu();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.LBTitle);
            this.panel1.Controls.Add(this.PNView);
            this.panel1.Controls.Add(this.menu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1582, 853);
            this.panel1.TabIndex = 1;
            this.panel1.Text = "panel1";
            // 
            // LBTitle
            // 
            this.LBTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBTitle.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LBTitle.Location = new System.Drawing.Point(167, 0);
            this.LBTitle.Name = "LBTitle";
            this.LBTitle.Size = new System.Drawing.Size(1415, 69);
            this.LBTitle.TabIndex = 3;
            this.LBTitle.Text = "LBTitle";
            // 
            // PNView
            // 
            this.PNView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PNView.Location = new System.Drawing.Point(167, 75);
            this.PNView.Name = "PNView";
            this.PNView.Size = new System.Drawing.Size(1415, 778);
            this.PNView.TabIndex = 2;
            // 
            // menu
            // 
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            menuItem1.Name = "Main";
            menuItem1.Select = true;
            menuItem1.Text = "主运行页";
            menuItem2.Expand = false;
            menuItem2.Name = "SystemSetting";
            menuItem3.Name = "ModbusConfig";
            menuItem3.SubText = "ModbusConfig";
            menuItem3.Text = "Modbus传送带配置";
            menuItem4.Name = "RobotConfig";
            menuItem4.SubText = "RobotConfig";
            menuItem4.Text = "机械臂配置";
            menuItem5.Name = "VisionParamConfig";
            menuItem5.SubText = "VisionParamConfig";
            menuItem5.Text = "视觉参数配置";
            menuItem6.Name = "SQLConfig";
            menuItem6.SubText = "SQLConfig";
            menuItem6.Text = "数据库配置";
            menuItem2.Sub.Add(menuItem3);
            menuItem2.Sub.Add(menuItem4);
            menuItem2.Sub.Add(menuItem5);
            menuItem2.Sub.Add(menuItem6);
            menuItem2.Text = "系统设置页";
            menuItem7.Expand = false;
            menuItem7.Name = "VisionConfig";
            menuItem8.Name = "CameraSetting";
            menuItem8.SubText = "CameraSetting";
            menuItem8.Text = "相机设置";
            menuItem9.Name = "ImageSaveConfig";
            menuItem9.SubText = "ImageSaveConfig";
            menuItem9.Text = "图像保存设置";
            menuItem10.Name = "PMATemplateTraining";
            menuItem10.SubText = "PMATemplateTraining";
            menuItem10.Text = "PMA模板训练";
            menuItem11.Name = "VPPPlan";
            menuItem11.SubText = "VPPPlan";
            menuItem11.Text = "VPP方案";
            menuItem7.Sub.Add(menuItem8);
            menuItem7.Sub.Add(menuItem9);
            menuItem7.Sub.Add(menuItem10);
            menuItem7.Sub.Add(menuItem11);
            menuItem7.Text = "视觉配置";
            menuItem12.Expand = false;
            menuItem12.Name = "DeviceDebug";
            menuItem12.Text = "设备调试页";
            menuItem13.Expand = false;
            menuItem13.Name = "log";
            menuItem13.Text = "数据日志页";
            this.menu.Items.Add(menuItem1);
            this.menu.Items.Add(menuItem2);
            this.menu.Items.Add(menuItem7);
            this.menu.Items.Add(menuItem12);
            this.menu.Items.Add(menuItem13);
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(167, 853);
            this.menu.TabIndex = 0;
            this.menu.Text = "menu";
            this.menu.Trigger = AntdUI.Trigger.Click;
            this.menu.Unique = true;
            // 
            // IndustrialVisionSortingSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1582, 853);
            this.Controls.Add(this.panel1);
            this.Name = "IndustrialVisionSortingSystem";
            this.Text = "IndustrialVisionSortingSystem";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.In.Panel panel1;
        private AntdUI.Menu menu;
        private AntdUI.In.Panel PNView;
        private AntdUI.Label LBTitle;
    }
}