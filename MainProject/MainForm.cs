using IconWithLable;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Wit.ivelocity;
using Wit.ProcessMonitor;
using Wit.ProcessMonitor.Config;

namespace WitiVelocity
{
    public partial class MainForm : Form
    {
        private Monitor m;

        private const String REG_KEY_WITSOFT = "iVelocity";

        //RegistryKey rkApp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

        private bool minimizeToIconTray = false;

        private bool valid = false; 
        
        public MainForm()
        {
            InitializeComponent();
            InitializeDynamicComponent();
            Application.ApplicationExit += new EventHandler(this.OnApplicationExit);

            Wit.ivelocity.License license = Wit.ivelocity.License.Instance;
            valid = license.VerifyXmlDocument();
            
            

            lblCompany.Text = license.Company;
            lblIssueDate.Text = license.IssueDate.ToString("yyyy年MM月dd日");
            if (!license.EndDate.ToString("yyyyMMdd").Equals("00010101"))
            {
                lblEndDate.Text = license.EndDate.ToString("yyyy年MM月dd日");
            }
            else
            {
                lblEndDate.Text = "无期限";
            }



            String processorInfo = SystemInfo.getProcessorInfo();
            String memSize = Convert.ToString(SystemInfo.getTotalMem());
            String[] gpuinfos = SystemInfo.getGPUInfo();
            lblGPULine1.Text = gpuinfos[0];
            lblGPULine2.Text = gpuinfos[1];
            /////////////////
            if (lblGPULine1.Text.ToUpper().ToString().Substring(0,6) == "VNIDIA")
            {
                pictureBox3.Image = Wit.ivelocity.Properties.Resources.NVIDIA_logo;
            }
            else if (lblGPULine1.Text.ToUpper().ToString().Substring(0,3) == "AMD")
            {
                pictureBox3.Image = Wit.ivelocity.Properties.Resources.amd;
            }
            else if (lblGPULine1.Text.ToUpper().ToString().Substring(0,3) == "ATI")
            {
                pictureBox3.Image = Wit.ivelocity.Properties.Resources.ati;
            }
            else if(lblGPULine1.Text.ToUpper().ToString().Substring(0,5) == "INTEL")
            {
                pictureBox3.Image = Wit.ivelocity.Properties.Resources.intel;
            }
            else
            {
                pictureBox3.Image = Wit.ivelocity.Properties.Resources.other;
            }
           // lblSystemInfo.Text = SystemInfo.getOperatingSystemInfo();
            neoTabWindow1.Renderer = NeoTabControlLibrary.AddInRendererManager.LoadRenderer("CCleanerRenderer");
            m = new Monitor(true);
            m.StandardErrorOut += m_StandardErrorOut;
            m.StandardOut += m_StandardOut;

            lblContrlStatus.Text = "";
            btControl.Checked = false;
            //m.Start();

            //init opt page
            /**
            if (rkApp.GetValue(REG_KEY_WITSOFT) == null)
            {
                ckbRunOnStart.Checked = false;
            } else
            {
                ckbRunOnStart.Checked = true;
            }
            **/

            minimizeToIconTray = ConfigMananger.isMiniminimizeToIcontray();
            if (minimizeToIconTray)
            {
                ckbMinimize.Checked = true;
            }

            notifyIcon.BalloonTipTitle = "最小化到系统托盘";
            notifyIcon.BalloonTipText = "Witsoft iVelocity.";
            notifyIcon.Visible = false;



        }

        private void OnApplicationExit(object sender, EventArgs e)
        {
            PowCtrl.setCurrentPowerEnumerateVistaAPI(5);
        }

