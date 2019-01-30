using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;
using System.Windows.Forms;

namespace HotelManagement
{
    public static class ConfigUtilities
    {
        static Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

        public static void SetConfig(string key, string value)
        {
            config.AppSettings.Settings.Remove(key);
            config.AppSettings.Settings.Add(key, value);
            config.Save(ConfigurationSaveMode.Modified);
        }

        public static string GetConfig(string key)
        {
            return config.AppSettings.Settings[key].Value;
        }

        public static string GetDefaultConfig(string key)
        {
            return Properties.Settings.Default[key].ToString();
        }
    }
}
