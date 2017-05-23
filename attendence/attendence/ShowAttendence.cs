using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace attendence
{
    public partial class ShowAttendence : Form
    {
        public ShowAttendence()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            this.Hide();
            op.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            label3.Text= db.getTotalAttendence(textBox1.Text).ToString() + " Days";
        }
    }
}
