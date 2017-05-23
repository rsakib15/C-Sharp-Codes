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
    public partial class EnterExitTime : MetroFramework.Forms.MetroForm
    {
        public EnterExitTime()
        {
            InitializeComponent();
            VLoad();
            metroTextBox6.PasswordChar = '*';
        }

        public void VLoad()
        {
            metroButton1.Visible = false;
            metroButton2.Visible = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 oform = new Form1();
            oform.Show();
            this.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Connection sv = new Connection();
            sv.thisConnection.Open();

            OracleDataAdapter thisAdapter = new OracleDataAdapter("SELECT * FROM dailywork", sv.thisConnection);
            OracleCommandBuilder thisBuilder = new OracleCommandBuilder(thisAdapter);

            DataSet thisDataSet = new DataSet();
            thisAdapter.Fill(thisDataSet, "data");

            DataRow thisRow = thisDataSet.Tables["data"].NewRow();
            try
            {

                thisRow["DATETIME"] = DateTime.Now.ToString("dd-MM-yyyy");
                thisRow["EMPLOYEEID"] = metroTextBox1.Text;
                thisRow["STARTTIME"] = DateTime.Now.ToString("HH:mm:ss");
                thisRow["LENGTH"] = '0' ;
                thisDataSet.Tables["data"].Rows.Add(thisRow);

                thisAdapter.Update(thisDataSet, "data");
                MessageBox.Show("Entry Successful");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sv.thisConnection.Close();


            Form1 oform = new Form1();
            oform.Show();
            this.Hide();
        }

        private int lengthCount()
        {
            try
            {
                
                string start = "";
                string end = "";
                Connection CN = new Connection();
                CN.thisConnection.Open();

                OracleCommand thisCommand = new OracleCommand();
                thisCommand.Connection = CN.thisConnection;
                thisCommand.CommandText = "SELECT * FROM dailywork WHERE EmployeeID ='" + metroTextBox1.Text + "' AND DateTime ='" + DateTime.Now.ToString("dd-MM-yyyy") + "'";

                OracleDataReader thisReader = thisCommand.ExecuteReader();
                if (thisReader.Read())
                {
                    start = thisReader["STARTTIME"].ToString();
                    end = thisReader["ENDTIME"].ToString();
                }

                String[] endtoken = end.Split(':');
                String[] starttoken = start.Split(':');

                int second;
                int min;
                int hour;

                if (Convert.ToInt32(endtoken[2]) >= Convert.ToInt32(starttoken[2]))
                {
                    second = Convert.ToInt32(endtoken[2]) - Convert.ToInt32(starttoken[2]);
                    
                }
                
                else
                {
                    endtoken[2] = ((Convert.ToInt32(endtoken[2])) + 60).ToString();
                    endtoken[1] = ((Convert.ToInt32(endtoken[1])) - 1).ToString();
                    second = Convert.ToInt32(endtoken[2]) - Convert.ToInt32(starttoken[2]);
                }


                if (Convert.ToInt32(endtoken[1]) >= Convert.ToInt32(starttoken[1]))
                {
                    min = Convert.ToInt32(endtoken[1]) - Convert.ToInt32(starttoken[1]);
                }
                else
                {
                    endtoken[1] = ((Convert.ToInt32(endtoken[1])) + 60).ToString();
                    endtoken[0] = ((Convert.ToInt32(endtoken[0])) - 1).ToString();
                    min = Convert.ToInt32(endtoken[1]) - Convert.ToInt32(starttoken[1]);
                }


                hour = Convert.ToInt32(endtoken[0]) - Convert.ToInt32(starttoken[0]);

                int total = hour * 3600 + min * 60 + second;

 
                
                CN.thisConnection.Close();
                return total;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return 0;
            


        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            Connection sv = new Connection();
            sv.thisConnection.Open();
            OracleCommand thisCommand = sv.thisConnection.CreateCommand();

            thisCommand.Connection = sv.thisConnection;

            thisCommand.CommandText =
                "update dailywork set ENDTIME = '" + DateTime.Now.ToString("HH:mm:ss") + "' where employeeid= '" + metroTextBox1.Text + "'";

            try
            {
                thisCommand.ExecuteNonQuery();
                MessageBox.Show("Exit Time Included");
                this.Hide();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            int len = lengthCount();

            thisCommand.CommandText =
                "update dailywork set LENGTH = '" + len.ToString() + "' where employeeid= '" + metroTextBox1.Text + "'";

            thisCommand.Connection = sv.thisConnection;
            thisCommand.CommandType = CommandType.Text;

            try
            {
                thisCommand.ExecuteNonQuery();
                MessageBox.Show("Exit Time Included");
                this.Hide();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            

            sv.thisConnection.Close();

            Form1 oform = new Form1();
            oform.Show();
       
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Connection CN = new Connection();
                CN.thisConnection.Open();

                OracleCommand thisCommand = new OracleCommand();
                thisCommand.Connection = CN.thisConnection;
                thisCommand.CommandText = "SELECT username from users WHERE employeeid='" + metroTextBox1.Text + "'";

                OracleDataReader thisReader = thisCommand.ExecuteReader();
                if (thisReader.Read())
                {
                    metroTextBox2.Text = thisReader["username"].ToString();
                }

                CN.thisConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        private void metroTextBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Connection CN = new Connection();
                CN.thisConnection.Open();

                OracleCommand thisCommand = new OracleCommand();
                thisCommand.Connection = CN.thisConnection;
                thisCommand.CommandText = "SELECT employeeid from users WHERE username='" + metroTextBox2.Text + "'";

                OracleDataReader thisReader = thisCommand.ExecuteReader();
                if (thisReader.Read())
                {
                    metroTextBox1.Text = thisReader["employeeid"].ToString();
                }

                CN.thisConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void metroTextBox6_TextChanged(object sender, EventArgs e)
        {
            try { 
                Connection CN = new Connection();
                CN.thisConnection.Open();


                OracleCommand thisCommand = new OracleCommand();
                thisCommand.Connection = CN.thisConnection;
                thisCommand.CommandText = "SELECT * FROM users WHERE username='" + metroTextBox2.Text + "' AND employeeid='" + metroTextBox1.Text + "'and PIN='" + metroTextBox6.Text + "'";
                OracleDataReader thisReader = thisCommand.ExecuteReader();
                if (thisReader.Read())
                {
                    OracleCommand getCommand = new OracleCommand();
                    getCommand.Connection = CN.thisConnection;
                    thisCommand.CommandText = "SELECT * FROM dailywork WHERE EmployeeID ='" + metroTextBox1.Text + "' AND DateTime ='" + DateTime.Now.ToString("dd-MM-yyyy") + "'";
                    OracleDataReader dateReader = thisCommand.ExecuteReader();

                    thisReader = thisCommand.ExecuteReader();
                    if (!dateReader.Read())
                    {
                        metroButton1.Visible = true;
                        metroButton2.Visible = false;
                    }
                    else if (dateReader["STARTTIME"].ToString() != null)
                    {
                        metroButton2.Visible = true;
                        metroButton1.Visible = false;
                    }
                }

                CN.thisConnection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

}
    }
}
