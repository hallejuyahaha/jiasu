using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Management;


namespace Wit.ivelocity
{
    public class SystemInfo
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        private class MEMORYSTATUSEX
        {
            public uint dwLength;
            public uint dwMemoryLoad;
            public ulong ullTotalPhys;
            public ulong ullAvailPhys;
            public ulong ullTotalPageFile;
            public ulong ullAvailPageFile;
            public ulong ullTotalVirtual;
            public ulong ullAvailVirtual;
            public ulong ullAvailExtendedVirtual;
            public MEMORYSTATUSEX()
            {
                this.dwLength = (uint)Marshal.SizeOf(typeof(SystemInfo.MEMORYSTATUSEX));
            }
        }


        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        static extern bool GlobalMemoryStatusEx([In, Out] MEMORYSTATUSEX lpBuffer);

        public static  String getOperatingSystemInfo()
        {
            //Console.WriteLine("Displaying operating system info....\n");
            //Create an object of ManagementObjectSearcher class and pass query as parameter.
            String ret = "";
            ManagementObjectSearcher mos = new ManagementObjectSearcher("select * from Win32_OperatingSystem");
            foreach (ManagementObject managementObject in mos.Get())
            {
                if (managementObject["Caption"] != null)
                {
                    ret = ret + managementObject["Caption"].ToString();   //Display operating system caption
                }
                if (managementObject["OSArchitecture"] != null)
                {
                    ret = ret + managementObject["OSArchitecture"].ToString();   //Display operating system architecture.
                }
                if (managementObject["CSDVersion"] != null)
                {
                    ret =ret + managementObject["CSDVersion"].ToString();     //Display operating system version.
                }
            }
            return ret;
    
        }

        public static String[] getGPUInfo()
        {
            StringBuilder sb = new StringBuilder();
            StringBuilder sb2 = new StringBuilder();
            ManagementObjectSearcher objvide = new ManagementObjectSearcher("select * from Win32_VideoController");

            foreach (ManagementObject obj in objvide.Get())
            {
                sb.Append(obj["Name"]);
                //sb.Append("DeviceID  -  " + obj["DeviceID"] + "</br>");
                uint msize = (uint)obj["AdapterRAM"];
                double e = msize / 1024.0 / 1024.0;
                sb.Append(" "+Convert.ToString(Math.Ceiling(e)) + "MB GRAM");
                //sb.Append("InstalledDisplayDrivers  -  " + obj["InstalledDisplayDrivers"]);
                //sb.Append("DriverVersion  -  " + obj["DriverVersion"]);
                sb2.Append(obj["VideoProcessor"]);
                //sb.Append("VideoArchitecture  -  " + obj["VideoArchitecture"]);
                //sb.Append("VideoMemoryType  -  " + obj["VideoMemoryType"]);
            }
            return new String[] { sb.ToString(),sb2.ToString()};
        }

        public static String getProcessorInfo()
        {
            Console.WriteLine("\n\nDisplaying Processor Name....");
            RegistryKey processor_name = Registry.LocalMachine.OpenSubKey(@"Hardware\Description\System\CentralProcessor\0", RegistryKeyPermissionCheck.ReadSubTree);   //This registry entry contains entry for processor info.

            if (processor_name != null)
            {
                if (processor_name.GetValue("ProcessorNameString") != null)
                {
                    return (String)processor_name.GetValue("ProcessorNameString");   //Display processor ingo.
                }
            }
            return "";
        }

        public static double getTotalMem()
        {
            ulong installedMemory = 0 ;
            MEMORYSTATUSEX memStatus = new MEMORYSTATUSEX();
            if (GlobalMemoryStatusEx(memStatus))
            {
                installedMemory = memStatus.ullTotalPhys;
            }
            double e = installedMemory / 1024.0 / 1024.0 / 1024.0;
            return Math.Ceiling(e);
        }
    }
}
