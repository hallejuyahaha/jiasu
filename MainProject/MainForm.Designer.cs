namespace WitiVelocity
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSystemInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timedisplay = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmenuMonitor = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.neoTabWindow1 = new NeoTabControlLibrary.NeoTabWindow();
            this.neoTabPageSys = new NeoTabControlLibrary.NeoTabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.runningFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblContrlStatus = new System.Windows.Forms.Label();
            this.btControl = new JCS.ToggleSwitch();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblGPULine2 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lblGPULine1 = new System.Windows.Forms.Label();
            this.neoTabPageOpt = new NeoTabControlLibrary.NeoTabPage();
            this.MonitorFlowLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.lblMonitorGroup = new System.Windows.Forms.Label();
            this.ckbMinimize = new System.Windows.Forms.CheckBox();
            this.ckbRunOnStart = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.neoTabPageAbout = new NeoTabControlLibrary.NeoTabPage();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblIssueDate = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblCompany = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.neoTabPage1 = new NeoTabControlLibrary.NeoTabPage();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.contextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.neoTabWindow1)).BeginInit();
            this.neoTabWindow1.SuspendLayout();
            this.neoTabPageSys.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.neoTabPageOpt.SuspendLayout();
            this.neoTabPageAbout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(181)))), ((int)(((byte)(174)))));
            this.panel1.Controls.Add(this.lblSystemInfo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1007, 115);
            this.panel1.TabIndex = 1;
            // 
            // lblSystemInfo
            // 
            this.lblSystemInfo.AutoSize = true;
            this.lblSystemInfo.Font = new System.Drawing.Font("微软雅黑", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSystemInfo.ForeColor = System.Drawing.Color.White;
            this.lblSystemInfo.Location = new System.Drawing.Point(477, 24);
            this.lblSystemInfo.Name = "lblSystemInfo";
            this.lblSystemInfo.Size = new System.Drawing.Size(527, 38);
            this.lblSystemInfo.TabIndex = 3;
            this.lblSystemInfo.Text = "维拓图形中心——全球领先的GaaS平台";
            this.lblSystemInfo.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(133, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "v1.0(64-bit)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(131, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "Witsoft iVelocity";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Wit.ivelocity.Properties.Resources.acce;
            this.pictureBox1.Location = new System.Drawing.Point(25, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timedisplay
            // 
            this.timedisplay.Enabled = true;
            this.timedisplay.Interval = 1000;
            this.timedisplay.Tick += new System.EventHandler(this.timedisplay_Tick);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Wit iVelocity";
            this.notifyIcon.Visible = true;
            this.notifyIcon.DoubleClick += new System.EventHandler(this.reoopenWindow);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.tsmenuMonitor,
            this.toolStripSeparator1,
            this.toolStripMenuItem3,
            this.toolStripSeparator2,
            this.toolStripMenuItem4});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(149, 104);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem1.Text = "打开iVelocity";
            this.toolStripMenuItem1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem1.Click += new System.EventHandler(this.reoopenWindow);
            // 
            // tsmenuMonitor
            // 
            this.tsmenuMonitor.CheckOnClick = true;
            this.tsmenuMonitor.Name = "tsmenuMonitor";
            this.tsmenuMonitor.Size = new System.Drawing.Size(148, 22);
            this.tsmenuMonitor.Text = "启用加速";
            this.tsmenuMonitor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.tsmenuMonitor.CheckedChanged += new System.EventHandler(this.tsmenuMonitor_CheckedChanged);
            this.tsmenuMonitor.Click += new System.EventHandler(this.tsmenuMonitor_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(145, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem3.Text = "关于维拓";
            this.toolStripMenuItem3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem3.Click += new System.EventHandler(this.openWitsoftWebPage);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(145, 6);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(148, 22);
            this.toolStripMenuItem4.Text = "退出";
            this.toolStripMenuItem4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem4.Click += new System.EventHandler(this.exitProgram);
            // 
            // neoTabWindow1
            // 
            this.neoTabWindow1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.neoTabWindow1.Controls.Add(this.neoTabPageSys);
            this.neoTabWindow1.Controls.Add(this.neoTabPageOpt);
            this.neoTabWindow1.Controls.Add(this.neoTabPageAbout);
            this.neoTabWindow1.Controls.Add(this.neoTabPage1);
            this.neoTabWindow1.Location = new System.Drawing.Point(0, 115);
            this.neoTabWindow1.Name = "neoTabWindow1";
            this.neoTabWindow1.RendererName = "CCleanerRenderer";
            this.neoTabWindow1.SelectedIndex = 3;
            this.neoTabWindow1.Size = new System.Drawing.Size(1004, 652);
            this.neoTabWindow1.TabIndex = 0;
            this.neoTabWindow1.SelectedIndexChanged += new System.EventHandler<NeoTabControlLibrary.SelectedIndexChangedEventArgs>(this.neoTabWindow1_SelectedIndexChanged);
            // 
            // neoTabPageSys
            // 
            this.neoTabPageSys.BackColor = System.Drawing.Color.White;
            this.neoTabPageSys.Controls.Add(this.groupBox3);
            this.neoTabPageSys.Controls.Add(this.groupBox2);
            this.neoTabPageSys.Controls.Add(this.groupBox1);
            this.neoTabPageSys.IsCloseable = false;
            this.neoTabPageSys.Name = "neoTabPageSys";
            this.neoTabPageSys.Text = "系统";
            this.neoTabPageSys.ToolTipText = "neoTabPage1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.runningFlowLayout);
            this.groupBox3.Font = new System.Drawing.Font("新宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(181)))), ((int)(((byte)(174)))));
            this.groupBox3.Location = new System.Drawing.Point(21, 308);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(958, 240);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "当前运行";
            // 
            // runningFlowLayout
            // 
            this.runningFlowLayout.AutoScroll = true;
            this.runningFlowLayout.Font = new System.Drawing.Font("宋体", 12F);
            this.runningFlowLayout.ForeColor = System.Drawing.SystemColors.WindowText;
            this.runningFlowLayout.Location = new System.Drawing.Point(6, 25);
            this.runningFlowLayout.Name = "runningFlowLayout";
            this.runningFlowLayout.Size = new System.Drawing.Size(946, 209);
            this.runningFlowLayout.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblContrlStatus);
            this.groupBox2.Controls.Add(this.btControl);
            this.groupBox2.Font = new System.Drawing.Font("新宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(181)))), ((int)(((byte)(174)))));
            this.groupBox2.Location = new System.Drawing.Point(21, 180);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(958, 113);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "控制台";
            // 
            // lblContrlStatus
            // 
            this.lblContrlStatus.AutoSize = true;
            this.lblContrlStatus.Font = new System.Drawing.Font("宋体", 12F);
            this.lblContrlStatus.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblContrlStatus.Location = new System.Drawing.Point(32, 76);
            this.lblContrlStatus.Name = "lblContrlStatus";
            this.lblContrlStatus.Size = new System.Drawing.Size(56, 16);
            this.lblContrlStatus.TabIndex = 1;
            this.lblContrlStatus.Text = "status";
            // 
            // btControl
            // 
            this.btControl.Location = new System.Drawing.Point(30, 32);
            this.btControl.Name = "btControl";
            this.btControl.OffFont = new System.Drawing.Font("宋体", 12F);
            this.btControl.OffForeColor = System.Drawing.Color.White;
            this.btControl.OffText = "关";
            this.btControl.OnFont = new System.Drawing.Font("宋体", 12F);
            this.btControl.OnForeColor = System.Drawing.Color.White;
            this.btControl.OnText = "开";
            this.btControl.Size = new System.Drawing.Size(97, 37);
            this.btControl.Style = JCS.ToggleSwitch.ToggleSwitchStyle.Fancy;
            this.btControl.TabIndex = 0;
            this.btControl.CheckedChanged += new JCS.ToggleSwitch.CheckedChangedDelegate(this.toggleSwitch1_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblGPULine2);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.lblGPULine1);
            this.groupBox1.Font = new System.Drawing.Font("新宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(181)))), ((int)(((byte)(174)))));
            this.groupBox1.Location = new System.Drawing.Point(21, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(958, 113);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "图形加速卡";
            // 
            // lblGPULine2
            // 
            this.lblGPULine2.AutoSize = true;
            this.lblGPULine2.Font = new System.Drawing.Font("宋体", 12F);
            this.lblGPULine2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblGPULine2.Location = new System.Drawing.Point(159, 72);
            this.lblGPULine2.Name = "lblGPULine2";
            this.lblGPULine2.Size = new System.Drawing.Size(96, 16);
            this.lblGPULine2.TabIndex = 2;
            this.lblGPULine2.Text = "lblGPULine2";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Wit.ivelocity.Properties.Resources.NVIDIA_logo;
            this.pictureBox3.Location = new System.Drawing.Point(32, 23);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 82);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // lblGPULine1
            // 
            this.lblGPULine1.AutoSize = true;
            this.lblGPULine1.Font = new System.Drawing.Font("宋体", 12F);
            this.lblGPULine1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblGPULine1.Location = new System.Drawing.Point(159, 37);
            this.lblGPULine1.Name = "lblGPULine1";
            this.lblGPULine1.Size = new System.Drawing.Size(96, 16);
            this.lblGPULine1.TabIndex = 0;
            this.lblGPULine1.Text = "lblGPULine1";
            // 
            // neoTabPageOpt
            // 
            this.neoTabPageOpt.BackColor = System.Drawing.Color.White;
            this.neoTabPageOpt.Controls.Add(this.MonitorFlowLayout);
            this.neoTabPageOpt.Controls.Add(this.lblMonitorGroup);
            this.neoTabPageOpt.Controls.Add(this.ckbMinimize);
            this.neoTabPageOpt.Controls.Add(this.ckbRunOnStart);
            this.neoTabPageOpt.Controls.Add(this.label15);
            this.neoTabPageOpt.Name = "neoTabPageOpt";
            this.neoTabPageOpt.Text = "选项";
            this.neoTabPageOpt.ToolTipText = "neoTabPage1";
            // 
            // MonitorFlowLayout
            // 
            this.MonitorFlowLayout.Location = new System.Drawing.Point(44, 161);
            this.MonitorFlowLayout.Name = "MonitorFlowLayout";
            this.MonitorFlowLayout.Size = new System.Drawing.Size(838, 150);
            this.MonitorFlowLayout.TabIndex = 4;
            // 
            // lblMonitorGroup
            // 
            this.lblMonitorGroup.AutoSize = true;
            this.lblMonitorGroup.Font = new System.Drawing.Font("新宋体", 14F, System.Drawing.FontStyle.Bold);
            this.lblMonitorGroup.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(181)))), ((int)(((byte)(174)))));
            this.lblMonitorGroup.Location = new System.Drawing.Point(32, 114);
            this.lblMonitorGroup.Name = "lblMonitorGroup";
            this.lblMonitorGroup.Size = new System.Drawing.Size(93, 19);
            this.lblMonitorGroup.TabIndex = 3;
            this.lblMonitorGroup.Text = "监控程序";
            // 
            // ckbMinimize
            // 
            this.ckbMinimize.AutoSize = true;
            this.ckbMinimize.Font = new System.Drawing.Font("宋体", 12F);
            this.ckbMinimize.Location = new System.Drawing.Point(44, 70);
            this.ckbMinimize.Name = "ckbMinimize";
            this.ckbMinimize.Size = new System.Drawing.Size(155, 20);
            this.ckbMinimize.TabIndex = 2;
            this.ckbMinimize.Text = "最小化到系统托盘";
            this.ckbMinimize.UseVisualStyleBackColor = true;
            this.ckbMinimize.CheckedChanged += new System.EventHandler(this.setMinimizeToIconTray);
            // 
            // ckbRunOnStart
            // 
            this.ckbRunOnStart.AutoSize = true;
            this.ckbRunOnStart.Enabled = false;
            this.ckbRunOnStart.Font = new System.Drawing.Font("宋体", 12F);
            this.ckbRunOnStart.Location = new System.Drawing.Point(217, 70);
            this.ckbRunOnStart.Name = "ckbRunOnStart";
            this.ckbRunOnStart.Size = new System.Drawing.Size(171, 20);
            this.ckbRunOnStart.TabIndex = 1;
            this.ckbRunOnStart.Text = "系统启动时自动运行";
            this.ckbRunOnStart.UseVisualStyleBackColor = true;
            this.ckbRunOnStart.Visible = false;
            this.ckbRunOnStart.CheckedChanged += new System.EventHandler(this.ckbRunOnStart_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("新宋体", 14F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(181)))), ((int)(((byte)(174)))));
            this.label15.Location = new System.Drawing.Point(32, 34);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(93, 19);
            this.label15.TabIndex = 0;
            this.label15.Text = "基本设置";
            // 
            // neoTabPageAbout
            // 
            this.neoTabPageAbout.BackColor = System.Drawing.Color.White;
            this.neoTabPageAbout.Controls.Add(this.lblEndDate);
            this.neoTabPageAbout.Controls.Add(this.label4);
            this.neoTabPageAbout.Controls.Add(this.linkLabel1);
            this.neoTabPageAbout.Controls.Add(this.label14);
            this.neoTabPageAbout.Controls.Add(this.label13);
            this.neoTabPageAbout.Controls.Add(this.lblIssueDate);
            this.neoTabPageAbout.Controls.Add(this.label12);
            this.neoTabPageAbout.Controls.Add(this.lblCompany);
            this.neoTabPageAbout.Controls.Add(this.label9);
            this.neoTabPageAbout.Controls.Add(this.label8);
            this.neoTabPageAbout.Controls.Add(this.label7);
            this.neoTabPageAbout.Controls.Add(this.label5);
            this.neoTabPageAbout.Controls.Add(this.label6);
            this.neoTabPageAbout.Controls.Add(this.pictureBox2);
            this.neoTabPageAbout.Name = "neoTabPageAbout";
            this.neoTabPageAbout.Text = "关于";
            this.neoTabPageAbout.ToolTipText = "neoTabPage1";
            // 
            // lblEndDate
            // 
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("仿宋", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblEndDate.Location = new System.Drawing.Point(192, 258);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(139, 19);
            this.lblEndDate.TabIndex = 15;
            this.lblEndDate.Text = "2017年1月20日";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("仿宋", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(77, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 19);
            this.label4.TabIndex = 14;
            this.label4.Text = "授权到期：";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(153, 358);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(131, 12);
            this.linkLabel1.TabIndex = 13;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://www.witsoft.cn";
            this.linkLabel1.Click += new System.EventHandler(this.openWitsoftWebPage);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("仿宋", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(77, 352);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(69, 19);
            this.label14.TabIndex = 12;
            this.label14.Text = "网站：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("新宋体", 16F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(181)))), ((int)(((byte)(174)))));
            this.label13.Location = new System.Drawing.Point(49, 308);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 22);
            this.label13.TabIndex = 11;
            this.label13.Text = "关于维拓";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // lblIssueDate
            // 
            this.lblIssueDate.AutoSize = true;
            this.lblIssueDate.Font = new System.Drawing.Font("仿宋", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblIssueDate.Location = new System.Drawing.Point(192, 225);
            this.lblIssueDate.Name = "lblIssueDate";
            this.lblIssueDate.Size = new System.Drawing.Size(139, 19);
            this.lblIssueDate.TabIndex = 10;
            this.lblIssueDate.Text = "2017年1月20日";
            this.lblIssueDate.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("仿宋", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(77, 225);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 19);
            this.label12.TabIndex = 9;
            this.label12.Text = "授权日期：";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // lblCompany
            // 
            this.lblCompany.AutoSize = true;
            this.lblCompany.Font = new System.Drawing.Font("仿宋", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCompany.Location = new System.Drawing.Point(192, 190);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Size = new System.Drawing.Size(29, 19);
            this.lblCompany.TabIndex = 8;
            this.lblCompany.Text = "  ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("仿宋", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(77, 190);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 19);
            this.label9.TabIndex = 7;
            this.label9.Text = "授权：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新宋体", 16F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(181)))), ((int)(((byte)(174)))));
            this.label8.Location = new System.Drawing.Point(49, 149);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 22);
            this.label8.TabIndex = 6;
            this.label8.Text = "授权信息";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(204, 90);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(172, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Copyright © 2005-2016";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(204, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "v1.0(64-bit)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(202, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Witsoft iVelocity";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Wit.ivelocity.Properties.Resources.acce2;
            this.pictureBox2.Location = new System.Drawing.Point(53, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(133, 98);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // neoTabPage1
            // 
            this.neoTabPage1.BackColor = System.Drawing.Color.Transparent;
            this.neoTabPage1.Name = "neoTabPage1";
            this.neoTabPage1.Text = "限核";
            this.neoTabPage1.ToolTipText = "neoTabPage1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 697);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.neoTabWindow1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Witsoft iVelocity";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.contextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.neoTabWindow1)).EndInit();
            this.neoTabWindow1.ResumeLayout(false);
            this.neoTabPageSys.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.neoTabPageOpt.ResumeLayout(false);
            this.neoTabPageOpt.PerformLayout();
            this.neoTabPageAbout.ResumeLayout(false);
            this.neoTabPageAbout.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private NeoTabControlLibrary.NeoTabWindow neoTabWindow1;
        private NeoTabControlLibrary.NeoTabPage neoTabPageSys;
        private System.Windows.Forms.Panel panel1;
        private NeoTabControlLibrary.NeoTabPage neoTabPageOpt;
        private NeoTabControlLibrary.NeoTabPage neoTabPageAbout;
        private System.Windows.Forms.Label lblSystemInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblIssueDate;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblCompany;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMonitorGroup;
        private System.Windows.Forms.CheckBox ckbMinimize;
        private System.Windows.Forms.CheckBox ckbRunOnStart;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblGPULine1;
        private JCS.ToggleSwitch btControl;
        private System.Windows.Forms.Label lblContrlStatus;
        private System.Windows.Forms.Timer timedisplay;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblGPULine2;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmenuMonitor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel MonitorFlowLayout;
        private System.Windows.Forms.FlowLayoutPanel runningFlowLayout;
        private NeoTabControlLibrary.NeoTabPage neoTabPage1;
    }
}