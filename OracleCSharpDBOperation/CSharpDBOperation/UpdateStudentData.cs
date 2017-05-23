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
    public partial class UpdateStudentData : Form
    {
        public UpdateStudentData()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            connection CN = new connection();
            CN.thisConnection.Open();

            OracleCommand thisCommand = CN.thisConnection.CreateCommand();
            textBox2.Text = "";
            thisCommand.CommandText =
            "SELECT name FROM data where id= '" + textBox1.Text + "'";

            OracleDataReader thisReader = thisCommand.ExecuteReader();


            while (thisReader.Read())
            {

                textBox2.Text = thisReader["name"].ToString();

                try
                {
                    // string filePath = thisReader["picture"].ToString();
                    // this.pb_profilepics.Image = Image.FromFile(filePath);
                }
                catch
                { MessageBox.Show("Failure"); }


            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            connection sv = new connection();
            sv.thisConnection.Open();
            OracleCommand thisCommand = sv.thisConnection.CreateCommand();

            thisCommand.CommandText =
                "update data set name = '" + textBox2.Text + "'where id= '" + textBox1.Text + "'";

            thisCommand.Connection = sv.thisConnection;
            thisCommand.CommandType = CommandType.Text;
            //For Insert Data Into Oracle//
            try
            {
                thisCommand.ExecuteNonQuery();
                MessageBox.Show("Updated");
                this.Hide();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            sv.thisConnection.Close();
            this.Close();

            DbFeatures ob = new DbFeatures();
            ob.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DbFeatures ob = new DbFeatures();
            ob.Show();
            this.Hide();
        }
    }
}
