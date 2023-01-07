using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParentalControl
{
    public partial class time : Form
    {
        private DateTime _datetime = new DateTime();

        public time()
        {
            InitializeComponent();
        }

        public DateTime get_time()
        {
            return _datetime;
        }

        private void apply_Click(object sender, EventArgs e)
        {
            _datetime = dateTimePicker1.Value;
            Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat="MM'/'dd'/'yyyy hh':'mm tt";
        }
    }
}
