using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace restart
{
    public partial class Form1 : Form
    {
        int times = 0;
        public Form1()
        {
            InitializeComponent();            
        }

        private void filepathtext_Click(object sender, EventArgs e)
        {
            this.filepath.Filter = "可执行程序(*.exe)|*.exe|所有文件(*.*)|*.*";

            if (this.filepath.ShowDialog() == DialogResult.OK)
            {
                string FileName = this.filepath.FileName;
                this.filepathtext.Text = FileName;
            }
        }

        private void switchs_Click(object sender, EventArgs e)
        {            
            string filename = this.filepathtext.Text;
            string interval = this.interval.Text;
            if (filename == "")
            {
                MessageBox.Show("请先选择需要执行的文件");
                return;
            }
            if (!File.Exists(@filename))
            {
                MessageBox.Show("需要执行的文件不存在");
                return;
            }
            if (interval == "")
            {
                MessageBox.Show("间隔时间不能为空");
                return;
            }            
            this.switchs.Text = this.switchs.Text == "开始" ? "停止" : "开始";
            if (this.switchs.Text != "停止")
            {
                this.statutime.Text = "暂未执行";
                this.exe(2);
            }
        }    
        

        private void exe(int type) 
        {
            string filename = this.filepathtext.Text;
            if (!File.Exists(@filename)) 
            {
                this.log(@filename+" 不存在");
                return;
            }
            //执行
            if (type == 1)
            {                
                if (this.GetPidByProcesspath(filename) == 0) 
                {
                    Process.Start(filename);
                    log("执行:" + @filename);
                }
            }
            //关闭
            else if (type == 2)
            {                
                if (this.GetPidByProcesspath(filename) != 0)
                {
                    Process[] pcs = Process.GetProcesses();
                    foreach (Process p in pcs)
                    {
                        try
                        {
                            if (p.MainModule.FileName.Equals(@filename, StringComparison.OrdinalIgnoreCase))
                            {
                                p.Kill();
                                p.Dispose();
                                p.Close();
                                break;
                            }
                        }
                        catch (Exception ex) { }                        
                    }
                    log("关闭:" + @filename);
                }
                
            }
            //重启
            else 
            {
                //关闭
                this.exe(2);
                //执行
                this.exe(1);
            }
        }

        /// <summary>
        /// 写入日志
        /// </summary>
        /// <param name="str">日志内容</param>
        private void log(string str)
        {            
            DateTime dt = DateTime.Now;
            StreamWriter sw = File.AppendText("log.txt");
            string w = "[" + dt.ToLocalTime().ToString() + "] =>" + str + "\r\n";
            sw.Write(w);
            sw.Close();
        }
    
        /// <summary>
        /// 根据路径获取程序执行情况
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public int GetPidByProcesspath(string path)
        {
            Process[] pcs = Process.GetProcesses();
            foreach (Process p in pcs)
            {
                try
                {
                    if (p.MainModule.FileName.Equals(@path, StringComparison.OrdinalIgnoreCase))
                    {
                        return p.Id;
                    }
                }
                catch (Exception ex){}                                
            }
            return 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.switchs.Text != "停止")
            {
                return;
            }

            if (times == 0)
            {
                //关闭
                this.exe(2);
                this.statutime.Text = this.interval.Text;
                times = Convert.ToInt32(this.interval.Text);
            }
            else 
            {
                if (Convert.ToInt32(this.interval.Text) - 5 == times)
                {
                    //延迟5秒启动
                    this.exe(1);
                }
                times--;
                this.statutime.Text = times.ToString();
            }
        }

        private void showMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.Activate();
        }

        private void hideMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("你确定要退出程序吗？", "确认", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                notifyIcon1.Visible = false;
                this.Close();
                this.Dispose();
                Application.Exit();
            }
        }

        private void showlog_Click(object sender, EventArgs e)
        {
            string startup = Application.ExecutablePath;       //取得程序路径   
            Process.Start("notepad.exe","log.txt");            
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Minimized;
                this.Hide();
            }
            else if (this.WindowState == FormWindowState.Minimized)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                this.Activate();
            }
        }
    }
}
