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
    public partial class WorkerList : MetroFramework.Forms.MetroForm
    {
        string session;
        public WorkerList(string s)
        {
            session = s;
            InitializeComponent();
            LoadWorker();
        }

        public void LoadWorker()
        {
            Connection CN = new Connection();
            CN.thisConnection.Open();
            OracleCommand thisCommand = CN.thisConnection.CreateCommand();
            try {
                thisCommand.CommandText = "SELECT * FROM users where type != 'Admin'";
                OracleDataReader thisReader = thisCommand.ExecuteReader();
                dataGridView2.Rows.Clear();

                while (thisReader.Read())
                {
                    dataGridView2.Rows.Add(thisReader["Name"].ToString(), thisReader["TYPE"].ToString(), thisReader["JOIN"].ToString());
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
    }
}
