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
    public partial class InsertData : Form
    {
        public InsertData()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            connection sv = new connection();
            sv.thisConnection.Open();

            OracleDataAdapter thisAdapter = new OracleDataAdapter("SELECT * FROM data", sv.thisConnection);

            OracleCommandBuilder thisBuilder = new OracleCommandBuilder(thisAdapter);

            DataSet thisDataSet = new DataSet();
            thisAdapter.Fill(thisDataSet, "data");

            DataRow thisRow = thisDataSet.Tables["data"].NewRow();
            try
            {

                thisRow["id"] = textBox1.Text;
                thisRow["name"] = textBox2.Text;
                thisRow["course"] = textBox3.Text;
                thisRow["mark"] = textBox4.Text;



                thisDataSet.Tables["data"].Rows.Add(thisRow);



                thisAdapter.Update(thisDataSet, "data");
                MessageBox.Show("Submitted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            sv.thisConnection.Close();

            DbFeatures ob = new DbFeatures();
            ob.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DbFeatures ob = new DbFeatures();
            ob.Show();
            this.Hide();
        }
    }
}
