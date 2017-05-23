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
    public partial class ViewAllStudentData : Form
    {
        public ViewAllStudentData()
        {
            InitializeComponent();
        }

        private void ViewAllStudentData_Load(object sender, EventArgs e)
        {
            connection CN = new connection();
            CN.thisConnection.Open();

            OracleCommand thisCommand = CN.thisConnection.CreateCommand();

            thisCommand.CommandText =
                "SELECT * FROM data order by id";

            OracleDataReader thisReader = thisCommand.ExecuteReader();


            while (thisReader.Read())
            {
                ListViewItem lsvItem = new ListViewItem();
                lsvItem.Text = thisReader["id"].ToString();
                lsvItem.SubItems.Add(thisReader["name"].ToString());
                lsvItem.SubItems.Add(thisReader["course"].ToString());
                lsvItem.SubItems.Add(thisReader["mark"].ToString());




                listView1.Items.Add(lsvItem);
            }


            CN.thisConnection.Close();
        }
    }
}
