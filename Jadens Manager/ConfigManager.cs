using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jadens_Manager
{
    internal class ConfigManager
    {
        public static string DOWNLOAD_URL = "";
        public static JadensManagerConfig CONFIG = GetConfig();
        public static string CONFIG_PATH { get { return Path.Combine(Directory.GetCurrentDirectory(), "jadens_manager.json"); } }
        

        public static JadensManagerConfig GetConfig()
        {
            if (File.Exists(CONFIG_PATH))
            {
                string json = File.ReadAllText(CONFIG_PATH);
                JadensManagerConfig? jmconfig = JsonConvert.DeserializeObject<JadensManagerConfig>(json);
                if (jmconfig != null)
                {
                    return jmconfig;
                }
                else
                {
                    jmconfig = new JadensManagerConfig("1.0", Directory.GetCurrentDirectory());
                    json = JsonConvert.SerializeObject(jmconfig);
                    File.WriteAllText(CONFIG_PATH, json);
                    return jmconfig;
                }
            }
            else
            {
                JadensManagerConfig jmconfig = new JadensManagerConfig("1.0", Directory.GetCurrentDirectory());
                string json = JsonConvert.SerializeObject(jmconfig);
                File.WriteAllText(CONFIG_PATH, json);
                return jmconfig;
            }
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
