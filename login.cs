using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace ParentalControl
{
    public partial class login : Form
    {
        
        public login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path = AppDomain.CurrentDomain.BaseDirectory;
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='" + path + "Data1\\Data1.mdf';Integrated Security=True;Connect Timeout=30;");
            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*) From Login where USERNAME= '" + textBox1.Text + "' and PASSWORD='" + textBox2.Text + "'", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString()=="1")
            {
                Hide();
                parent_window p = new parent_window();
                p.ShowDialog();
                Close();
            }
            else
            {
                MessageBox.Show("Пожалуйста проверьте логин и пароль!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            start_window start = new start_window();
            start.ShowDialog();
        }
    }
}
