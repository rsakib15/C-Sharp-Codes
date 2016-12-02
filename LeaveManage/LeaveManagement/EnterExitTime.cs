using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leave
{
    public partial class EnterExitTime : MetroFramework.Forms.MetroForm
    {
        public EnterExitTime()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 oform = new Form1();
            oform.Show();
            this.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Form1 oform = new Form1();
            oform.Show();
            this.Hide();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Form1 oform = new Form1();
            oform.Show();
            this.Hide();
        }
    }
}
