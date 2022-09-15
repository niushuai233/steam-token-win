using steam_token.Entity;
using steam_token.UI;
using steam_token.UI.Set;
using steam_token.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Util;

namespace steam_token
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();

            this.timer_time.Start();

            // 先计算一次
            this.label_guard.Text = CalcOnce();

            // 新开一个线程去初始化数据
            SteamGuardCalcThread.StartThread(this.label_guard, this.progressBar_refresh);
        }

        /// <summary>
        /// 打开令牌配置页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GuardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardConfig guard = new GuardConfig();
            guard.ShowDialog(this);
        }

        /// <summary>
        /// 打开程序设置页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void ProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProgramConfig program = new ProgramConfig();
            program.ShowDialog(this);
        }

        private void button_recalc_Click(object sender, EventArgs e)
        {
            this.label_guard.Text = CalcOnce();

            SteamGuardCalcThread.StartThread(this.label_guard, this.progressBar_refresh);
        }

        private string CalcOnce()
        {
            Config config = ConfigUtil.Read<Config>();
            string guard = SteamTwoFactorToken.GenerateSteamGuardCode(config.SteamGuard.shared_secret);
            Console.WriteLine("guard = " + guard);
            return guard;
        }

        private void button_copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(this.label_guard.Text);
        }

        private void timer_time_Tick(object sender, EventArgs e)
        {
            this.label_datetime.Text = DateTime.Now.ToString();
        }

        private void mainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog(this);
        }
    }
}
