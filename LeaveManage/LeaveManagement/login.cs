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
    public partial class login : MetroFramework.Forms.MetroForm
    {
        public login()
        {
            InitializeComponent();
            metroTextBox3.PasswordChar = '*';
        }

        private void logincheck()
        {
            try
            {
                Connection CN = new Connection();
                CN.thisConnection.Open();

                OracleCommand thisCommand = new OracleCommand();
                thisCommand.Connection = CN.thisConnection;
                thisCommand.CommandText = "SELECT * FROM users WHERE username='" + metroTextBox2.Text + "' AND password='" + metroTextBox3.Text + "'and employeeid='" + metroTextBox1.Text + "'";
                
                OracleDataReader thisReader = thisCommand.ExecuteReader();

                if (thisReader.Read())
                {
                    string type = thisReader["TYPE"].ToString();
                    if (type == "Generel")
                    {
                        LeaveApp oform = new LeaveApp(thisReader["employeeid"].ToString());
                        this.Hide();
                        oform.Show();
                    }
                    else if (type == "Admin")
                    {
                        AdminPanel oform = new AdminPanel(thisReader["employeeid"].ToString());
                        this.Hide();
                        oform.Show();
                    }
                }               
                else
                {
                    MessageBox.Show("Username or Password Incorrect");
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
            Form1 oform = new Form1();
            oform.Show();
            this.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.logincheck();
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Connection CN = new Connection();
                CN.thisConnection.Open();

                OracleCommand thisCommand = new OracleCommand();
                thisCommand.Connection = CN.thisConnection;
                thisCommand.CommandText = "SELECT username from users WHERE employeeid='" + metroTextBox1.Text + "'" ;

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
    }
}
