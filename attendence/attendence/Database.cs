using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace attendence
{
    class Database
    {
        private string connection = "Data Source=DESKTOP-KTG5PL2;" + "Initial Catalog=attendence;" + "Integrated Security=SSPI";
        public bool Adduser(String name, String id)
        {
            SqlConnection thisConnection = new SqlConnection(connection);
            thisConnection.Open();

            SqlDataAdapter thisAdapter = new SqlDataAdapter("SELECT * FROM users", thisConnection);
            SqlCommandBuilder thisBuilder = new SqlCommandBuilder(thisAdapter);
            DataSet thisDataSet = new DataSet();
            thisAdapter.Fill(thisDataSet, "users");

            DataRow thisRow = thisDataSet.Tables["users"].NewRow();
            try
            {
                thisRow["id"] = id;
                thisRow["name"] = name;

                thisDataSet.Tables["users"].Rows.Add(thisRow);
                thisAdapter.Update(thisDataSet, "users");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            thisConnection.Close();
            return false;
        }

        public bool SaveAttendence(string date, string std)
        {

            if (checkDone(date))
            {
                updateAttendence(date, std);
            }
            else
            {
                SqlConnection thisConnection = new SqlConnection(connection);
                thisConnection.Open();

                SqlDataAdapter thisAdapter = new SqlDataAdapter("SELECT * FROM attend", thisConnection);
                SqlCommandBuilder thisBuilder = new SqlCommandBuilder(thisAdapter);
                DataSet thisDataSet = new DataSet();
                thisAdapter.Fill(thisDataSet, "attend");

                DataRow thisRow = thisDataSet.Tables["attend"].NewRow();
                try
                {
                    thisRow["date"] = date;
                    thisRow["student"] = std;

                    thisDataSet.Tables["attend"].Rows.Add(thisRow);
                    thisAdapter.Update(thisDataSet, "attend");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                thisConnection.Close();
                return false;
            }
            return true;
        }

        public void updateAttendence(string date, string std)
        {
            SqlConnection thisConnection = new SqlConnection(connection);
            thisConnection.Open();

            SqlCommand thisCommand = new SqlCommand();
            thisCommand.Connection = thisConnection;

            using (SqlCommand cmd = new SqlCommand("UPDATE attend SET date=@date,student=@std" +
                    " WHERE date=@date", thisConnection))
            {
                cmd.Parameters.AddWithValue("@date", date);
                cmd.Parameters.AddWithValue("@std", std);
                cmd.ExecuteNonQuery();
                thisConnection.Close();
            }

        }


        public bool checkDone(string date)
        {
            SqlConnection thisConnection = new SqlConnection(connection);
            thisConnection.Open();

            SqlCommand thisCommand = new SqlCommand();
            thisCommand.Connection = thisConnection;
            thisCommand.CommandText = "SELECT * FROM attend WHERE date='" + date + "'";
            SqlDataReader thisReader = thisCommand.ExecuteReader();

            if (thisReader.Read())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int getTotalAttendence(string id)
        {
            int count = 0;
            SqlConnection thisConnection = new SqlConnection(connection);
            thisConnection.Open();

            SqlCommand thisCommand = new SqlCommand();
            thisCommand.Connection = thisConnection;
            thisCommand.CommandText = "SELECT * FROM attend";
            SqlDataReader thisReader = thisCommand.ExecuteReader();

            while (thisReader.Read())
            {
                string str = thisReader["student"].ToString();
                string[] tokens=str.Split(',');

                for(int i = 0; i < tokens.Length; i++)
                {
                    if (tokens[i] == id)
                    {
                        count++;
                    }
                }

            }

            return count;
        }
    }
}
