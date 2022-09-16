using Newtonsoft.Json;
using steam_token.Entity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Util
{
    public class ConfigUtil
    {
        public static bool INIT_SUCCESS = false;
        public static string CONFIG_NAME = steam_token.Properties.Resources.CONFIG_NAME;
        public static string CONFIG_FOLDER = steam_token.Properties.Resources.CONFIG_FOLDER;

        public static void Init<T>(T t)
        {
            string configPath = GetConfigPath();
            if (File.Exists(configPath))
            {
                return;
            }
            File.WriteAllText(configPath, JsonConvert.SerializeObject(t));
        }

        public static T Read<T>()
        {
            string json = File.ReadAllText(GetConfigPath());

            try
            {
                return JsonConvert.DeserializeObject<T>(json);
            }
            catch (Exception)
            {
                MessageBox.Show("配置文件内容异常, 请检查", json);
            }

            return default;
        }

        public static void Save<T>(T config)
        {
            if (null == config)
            {
                return;
            }
            File.WriteAllText(GetConfigPath(), JsonConvert.SerializeObject(config));
        }

        private static string GetConfigPath()
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "/niushuai233/" + CONFIG_FOLDER;
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            return folder + "/" + CONFIG_NAME;
        }
    }
}
