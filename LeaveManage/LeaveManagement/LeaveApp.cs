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
        private string userType;

        public LeaveApp(string empid)
        {
            this.sessionID = empid;
            InitializeComponent();
            LoadInfo();
            LeaveInitialize();
            LoadLeaveLog();
            LoadLeaveHistory();
            AdminLoad();

        }

        private void AdminLoad()

        {

            Connection sv = new Connection();
            sv.thisConnection.Open();

            OracleCommand seqCommand = new OracleCommand();
            seqCommand.Connection = sv.thisConnection;
            seqCommand.CommandText = "SELECT * FROM users where type='Admin'";
            OracleDataReader thisReader = seqCommand.ExecuteReader();
            thisReader = seqCommand.ExecuteReader();
            while (thisReader.Read())
            {
                metroComboBox2.Items.Add(thisReader[1].ToString());
            }
            sv.thisConnection.Close();

        }

        public void InsertNewRequest()
        {
            Connection sv = new Connection();
            sv.thisConnection.Open();
            OracleDataAdapter thisAdapter = new OracleDataAdapter("SELECT * FROM Leave", sv.thisConnection);
            OracleCommandBuilder thisBuilder = new OracleCommandBuilder(thisAdapter);
            DataSet thisDataSet = new DataSet();
            thisAdapter.Fill(thisDataSet, "data");
            DataRow thisRow = thisDataSet.Tables["data"].NewRow();
            try
            {
                OracleCommand seqCommand = new OracleCommand();
                seqCommand.Connection = sv.thisConnection;
                seqCommand.CommandText = "select seq_leave.nextval from Leave";
                OracleDataReader thisReader = seqCommand.ExecuteReader();
                thisReader = seqCommand.ExecuteReader();
                int nextSeq = 0;
                if (thisReader.Read())
                {
                    nextSeq = Convert.ToInt32(thisReader["NEXTVAL"]);
                }
                thisRow["LEAVEID"] = nextSeq;
                thisRow["EMPLOYEEID"] = metroTextBox4.Text;
                thisRow["FROMDATE"] = metroDateTime1.Text;
                thisRow["TODATE"] = metroDateTime2.Text;
                thisRow["PURPOSE"] = metroTextBox8.Text;
                thisRow["APPLIEDON"] = DateTime.Now.ToString("dd-MM-yyyy");
                thisRow["ADMITTEDBY"] = metroComboBox2.Text;
                thisRow["STATUS"] = "Pending";

                thisDataSet.Tables["data"].Rows.Add(thisRow);

                thisAdapter.Update(thisDataSet, "data");
                sv.thisConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadLeaveHistory()
        {
            try
            {
                Connection CN = new Connection();
                CN.thisConnection.Open();
                OracleCommand thisCommand = CN.thisConnection.CreateCommand();
                thisCommand.CommandText = "SELECT * FROM leave WHERE employeeid='" + sessionID + "' AND status!= 'Pending'";
                OracleDataReader thisReader = thisCommand.ExecuteReader();
                dataGridView1.Rows.Clear();
                while (thisReader.Read())
                {
                    dataGridView1.Rows.Add(thisReader["leaveid"].ToString(), thisReader["fromdate"].ToString(), thisReader["todate"].ToString(), thisReader["appliedOn"].ToString(), thisReader["admittedby"].ToString(), thisReader["status"].ToString());
                }

                CN.thisConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void LoadLeaveLog()
        {
            try
            {
                Connection CN = new Connection();
                CN.thisConnection.Open();
                OracleCommand thisCommand = CN.thisConnection.CreateCommand();
                thisCommand.CommandText = "SELECT * FROM leave WHERE employeeid='" + sessionID + "' AND status= 'Pending'";
                OracleDataReader thisReader = thisCommand.ExecuteReader();
                dataGridView2.Rows.Clear();
                while (thisReader.Read())
                {
                    dataGridView2.Rows.Add(thisReader["leaveid"].ToString(), thisReader["fromdate"].ToString(), thisReader["todate"].ToString(), thisReader["appliedOn"].ToString(), thisReader["admittedby"].ToString(), thisReader["status"].ToString());
                }

                CN.thisConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void LeaveInitialize()
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
                    metroTextBox6.Text = thisReader["name"].ToString();
                    metroTextBox4.Text = thisReader["employeeid"].ToString();
                    metroTextBox1.Text = DateTime.Now.ToString("dd-MM-yyyy");
                    metroTextBox5.Text = "Not Applied Yet";
                }          
                CN.thisConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
                    userType= thisReader["type"].ToString();
                }
                OracleCommand timeCommand = new OracleCommand();
                timeCommand.Connection = CN.thisConnection;
                timeCommand.CommandText = "SELECT * FROM dailywork WHERE employeeid='" + sessionID + "'";
                OracleDataReader timeReader = timeCommand.ExecuteReader();
                if (timeReader.Read())
                {
                    int p = Convert.ToInt32(timeReader["LENGTH"].ToString());
                    MessageBox.Show(p.ToString());
                    if (p==0)
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 oform = new Form1();
            this.Hide();
            oform.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 oform = new Form1();
            this.Hide();
            oform.Show();    
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            InsertNewRequest();     
            LoadLeaveLog();
            LoadLeaveHistory();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 oform = new Form1();
            this.Hide();
            oform.Show();
        }
    }
}
