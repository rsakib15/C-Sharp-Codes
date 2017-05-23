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
  
    public partial class LeaveRequest : MetroFramework.Forms.MetroForm
    {
        private string session;
        private string user;

        public LeaveRequest(string s)
        {
            session = s;
            InitializeComponent();
            LoadLeaveLog();
        }
        public void LoadLeaveLog()
        {
            
            try
            {
                Connection CN = new Connection();
                CN.thisConnection.Open();
                OracleCommand thisCommand = CN.thisConnection.CreateCommand();

                OracleCommand nameCommand = CN.thisConnection.CreateCommand();

                nameCommand.CommandText = "SELECT * FROM users WHERE employeeid='" + session + "'";

                OracleDataReader nameReader = nameCommand.ExecuteReader();
                
                while (nameReader.Read()) { 
                    user = nameReader["USERNAME"].ToString();
                }


                thisCommand.CommandText = "SELECT * FROM leave WHERE ADMITTEDBY='" + user + "' AND status= 'Pending'";
                

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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            AdminPanel l = new AdminPanel(session);
            l.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            string firstCellValue = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            string secondCellValue = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
            Approval l = new Approval(session,firstCellValue,secondCellValue);
            l.Show();
            //this.Hide();
        }

    }
}
