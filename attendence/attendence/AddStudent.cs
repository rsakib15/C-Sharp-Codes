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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string id = textBox3.Text;

            if(name=="" ||  id == "")
            {
                MessageBox.Show("Name or ID cannot be Empty");
            }
            else
            {
                Database d = new Database();
                d.Adduser(name, id);
                Options op = new Options();
                MessageBox.Show("New Student Added");
                this.Hide();
                op.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            this.Hide();
            op.Show();
        }
    }
}
