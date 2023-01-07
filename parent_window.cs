using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Management;
using Microsoft.VisualBasic;
using System.Collections.Specialized;
using System.IO;


namespace ParentalControl
{
    public partial class parent_window : Form
    {
        private List<Process> processes = null;
        private List<string> nameprocess = new List<string>();
        private List<string> apps = new List<string>();

        private DateTime _timeblock = new DateTime();

        private new bool Enabled = false;

        public parent_window()
        {
            InitializeComponent();
            notifyIcon1.BalloonTipTitle = "Application Blocked";
        }


        private void get_list_processname()
        {
            nameprocess.Clear();

            foreach(Process p in processes)
            {
                nameprocess.Add(p.ProcessName);
            }
        }

        private void choice_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "EXE Files (.exe)|*.exe";
            ofd.ShowDialog();

            FileInfo tmp = new FileInfo(ofd.FileName);
            string name_processs = Path.GetFileNameWithoutExtension(tmp.Name);
            apps.Add(name_processs);
        }

        private void refresh_list_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();

            foreach(string s in apps)
            {
                listView1.Items.Add(s);
            }

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            Hide();
            start_window s = new start_window();
            s.ShowDialog();
        }

        private void choose_time_block_Click(object sender, EventArgs e)
        {
            time t = new time();
            t.ShowDialog();
            _timeblock = t.get_time();

            StreamWriter info_block = new StreamWriter("Block_apps_time.txt", false);
            info_block.WriteLine("Время окончания блокировки приложений :'" + _timeblock);

            foreach (string s in apps)
            {
                info_block.WriteLine(s);
            }
            info_block.Close();
        }


        private void block_apps()
        {
            Enabled = true;
            timer1.Enabled = true;

            //while (_timeblock > DateTime.Now)
            //{ 
            //    get_processes();
            //    get_list_processname();

            //    foreach (string app in apps)
            //    {

            //        bool work_process = nameprocess.Contains(app);
            //        if (work_process)
            //        {

            //            foreach (Process p in processes)
            //            {
            //                if (p.ProcessName == app)
            //                {
            //                    p.Kill();
            //                    MessageBox.Show("доступ к приложению временно заблокирован");
            //                    break;
            //                }
            //            }

            //        }
            //    }
            //}
            //MessageBox.Show("Блокировка приложений отключена!");
        }


        private void block_app_Click(object sender, EventArgs e)
        {
             block_apps();
        }

        private void unblock_app_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            notifyIcon1.BalloonTipText = "Доступ к приложениям разблокирован";
            notifyIcon1.ShowBalloonTip(1000);

            //DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите разблокировать приложения?", "Сообщение", MessageBoxButtons.OKCancel);
            //if(dialogResult == DialogResult.Yes)
            //{
            //    _timeblock = DateTime.Now;
            //}
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_timeblock > DateTime.Now)
            {
                //GC.Collect();
                Process[] procs = Process.GetProcesses();
                var tokill = procs.Where(v => apps.Contains(v.ProcessName));
                foreach (var proc in tokill)
                {
                    notifyIcon1.BalloonTipText = $"\"{proc.ProcessName}\" доступ к приложению временно заблокирован";
                    try
                    {
                        proc.Kill();
                    }
                    catch { }

                    notifyIcon1.ShowBalloonTip(1000);
                }
            }
            if(timer1.Enabled==false)
            {
                notifyIcon1.BalloonTipText = "доступ к приложениям разблокирован";
                notifyIcon1.ShowBalloonTip(1000);
            }
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            //Show();
            this.WindowState = FormWindowState.Normal;
        }
    }
}
