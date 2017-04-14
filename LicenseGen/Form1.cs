using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace LicenseGen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void endDateCheckedChanged(object sender, EventArgs e)
        {
            if (rdEndDate.Checked && rdEndDateY.Checked == false)
            {
                datepickEndDate.Enabled = false;
            }
            else
            {
                datepickEndDate.Enabled = true;
            }
        }

        private void btSelectDir_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !String.IsNullOrEmpty(fbd.SelectedPath))
                {
                    //string[] files = Directory.GetFiles(fbd.SelectedPath);
                    tbOutPath.Text = fbd.SelectedPath;
                    //System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                }
            }
        }

        private void btGen_Click(object sender, EventArgs e)
        {
            String company = tbCompany.Text;
            if (String.IsNullOrEmpty(company))
            {
                System.Windows.Forms.MessageBox.Show("请输入公司名", "提醒");
                return;
            }
            String issueDate = datepickIssueDate.Value.ToString("yyyy/MM/dd");
            if (String.IsNullOrEmpty(issueDate))
            {
                System.Windows.Forms.MessageBox.Show("请输入授权日期", "提醒");
                return;
            }
            String endDate = "-1";
            if(rdEndDate.Checked==false && rdEndDateY.Checked == true)
            {
                endDate = datepickEndDate.Value.ToString("yyyy/MM/dd");
            }


            String hdcode = tbHdCode.Text;
            if (String.IsNullOrEmpty(hdcode))
            {
                System.Windows.Forms.MessageBox.Show("请输入机器码", "提醒");
                return;
            }

            String outPath = tbOutPath.Text;
            if (String.IsNullOrEmpty(outPath))
            {
                System.Windows.Forms.MessageBox.Show("请选择输出目录", "提醒");
                return;
            }

            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "LicenseGen.Resources._private.xml";
            string[] all = assembly.GetManifestResourceNames();
            License license = new License();
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                string privatekey = reader.ReadToEnd();
                StringBuilder licenseContent = new StringBuilder();
                licenseContent.Append("<license>");
                licenseContent.AppendFormat("<company>{0}</company>", company);
                licenseContent.AppendFormat("<issueDate>{0}</issueDate>", issueDate);
                licenseContent.AppendFormat("<endDate>{0}</endDate>", endDate);
                licenseContent.AppendFormat("<hdcode>{0}</hdcode>", hdcode);
                licenseContent.Append("</license>");

                XmlDocument fileContent =  license.SignXmlDocument(licenseContent.ToString(), privatekey);
                StringToFile(outPath + "\\license.lic", fileContent.OuterXml);
                System.Windows.Forms.MessageBox.Show("生成完毕", "提醒");
            }

 
            

        }


        private void StringToFile(string outfile, string data)
        {
            StreamWriter outStream = System.IO.File.CreateText(outfile);
            outStream.Write(data);
            outStream.Close();
        }
    }
}