        private void InitializeDynamicComponent()
        {
            int offsetY = lblMonitorGroup.Location.Y+30;
            for (int i = 0; i < ConfigMananger.Apps.Count; i++)
            {
                AppConfigElement app = ConfigMananger.Apps[i];
                CheckBox ckbProgram = new System.Windows.Forms.CheckBox();
                //this.neoTabPageOpt.Controls.Add(ckbProgram);
                MonitorFlowLayout.Controls.Add(ckbProgram);
                ckbProgram.AutoSize = true;
                ckbProgram.Checked = true;
                ckbProgram.CheckState = System.Windows.Forms.CheckState.Checked;
                ckbProgram.Font = new System.Drawing.Font("宋体", 12F);
                //ckbProgram.Location = new System.Drawing.Point(58, offsetY);
                ckbProgram.Name = app.Label;
                ckbProgram.Size = new System.Drawing.Size(59, 20);
                //ckbProgram.TabIndex = 4;
                ckbProgram.Margin = new Padding(10);
                ckbProgram.Enabled = false;
                ckbProgram.Text = app.Label;
                ckbProgram.UseVisualStyleBackColor = true;

                offsetY = offsetY + 40;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!valid)
            {
                MessageBox.Show("授权证书无效或已过期.");
                Application.Exit();
            }
            else {
                btControl.Checked = true;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        private void m_StandardErrorOut(object sender, StandardErrorArg e)
        {
            //Loger.Error(e.OutPut);
        }

        private void m_StandardOut(object sender, StandardOutArg e)
        {
            //Loger.Info(e.OutPut);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void toggleSwitch1_CheckedChanged(object sender, EventArgs e)
        {
            if (btControl.Checked)
            {
                startMonitor();
            }
            else
            {
                stopMonitor();
                this.runningFlowLayout.Controls.Clear();
            }

        }

        private void startMonitor()
        {
            if (!m.isRunning())
            {
                m.Start();
            }
            lblContrlStatus.Text = "监控中";
            timedisplay.Enabled = true;
            tsmenuMonitor.Checked = true;
            btControl.Checked = true;

        }

        private void stopMonitor()
        {
            if (m.isRunning())
            {
                m.Stop();
            }
            
            lblContrlStatus.Text = "停止监控";
            timedisplay.Enabled = false;
            //runningflowLayout.Controls.Clear();
            tsmenuMonitor.Checked = false;
            btControl.Checked = false;

        }

        private void timedisplay_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            DateTime endDate = Wit.ivelocity.License.Instance.EndDate;
            if (!endDate.ToString("yyyyMMdd").Equals("00010101") && now.CompareTo(endDate) > 0)
            {
                stopMonitor();
            }
            else
            {
                displayRunning();
            }
            
        }
        
        
        private void displayRunning()
        {


            runningFlowLayout.SuspendLayout();
            foreach (AppConfigElement app in RunningPool.Instance.getAllRunningProcess())
            {
                if (!runningFlowLayout.Controls.ContainsKey(app.Name))
                {
                        IconWithlb ckbProgram = new IconWithlb();

                        runningFlowLayout.Controls.Add(ckbProgram);
                        ckbProgram.Size = new System.Drawing.Size(80, 100);

                        ckbProgram.Name = app.Name;
                        ckbProgram.lableTxt = app.Label;



                }
            }

            
            foreach (Control c in runningFlowLayout.Controls)
            {
                if (c is IconWithlb)
                {
                    String key = c.Name;
                    if (!RunningPool.Instance.contain(key))
                    {
                        runningFlowLayout.Controls.Remove(c);
                    }
                }

            }
            runningFlowLayout.ResumeLayout();
        }
        /*
    private void displayRunning()
    {
        int offsetx = 30 + 90 * this.groupBox3.Controls.Count;


        foreach (AppConfigElement app in RunningPool.Instance.getAllRunningProcess())
        {
            if (!this.groupBox3.Controls.ContainsKey(app.Name))
            {
                IconWithlb ckbProgram = new IconWithlb();
                this.groupBox3.Controls.Add(ckbProgram);
                ckbProgram.AutoSize = true;
                //ckbProgram.Font = new System.Drawing.Font("宋体", 12F);

                ckbProgram.Location = new System.Drawing.Point(offsetx, 20);
                ckbProgram.Name = app.Name;
                ckbProgram.Size = new System.Drawing.Size(100, 120);
                ckbProgram.Enabled = false;
                ckbProgram.lableTxt = app.Label;
                offsetx = offsetx + 90;
            }
        }

        foreach (Control c in this.groupBox3.Controls)
        {
            if (c is IconWithlb)
            {
                String key = c.Name;
                if (!RunningPool.Instance.contain(key))
                {
                    Control next = this.groupBox3.GetNextControl(c, true);
                    Point l = c.Location;
                    this.groupBox3.Controls.Remove(c);
                    if (next != null)
                    {
                        relocate(next, l);
                    }
                }
            }

        }
    }
    */

        /*
         * private void displayRunning()
        {
            int offsetx = 30 + 90 * this.groupBox3.Controls.Count;


            foreach (AppConfigElement app in RunningPool.Instance.getAllRunningProcess())
            {
                if (!this.groupBox3.Controls.ContainsKey(app.Name))
                {
                    Label ckbProgram = new System.Windows.Forms.Label();
                    this.groupBox3.Controls.Add(ckbProgram);
                    ckbProgram.AutoSize = true;
                    ckbProgram.Font = new System.Drawing.Font("宋体", 12F);

                    ckbProgram.Location = new System.Drawing.Point(offsetx, 50);
                    ckbProgram.Name = app.Name;
                    ckbProgram.Size = new System.Drawing.Size(70, 20);
                    ckbProgram.Enabled = false;
                    ckbProgram.Text = app.Label;
                    offsetx = offsetx + 90;
                }
            }

            bool reloc = false;
            foreach (Control c in this.groupBox3.Controls)
            {
                if (c is Label)
                {
                    String key = c.Name;
                    if (!RunningPool.Instance.contain(key))
                    {
                        Control next = this.groupBox3.GetNextControl(c, true);
                        this.groupBox3.Controls.Remove(c);
                        if (next != null)
                        {
                            relocate(next, c.Location);
                        }
                    }
                }

            }
        }
        */
        private void relocate(Control next, Point location)
        {
            Point org = next.Location;
            next.Location = new System.Drawing.Point(location.X, location.Y);

            Control next2 = this.groupBox3.GetNextControl(next, true);
            if (next2 != null)
            {
                relocate(next2, org);
            }
        }

        private void ckbRunOnStart_CheckedChanged(object sender, EventArgs e)
        {
            /*
            if (ckbRunOnStart.Checked == true)
            {
                rkApp.SetValue(REG_KEY_WITSOFT, Application.ExecutablePath);
            }
            else
            {
                rkApp.DeleteValue(REG_KEY_WITSOFT, false);
            }
            */
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (minimizeToIconTray)
            {
                if (FormWindowState.Minimized == this.WindowState)
                {
                    //ShowInTaskbar = false;
                    notifyIcon.Visible = true;
                    notifyIcon.ShowBalloonTip(500);
                    ShowInTaskbar = false; // Remove from taskbar.

                    this.Hide();
                }
                else if (FormWindowState.Normal == this.WindowState)
                {
                    ShowInTaskbar = true;
                    notifyIcon.Visible = false;
                    WindowState = FormWindowState.Normal;
                    this.Show();
                }

            }
        }

        private void notifyIcon_DoubleClick(object sender, EventArgs e)
        {

        }

        private void reoopenWindow(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            this.ShowInTaskbar = true;
            notifyIcon.Visible = false;

        }

        private void exitProgram(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.witsoft.cn");
        }
        private void openWitsoftWebPage(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.witsoft.cn");
        }

        private void tsmenuMonitor_Click(object sender, EventArgs e)
        {
            
        }

        private void tsmenuMonitor_CheckedChanged(object sender, EventArgs e)
        {
            if (tsmenuMonitor.Checked == true)
            {
                startMonitor();
            }else
            {
                stopMonitor();
            }
        }

        private void setMinimizeToIconTray(object sender, EventArgs e)
        {
            if (ckbMinimize.Checked)
            {
                minimizeToIconTray = true;              
            }
            else
            {
                minimizeToIconTray = false;
            }
            ConfigMananger.setMinimizeToIconTray(minimizeToIconTray);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            PowCtrl.setCurrentPowerEnumerateVistaAPI(5);
        }

        private void iconWithlb2_Load(object sender, EventArgs e)
        {

        }

        private void neoTabWindow1_SelectedIndexChanged(object sender, NeoTabControlLibrary.SelectedIndexChangedEventArgs e)
        {

        }
    }
}
