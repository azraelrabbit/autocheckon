using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Management;
using System.Configuration.Assemblies;

namespace autoCheck
{
    public class AppConfigHelper
    {
        public static string GetAppSetting(string keyName)
        {
            return ConfigurationManager.AppSettings[keyName].ToString();
        }

        public static void ModifyAppSeeting(string keyName, string keyValue)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            if (ConfigurationManager.AppSettings.AllKeys.Contains(keyName))
            {
                config.AppSettings.Settings[keyName].Value = keyValue;
                config.Save();
            }
        }
    }
}
