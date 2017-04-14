// ***********************************************************************************
//  Created by zbw911 
//  创建于：2014年01月23日 11:30
//  
//  修改于：2014年01月23日 21:25
//  文件名：Dev.ProcessMonitor/Dev.ProcessMonitor/AppConfigElement.cs
//  
//  如果有更好的建议或意见请邮件至 zbw911#gmail.com
// ***********************************************************************************

using System;
using System.Configuration;

namespace Wit.ProcessMonitor.Config
{
    /// <summary>
    ///     应用程序的设置
    /// </summary>
    public class AppConfigElement : ConfigurationElement
    {
        #region C'tors

        public AppConfigElement(String name, String lable)
        {
            Name = name;
            Label = lable;
        }

        public AppConfigElement()
        {
            Name = "";
            Label = "";
            Icon = "";
        }

        #endregion

        #region Instance Properties

        [ConfigurationProperty("icon", IsRequired = true)]
        public string Icon
        {
            get { return (string) this["icon"]; }
            set { this["icon"] = value; }
        }

        [ConfigurationProperty("name", DefaultValue = "Contoso",
            IsRequired = true, IsKey = true)]
        public string Name
        {
            get { return (string) this["name"]; }
            set { this["name"] = value; }
        }

        [ConfigurationProperty("label", DefaultValue = "http://www.contoso.com",
            IsRequired = true)]
        public string Label
        {
            get { return (string) this["label"]; }
            set { this["label"] = value; }
        }

        #endregion
    }
}