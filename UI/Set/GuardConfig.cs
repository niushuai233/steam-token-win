using Newtonsoft.Json;
using steam_token.Entity;
using steam_token.Util;
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
        private Label labelGuard;
        private ProgressBar progressBarRefresh;
        public GuardConfig(Label label_guard, ProgressBar progressBar_refresh)
        {
            this.labelGuard = label_guard;
            this.progressBarRefresh = progressBar_refresh;
            InitializeComponent();
            // 先初始化组件 再使用
            Config config = CommonUtil.GetConfig();
            if (null != config && null != config.SteamGuard && !string.IsNullOrEmpty(config.SteamGuard.shared_secret))
            {
                this.textBox_shared_secret.Text = config.SteamGuard.shared_secret;
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

        private SteamGuard tmpSteamGuard;
        private void ParseSteamGuard(string fileStr)
        {
            try
            {
                tmpSteamGuard = JsonConvert.DeserializeObject<SteamGuard>(fileStr);
                Console.WriteLine(tmpSteamGuard);

                this.textBox_shared_secret.Text = tmpSteamGuard.shared_secret;

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
            string text = this.textBox_shared_secret.Text;
            if (string.IsNullOrEmpty(text))
            {
                MessageBox.Show("请输入shared_secret值");
                return;
            }
            if (SteamTwoFactorToken.Verify(text))
            {
                Config config = ConfigUtil.Read<Config>();
                if (null == config)
                {
                    config = new Config();
                }
                if (null == tmpSteamGuard)
                {
                    tmpSteamGuard = new SteamGuard();
                    tmpSteamGuard.shared_secret = text;
                }
                config.SteamGuard = tmpSteamGuard;
                ConfigUtil.Save<Config>(config);

                // 配置更新 重新计算值
                SteamGuardCalcThread.StartThread(labelGuard, progressBarRefresh);

                this.Dispose();
            }
        }
    }
}
