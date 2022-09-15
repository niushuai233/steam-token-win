using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace steam_token.UI
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            // 初始化图片
            this.pictureBox1.Image = Properties.Resources.steam_token;
        }

        private void button_about_confirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabel_openurl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(this.linkLabel_openurl.Text);
        }
    }
}
