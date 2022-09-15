
namespace steam_token
{
    partial class mainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.SettingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GuardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.progressBar_refresh = new System.Windows.Forms.ProgressBar();
            this.groupBox_display = new System.Windows.Forms.GroupBox();
            this.label_guard = new System.Windows.Forms.Label();
            this.button_recalc = new System.Windows.Forms.Button();
            this.button_copy = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timer_time = new System.Windows.Forms.Timer(this.components);
            this.label_datetime = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.groupBox_display.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SettingToolStripMenuItem,
            this.AboutToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(644, 25);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // SettingToolStripMenuItem
            // 
            this.SettingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GuardToolStripMenuItem,
            this.ProgramToolStripMenuItem});
            this.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem";
            this.SettingToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.SettingToolStripMenuItem.Text = "设置";
            // 
            // GuardToolStripMenuItem
            // 
            this.GuardToolStripMenuItem.Name = "GuardToolStripMenuItem";
            this.GuardToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.GuardToolStripMenuItem.Text = "令牌配置";
            this.GuardToolStripMenuItem.Click += new System.EventHandler(this.GuardToolStripMenuItem_Click);
            // 
            // ProgramToolStripMenuItem
            // 
            this.ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem";
            this.ProgramToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ProgramToolStripMenuItem.Text = "程序设置";
            this.ProgramToolStripMenuItem.Visible = false;
            this.ProgramToolStripMenuItem.Click += new System.EventHandler(this.ProgramToolStripMenuItem_Click);
            // 
            // AboutToolStripMenuItem
            // 
            this.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem";
            this.AboutToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.AboutToolStripMenuItem.Text = "关于";
            this.AboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // progressBar_refresh
            // 
            this.progressBar_refresh.BackColor = System.Drawing.SystemColors.Control;
            this.progressBar_refresh.ForeColor = System.Drawing.SystemColors.Control;
            this.progressBar_refresh.Location = new System.Drawing.Point(12, 28);
            this.progressBar_refresh.Maximum = 30;
            this.progressBar_refresh.Name = "progressBar_refresh";
            this.progressBar_refresh.Size = new System.Drawing.Size(620, 23);
            this.progressBar_refresh.TabIndex = 2;
            this.progressBar_refresh.Value = 30;
            // 
            // groupBox_display
            // 
            this.groupBox_display.Controls.Add(this.label_guard);
            this.groupBox_display.Location = new System.Drawing.Point(13, 57);
            this.groupBox_display.Name = "groupBox_display";
            this.groupBox_display.Size = new System.Drawing.Size(620, 313);
            this.groupBox_display.TabIndex = 3;
            this.groupBox_display.TabStop = false;
            this.groupBox_display.Text = "Steam Guard";
            // 
            // label_guard
            // 
            this.label_guard.Font = new System.Drawing.Font("微软雅黑", 72F);
            this.label_guard.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label_guard.Location = new System.Drawing.Point(6, 25);
            this.label_guard.Name = "label_guard";
            this.label_guard.Size = new System.Drawing.Size(608, 299);
            this.label_guard.TabIndex = 1;
            this.label_guard.Text = "令二哈";
            this.label_guard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button_recalc
            // 
            this.button_recalc.Location = new System.Drawing.Point(428, 384);
            this.button_recalc.Name = "button_recalc";
            this.button_recalc.Size = new System.Drawing.Size(99, 30);
            this.button_recalc.TabIndex = 4;
            this.button_recalc.Text = "重新计算";
            this.button_recalc.UseVisualStyleBackColor = true;
            this.button_recalc.Click += new System.EventHandler(this.button_recalc_Click);
            // 
            // button_copy
            // 
            this.button_copy.Location = new System.Drawing.Point(534, 384);
            this.button_copy.Name = "button_copy";
            this.button_copy.Size = new System.Drawing.Size(99, 30);
            this.button_copy.TabIndex = 4;
            this.button_copy.Text = "复制";
            this.button_copy.UseVisualStyleBackColor = true;
            this.button_copy.Click += new System.EventHandler(this.button_copy_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(199, 385);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(223, 29);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.Visible = false;
            // 
            // timer_time
            // 
            this.timer_time.Tick += new System.EventHandler(this.timer_time_Tick);
            // 
            // label_datetime
            // 
            this.label_datetime.AutoSize = true;
            this.label_datetime.Location = new System.Drawing.Point(12, 389);
            this.label_datetime.Name = "label_datetime";
            this.label_datetime.Size = new System.Drawing.Size(105, 21);
            this.label_datetime.TabIndex = 6;
            this.label_datetime.Text = "                   ";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 425);
            this.Controls.Add(this.label_datetime);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button_copy);
            this.Controls.Add(this.button_recalc);
            this.Controls.Add(this.groupBox_display);
            this.Controls.Add(this.progressBar_refresh);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steam令牌计算器";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.mainForm_FormClosed);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.groupBox_display.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem SettingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GuardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProgramToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar_refresh;
        private System.Windows.Forms.GroupBox groupBox_display;
        private System.Windows.Forms.Button button_recalc;
        private System.Windows.Forms.Button button_copy;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label_guard;
        private System.Windows.Forms.Timer timer_time;
        private System.Windows.Forms.Label label_datetime;
    }
}

