using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OracleClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Leave
{
    public partial class LeaveApp : MetroFramework.Forms.MetroForm
    {
        private string sessionID;

        public LeaveApp(string empid)
        {
            this.sessionID = empid;
            InitializeComponent();
            LoadInfo();
        }

        public void  LoadInfo()
        {
            try
            {
           
                Connection CN = new Connection();
                CN.thisConnection.Open();

                OracleCommand thisCommand = new OracleCommand();
                thisCommand.Connection = CN.thisConnection;
                thisCommand.CommandText = "SELECT * FROM users WHERE employeeid='" + sessionID + "'";
                OracleDataReader thisReader = thisCommand.ExecuteReader();
                if (thisReader.Read())
                {
                    label13.Text = thisReader["name"].ToString();
                    label14.Text = thisReader["type"].ToString();
                    label15.Text = thisReader["join"].ToString();
                }

                CN.thisConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void metroTabPage4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 oform = new Form1();
            this.Hide();
            oform.Show();
        }

        private void metroTextBox8_Click(object sender, EventArgs e)
        {

        }

        private void metroGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void metroLabel15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 oform = new Form1();
            this.Hide();
            oform.Show();
    
        }
    }
}
