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
    public partial class Registration : MetroFramework.Forms.MetroForm
    {
        public Registration()
        {
            InitializeComponent();
            metroTextBox2.PasswordChar = '*';
            metroTextBox1.PasswordChar = '*';
            metroTextBox5.PasswordChar = '*';
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form1 l = new Form1();
            l.Show();
            this.Hide();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            Connection sv = new Connection();
            sv.thisConnection.Open();

            OracleDataAdapter thisAdapter = new OracleDataAdapter("SELECT * FROM users", sv.thisConnection);
            OracleCommandBuilder thisBuilder = new OracleCommandBuilder(thisAdapter);

            DataSet thisDataSet = new DataSet();
            thisAdapter.Fill(thisDataSet, "data");

            DataRow thisRow = thisDataSet.Tables["data"].NewRow();
            try
            {

                OracleCommand seqCommand = new OracleCommand();
                seqCommand.Connection = sv.thisConnection;
                seqCommand.CommandText = "select seq_person.nextval from users";
                OracleDataReader thisReader = seqCommand.ExecuteReader();
                thisReader = seqCommand.ExecuteReader();

                int nextSeq=0;
                if (thisReader.Read())
                {
                    nextSeq = Convert.ToInt32(thisReader["NEXTVAL"]);
                }

                thisRow["EmployeeID"] = nextSeq;
                thisRow["Username"] = metroTextBox4.Text;
                thisRow["Type"] = metroComboBox1.Text;
                thisRow["Name"] = metroTextBox6.Text;
                thisRow["Join"] = DateTime.Now.ToString("dd-MM-yyyy");
                thisRow["Password"] = metroTextBox1.Text;     
                thisRow["PIN"] = metroTextBox5.Text;
                thisDataSet.Tables["data"].Rows.Add(thisRow);
                thisAdapter.Update(thisDataSet, "data");
                MessageBox.Show("Submitted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                MessageBox.Show(metroComboBox1.Text);
            }
            sv.thisConnection.Close();
            Form1 l = new Form1();
            l.Show();
            this.Hide();
        }


        private void metroButton2_Click(object sender, EventArgs e)
        {
            Form1 l = new Form1();
            l.Show();
            this.Hide();
        }
    }
}