using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pcis.common
{
    public static class AppConfigWriter
    {
        public static bool Write(string key, string value, bool moddate = true)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            try
            {
                string keyexcist = ConfigurationManager.AppSettings[key];
                if (keyexcist == null)
                {
                    config.AppSettings.Settings.Add(key, value);
                }
                else
                {
                    config.AppSettings.Settings[key].Value = value;
                }
                if (moddate)
                {
                    if (ConfigurationManager.AppSettings["ModificationDate"] == null)
                    {
                        config.AppSettings.Settings.Add("ModificationDate", DateTime.Now + " ");
                    }
                    else
                    {
                        config.AppSettings.Settings["ModificationDate"].Value = DateTime.Now + " ";
                    }
                }

                // Save the changes in App.config file.
                config.Save(ConfigurationSaveMode.Modified);

                // Force a reload of a changed section.
                ConfigurationManager.RefreshSection("appSettings");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }
    }
}
