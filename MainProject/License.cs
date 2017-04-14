using System;
using System.Collections.Generic;
using System.IO;
using System.Management;
using System.Reflection;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Xml;

namespace Wit.ivelocity
{
    
    class License
    {
        private static License instance;
        public static License Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new License();
                }
                return instance;
            }
        }

        private License() { }

        private String company;
        private DateTime issueDate;
        private DateTime endDate;

        public string Company
        {
            get
            {
                return company;
            }

            set
            {
                company = value;
            }
        }

        public DateTime IssueDate
        {
            get
            {
                return issueDate;
            }

            set
            {
                issueDate = value;
            }
        }

        public DateTime EndDate
        {
            get
            {
                return endDate;
            }

            set
            {
                endDate = value;
            }
        }

        public bool VerifyXmlDocument()
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = "Wit.ivelocity.Resources._public.xml";
            string[] all = assembly.GetManifestResourceNames();
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                string publickey = reader.ReadToEnd();
                string licencePath = System.Environment.CurrentDirectory+ "\\license.lic";
                if (!File.Exists(licencePath))
                {
                    return false;
                }
                string licenceContent = File.ReadAllText(licencePath);
                return VerifyXmlDocument(publickey, licenceContent);
            }
            
        }

        public bool VerifyXmlDocument(string publicKey, string licenseContent)
        {
            bool ret = false;
            RSA key = RSA.Create();
            key.FromXmlString(publicKey);

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(licenseContent);
            SignedXml sxml = new SignedXml(doc);
            try
            {
                // Find signature node
                XmlNode sig = doc.GetElementsByTagName("Signature")[0];
                sxml.LoadXml((XmlElement)sig);
            }
            catch (Exception ex)
            {
                // Not signed!
                return false;
            }
            ret = sxml.CheckSignature(key);
            if (!ret)
            {
                return ret;
            }

            XmlNode compNode = doc.GetElementsByTagName("company")[0];
            this.Company = compNode.InnerText;

            XmlNode issueNode = doc.GetElementsByTagName("issueDate")[0];
            this.IssueDate = Convert.ToDateTime(issueNode.InnerText);
            XmlNode endNode = doc.GetElementsByTagName("endDate")[0];
            String endDateStr = endNode.InnerText;
            if (!endDateStr.Equals("-1"))
            {
                this.EndDate = Convert.ToDateTime(endNode.InnerText);
                DateTime now = DateTime.Now;
                if (now.CompareTo(this.EndDate) > 0)
                {
                    return false;
                }
            }

            XmlNode hdCodeNode = doc.GetElementsByTagName("hdcode")[0];
            String hdCode = hdCodeNode.InnerText;

            String hardwarecode = getHardwareCode();
            if (!hardwarecode.Equals(hdCode))
            {
                return false;
            }

            return ret;
        }

        private String getHardwareCode()
        {
            string cpuInfo = string.Empty;
            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();

            foreach (ManagementObject mo in moc)
            {
                cpuInfo = mo.Properties["processorID"].Value.ToString();
                break;
            }

            string drive = "C";
            ManagementObject dsk = new ManagementObject(
                @"win32_logicaldisk.deviceid=""" + drive + @":""");
            dsk.Get();
            string volumeSerial = dsk["VolumeSerialNumber"].ToString();

            string uniqueId = cpuInfo + volumeSerial;
            //MD5
            byte[] result = Encoding.Default.GetBytes(uniqueId);    //tbPass为输入密码的文本框  
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(result);
            String ret  = BitConverter.ToString(output).Replace("-", "");
            return ret;
        }

    
}
}
