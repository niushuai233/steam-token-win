using Newtonsoft.Json;
using steam_token.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;

namespace steam_token.UI.Set
{
    public partial class GuardConfig : Form
    {
        private SteamGuard steamGuard;
        public GuardConfig()
        {
            InitializeComponent();
            // 先初始化组件 再使用
            Config config = ConfigUtil.Read<Config>();
            steamGuard = config.SteamGuard;
            if (null != steamGuard && !string.IsNullOrEmpty(steamGuard.shared_secret))
            {
                this.textBox_shared_secret.Text = steamGuard.shared_secret;
            }
        }

        private void button_openfile_Click(object sender, EventArgs e)
        {
            this.openFileDialog_steam.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            if (this.openFileDialog_steam.ShowDialog() == DialogResult.OK)
            {
                ReadFile(this.openFileDialog_steam.FileName);
            }
        }

        private void ReadFile(string fileName)
        {
            FileInfo file = new FileInfo(fileName);
            if (!file.Exists)
            {
                MessageBox.Show("文件" + fileName + "不存在");
            }

            if (file.Length > 1024 * 2)
            {
                MessageBox.Show("文件大小错误, 鉴定为不合适的文件");
            }

            byte[] bytes = File.ReadAllBytes(fileName);
            string fileStr = Encoding.UTF8.GetString(bytes);

            ParseSteamGuard(fileStr);


        }

        private void ParseSteamGuard(string fileStr)
        {
            try
            {
                steamGuard = JsonConvert.DeserializeObject<SteamGuard>(fileStr);
                Console.WriteLine(steamGuard);

                this.textBox_shared_secret.Text = steamGuard.shared_secret;
            }
            catch (JsonReaderException)
            {
                MessageBox.Show("文件内容不符合要求, 请不要修改拷贝出来的文件");
            }
            catch (Exception)
            {
                MessageBox.Show("未知异常, 请通知作者, 感谢!");
            }
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            if (null == steamGuard)
            {
                MessageBox.Show("熬, 未知操作!!!");
                return;
            }

            Config config = ConfigUtil.Read<Config>();
            config.SteamGuard = steamGuard;
            ConfigUtil.Save<Config>(config);
            this.Dispose();
        }
    }
}
