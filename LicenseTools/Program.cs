using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace LicenseTools
{
    class Program
    {
        static void Main(string[] args)
        {

            //LicenseAdmin admin = new LicenseAdmin();
            //admin.CreateKeyPairs("d:\\");


            // Open the file to read from.
            //verify();
            genLicense();
        }
        public static void genLicense()
        {
            string path = @"d:\_private.xml";

            
            // This text is added only once to the file.
            if (File.Exists(path))
            {
                string privateKey = File.ReadAllText(path);

                StringBuilder licenseContent = new StringBuilder();
                licenseContent.Append("<license>");
                licenseContent.AppendFormat("<company>{0}</company>", "hualing");
                licenseContent.AppendFormat("<issueDate>{0}</issueDate>", "2016/12/21");
                licenseContent.AppendFormat("<endDate>{0}</endDate>", "-1");
                licenseContent.AppendFormat("<hdcode>{0}</hdcode>", "C95BADC2AFF05B3EEC0F5D0AE27B96B6");
                licenseContent.Append("</license>");

                License license = new License();

                XmlDocument fileContent = license.SignXmlDocument(licenseContent.ToString(), privateKey);
                StringToFile("d:\\" + "testlicense.lic", fileContent.OuterXml);

            }
            


        }
        public static void StringToFile(string outfile, string data)
        {
            StreamWriter outStream = System.IO.File.CreateText(outfile);
            outStream.Write(data);
            outStream.Close();
        }

        public static void verify()
        {
            string path = @"d:\testlicense.lic";
            string content = File.ReadAllText(path);

            string pubkeypath = @"d:\_public.xml";
            string pubkeyContent = File.ReadAllText(pubkeypath);
            License license = new License();
            bool ret = license.VerifyXmlDocument(pubkeyContent, content);
            Console.WriteLine(ret);
        }
    }
}
