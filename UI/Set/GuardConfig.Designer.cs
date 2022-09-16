
namespace steam_token.UI.Set
{
    partial class GuardConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_confirm = new System.Windows.Forms.Button();
            this.openFileDialog_steam = new System.Windows.Forms.OpenFileDialog();
            this.textBox_shared_secret = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_openfile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_confirm
            // 
            this.button_confirm.Location = new System.Drawing.Point(451, 97);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(85, 30);
            this.button_confirm.TabIndex = 1;
            this.button_confirm.Text = "确定";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // openFileDialog_steam
            // 
            this.openFileDialog_steam.FileName = "openFileDialog1";
            this.openFileDialog_steam.Title = "请选择Steam令牌文件";
            // 
            // textBox_shared_secret
            // 
            this.textBox_shared_secret.Location = new System.Drawing.Point(16, 59);
            this.textBox_shared_secret.Name = "textBox_shared_secret";
            this.textBox_shared_secret.Size = new System.Drawing.Size(428, 29);
            this.textBox_shared_secret.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "请输入位于Steam令牌文件中的[shared_secret]值";
            // 
            // button_openfile
            // 
            this.button_openfile.Location = new System.Drawing.Point(451, 59);
            this.button_openfile.Name = "button_openfile";
            this.button_openfile.Size = new System.Drawing.Size(85, 30);
            this.button_openfile.TabIndex = 1;
            this.button_openfile.Text = "选择文件";
            this.button_openfile.UseVisualStyleBackColor = true;
            this.button_openfile.Click += new System.EventHandler(this.button_openfile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(13, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(462, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "/data/data/com.valvesoftware.android.steam.community/files/Steamguard-xxx";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label3.Location = new System.Drawing.Point(16, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(309, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tips: 手机需root或者能通过备份手段拿到该文件";
            // 
            // GuardConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 132);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_shared_secret);
            this.Controls.Add(this.button_openfile);
            this.Controls.Add(this.button_confirm);
            this.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GuardConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "令牌配置";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.OpenFileDialog openFileDialog_steam;
        private System.Windows.Forms.TextBox textBox_shared_secret;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_openfile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}