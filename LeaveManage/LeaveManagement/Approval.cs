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
    public partial class Approval : MetroFramework.Forms.MetroForm
    {
        string SessionID;
        string leave1;
        string leave2;
        public Approval(string session,string leave1,string leave2)
        {
            InitializeComponent();
            this.SessionID = session;
            this.leave1 = leave1;
            this.leave2 = leave2;
            showInfo();
        }
        public void showInfo()
        {
            Connection CN = new Connection();
            CN.thisConnection.Open();
            OracleCommand thisCommand = CN.thisConnection.CreateCommand();
            try
            {
                thisCommand.CommandText = "SELECT * FROM Leave where leaveid= '" + leave1 + "'";
                OracleDataReader thisReader = thisCommand.ExecuteReader();

                while (thisReader.Read())
                {
                    metroTextBox1.Text = thisReader["LeaveId"].ToString();
                    metroTextBox2.Text = thisReader["EmployeeID"].ToString();
                    metroTextBox3.Text = thisReader["FROMDATE"].ToString();
                    metroTextBox4.Text = thisReader["TODATE"].ToString();
                    textBox1.Text = thisReader["PURPOSE"].ToString();
                }

                CN.thisConnection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
           }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Connection sv = new Connection();
            sv.thisConnection.Open();
            OracleCommand thisCommand = sv.thisConnection.CreateCommand();

            thisCommand.CommandText =
                "update leave set STATUS = 'Approved' where leaveid= '" + leave1 + "'";

            thisCommand.Connection = sv.thisConnection;
            thisCommand.CommandType = CommandType.Text;
            //For Insert Data Into Oracle//
            try
            {
                thisCommand.ExecuteNonQuery();
                MessageBox.Show("Leave Request Accepted !!!");
                this.Hide();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            sv.thisConnection.Close();
            this.Hide();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Connection sv = new Connection();
            sv.thisConnection.Open();
            OracleCommand thisCommand = sv.thisConnection.CreateCommand();

            thisCommand.CommandText =
                "update leave set STATUS = 'Cancel' where leaveid= '" + leave1 + "'";

            thisCommand.Connection = sv.thisConnection;
            thisCommand.CommandType = CommandType.Text;
            //For Insert Data Into Oracle//
            try
            {
                thisCommand.ExecuteNonQuery();
                MessageBox.Show("Leave Request Rejected !!!");
                this.Hide();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            sv.thisConnection.Close();
            this.Hide();
        }
    }
}
