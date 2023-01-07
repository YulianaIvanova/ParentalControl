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

namespace ParentalControl
{
    public partial class child : Form
    {
        public child()
        {
            InitializeComponent();
        }

        private void refresh_info_Click(object sender, EventArgs e)
        {
            StreamReader file_info = new StreamReader("Block_apps_time.txt");
            listBox1.Items.Clear();

            while (true)
            {
                string text = file_info.ReadLine();
                if (text == null) break;
                listBox1.Items.Add(text);
            }
            
            file_info.Close();
        }

        private void back_start_Click(object sender, EventArgs e)
        {
            Hide();
            start_window s = new start_window();
            s.ShowDialog();
        }

    }
}
