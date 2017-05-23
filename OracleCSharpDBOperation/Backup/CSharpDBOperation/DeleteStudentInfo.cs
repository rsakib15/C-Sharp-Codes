using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace CSharpDBOperation
{
    public partial class DeleteStudentInfo : Form
    {
        public DeleteStudentInfo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            connection con = new connection();
            con.thisConnection.Open();

            OracleCommand thisCommand1 = con.thisConnection.CreateCommand();

            thisCommand1.CommandText =
                "delete data where id= '" + textBox1.Text + "'";

            thisCommand1.Connection = con.thisConnection;
            thisCommand1.CommandType = CommandType.Text;
            //For Insert Data Into Oracle//
            try
            {
                thisCommand1.ExecuteNonQuery();
                MessageBox.Show("delete successfully");
                this.Hide();
                DbFeatures ob = new DbFeatures();
                ob.Show();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DbFeatures ob = new DbFeatures();
            ob.Show();
            this.Hide();
        }
    }
}
