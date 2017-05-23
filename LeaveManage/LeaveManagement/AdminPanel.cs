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


    public partial class AdminPanel : MetroFramework.Forms.MetroForm
    {
        private string sessionID;
        private string userType;

        public AdminPanel(string session)

        {
            this.sessionID = session;
            InitializeComponent();
            LoadInfo();
        }

        public void LoadInfo()
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
                    userType = thisReader["type"].ToString();
                }
                OracleCommand timeCommand = new OracleCommand();
                timeCommand.Connection = CN.thisConnection;
                timeCommand.CommandText = "SELECT * FROM dailywork WHERE employeeid='" + sessionID + "'";
                OracleDataReader timeReader = timeCommand.ExecuteReader();
                if (timeReader.Read())
                {
                    int p = Convert.ToInt32(timeReader["LENGTH"].ToString());
                    //MessageBox.Show(p.ToString());
                    if (p == 0)
                    {
                        int len = 0;
                        int min = 0;
                        label6.Text = len.ToString() + " Hours " + min.ToString() + " Minutes ";
                    }
                    else
                    {
                        int len = Convert.ToInt32(timeReader["LENGTH"]) / 3600;
                        int min = Convert.ToInt32(timeReader["LENGTH"]) / 60;
                        label6.Text = len.ToString() + " Hours " + min.ToString() + " Minutes ";
                    }


                }
                OracleCommand totalCommand = new OracleCommand();
                totalCommand.Connection = CN.thisConnection;
                totalCommand.CommandText = "SELECT SUM(Length) FROM dailywork WHERE employeeid='" + sessionID + "'";
                OracleDataReader totalReader = totalCommand.ExecuteReader();
                if (totalReader.Read())
                {

                    int len = Convert.ToInt32(totalReader["SUM(Length)"]) / 3600;
                    int min = Convert.ToInt32(totalReader["SUM(Length)"]) / 60;
                    label17.Text = len.ToString() + " Hours " + min.ToString() + " Minutes ";
                }
                CN.thisConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 l = new Form1();
            l.Show();
            this.Hide();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            LeaveRequest oform = new LeaveRequest(sessionID);
            this.Hide();
            oform.Show();
        }

        private void metroTile4_Click(object sender, EventArgs e)
        {
            WorkerList l = new WorkerList(sessionID);
            l.Show();
            this.Hide();
        }
    }
}
