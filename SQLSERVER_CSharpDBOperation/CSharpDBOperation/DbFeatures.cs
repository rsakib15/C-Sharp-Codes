using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CSharpDBOperation
{
    public partial class DbFeatures : Form
    {
        public DbFeatures()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InsertData oform = new InsertData();
            oform.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewAllStudentData ob = new ViewAllStudentData();
            ob.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UpdateStudentData ob = new UpdateStudentData();
            ob.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteStudentInfo ob = new DeleteStudentInfo();
            ob.Show();
            this.Hide();
        }
    }
}
