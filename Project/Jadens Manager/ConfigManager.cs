using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using System.Windows;

namespace Jadens_Manager
{
    internal class ConfigManager
    {
        public static string LATEST_VERSION_URL = "https://raw.githubusercontent.com/Jaden-Allen/JadensPM/main/src/latest_version.json";
        public static JadensManagerConfig CONFIG = GetConfig();
        public static string CONFIG_PATH { get { return Path.Combine(Directory.GetCurrentDirectory(), "jadens_manager.json"); } }
        

        private static JadensManagerConfig GetConfig()
        {
            JadensManagerConfig jmconfig = new JadensManagerConfig("1.0.0", Directory.GetCurrentDirectory());
            if (File.Exists(CONFIG_PATH))
            {
                string json = File.ReadAllText(CONFIG_PATH);
                JadensManagerConfig? _jmconfig = JsonConvert.DeserializeObject<JadensManagerConfig>(json);
                if (_jmconfig != null)
                {
                    jmconfig = _jmconfig;
                }
                else
                {
                    json = JsonConvert.SerializeObject(jmconfig);
                    File.WriteAllText(CONFIG_PATH, json);
                }
            }
            else
            {
                string json = JsonConvert.SerializeObject(jmconfig);
                File.WriteAllText(CONFIG_PATH, json);
            }
            return jmconfig;
        }
        public static void SaveConfig()
        {
            string json = JsonConvert.SerializeObject(CONFIG);
            File.WriteAllText(CONFIG_PATH, json);
        }
        public static void UpdateConfig(string filePath)
        {
            string? lastDir = Path.GetDirectoryName(filePath);
            if (lastDir != null)
            {
                CONFIG.lastDir = lastDir;
            }
        }
        public class JadensManagerConfig
        {
            public string version;
            public string lastDir;
            public JadensManagerConfig(string version, string lastDir)
            {
                this.version = version;
                this.lastDir = lastDir;
            }
        }
    }
}
