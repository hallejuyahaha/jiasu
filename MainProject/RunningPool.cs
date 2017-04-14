using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Wit.ProcessMonitor.Config;

namespace Wit.ivelocity
{
    public class RunningPool
    {

        private static RunningPool instance;
        private Dictionary<string, AppConfigElement> dict = new Dictionary<string, AppConfigElement>();
        private RunningPool() { }

        public static RunningPool Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new RunningPool();
                }
                return instance;
            }
        }

        public void addRunningProcess(String processName, AppConfigElement appCfg)
        {
            if (!dict.ContainsKey(processName))
            {
                dict.Add(processName, appCfg);
            }
        }

        public void removeRunningProcess(String processName)
        {
            if (dict.ContainsKey(processName))
            {
                dict.Remove(processName);
            }
        }

        public List<AppConfigElement> getAllRunningProcess()
        {
            return dict.Values.ToList();
        }


        public bool contain(String key)
        {
            return dict.ContainsKey(key);
        }
    }


}
