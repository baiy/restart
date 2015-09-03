namespace restart
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statutime = new System.Windows.Forms.ToolStripStatusLabel();
            this.interval = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.filepathtext = new System.Windows.Forms.TextBox();
            this.switchs = new System.Windows.Forms.Button();
            this.filepath = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showlog = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statutime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 96);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(434, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statutime
            // 
            this.statutime.Name = "statutime";
            this.statutime.Size = new System.Drawing.Size(56, 17);
            this.statutime.Text = "暂未执行";
            // 
            // interval
            // 
            this.interval.Location = new System.Drawing.Point(121, 61);
            this.interval.Name = "interval";
            this.interval.Size = new System.Drawing.Size(92, 21);
            this.interval.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "间隔时间(秒)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "程序路径";
            // 
            // filepathtext
            // 
            this.filepathtext.Location = new System.Drawing.Point(121, 23);
            this.filepathtext.Name = "filepathtext";
            this.filepathtext.Size = new System.Drawing.Size(283, 21);
            this.filepathtext.TabIndex = 6;
            this.filepathtext.Click += new System.EventHandler(this.filepathtext_Click);
            // 
            // switchs
            // 
            this.switchs.Location = new System.Drawing.Point(347, 61);
            this.switchs.Name = "switchs";
            this.switchs.Size = new System.Drawing.Size(57, 22);
            this.switchs.TabIndex = 7;
            this.switchs.Text = "开始";
            this.switchs.UseVisualStyleBackColor = true;
            this.switchs.Click += new System.EventHandler(this.switchs_Click);
            // 
            // filepath
            // 
            this.filepath.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showlog,
            this.showMenuItem,
            this.hideMenuItem,
            this.exitMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 92);
            // 
            // showMenuItem
            // 
            this.showMenuItem.Name = "showMenuItem";
            this.showMenuItem.Size = new System.Drawing.Size(100, 22);
            this.showMenuItem.Text = "显示";
            this.showMenuItem.Click += new System.EventHandler(this.showMenuItem_Click);
            // 
            // hideMenuItem
            // 
            this.hideMenuItem.Name = "hideMenuItem";
            this.hideMenuItem.Size = new System.Drawing.Size(100, 22);
            this.hideMenuItem.Text = "隐藏";
            this.hideMenuItem.Click += new System.EventHandler(this.hideMenuItem_Click);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(100, 22);
            this.exitMenuItem.Text = "退出";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // showlog
            // 
            this.showlog.Name = "showlog";
            this.showlog.Size = new System.Drawing.Size(100, 22);
            this.showlog.Text = "日志";
            this.showlog.Click += new System.EventHandler(this.showlog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 118);
            this.Controls.Add(this.switchs);
            this.Controls.Add(this.filepathtext);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.interval);
            this.Controls.Add(this.statusStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.ShowInTaskbar = false;
            this.Text = "定时重启程序";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statutime;
        private System.Windows.Forms.TextBox interval;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox filepathtext;
        private System.Windows.Forms.Button switchs;
        private System.Windows.Forms.OpenFileDialog filepath;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem showMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showlog;
    }
}

