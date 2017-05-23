using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace attendence
{
    public partial class TakeAttendence : Form
    {

        ArrayList ser = new ArrayList();
        ArrayList id = new ArrayList();
        ArrayList name = new ArrayList();
        ArrayList checkw = new ArrayList();
        ArrayList studentlist = new ArrayList();
        int i = 0;
        String std="";
        String sDate;

        public TakeAttendence()
        {
            InitializeComponent();
            init();
            //Really Love to work with you.I hope to see you soon.
        }
        public void init()
        {
            label1.Text = "Date : ";
            sDate = DateTime.Now.ToString("dd/MM/yyyy");
            label2.Text = sDate;
            getAllStudents();
        }

        public void getAllStudents()
        {
            string connection = "Data Source=DESKTOP-KTG5PL2;" + "Initial Catalog=attendence;" + "Integrated Security=SSPI";
            SqlConnection thisConnection = new SqlConnection(connection);
            thisConnection.Open();

            SqlCommand thisCommand = new SqlCommand();
            thisCommand.Connection = thisConnection;
            thisCommand.CommandText = "SELECT * FROM users";
            SqlDataReader thisReader = thisCommand.ExecuteReader();

            
            int distance = 0;


            while (thisReader.Read()){
                i++;
                Label serial = new Label();
                Label idlabel = new Label();
                Label namelabel = new Label();
                CheckBox check = new CheckBox();

                this.Controls.Add(serial);
                this.Controls.Add(idlabel);
                this.Controls.Add(namelabel);
                this.Controls.Add(check);

                serial.BackColor = System.Drawing.Color.White;
                serial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                serial.Location = new System.Drawing.Point(381, 92);
                serial.Name = i.ToString();
                serial.Size = new System.Drawing.Size(28, 29);
                serial.TabIndex = 2;
                serial.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                serial.Location = new System.Drawing.Point(240, 90 + distance);
                serial.Text = i.ToString();
                ser.Add(i);

                idlabel.BackColor = System.Drawing.Color.White;
                idlabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                idlabel.Location = new System.Drawing.Point(381, 92);
                idlabel.Name = thisReader["id"].ToString(); ;
                idlabel.Size = new System.Drawing.Size(100, 29);
                idlabel.TabIndex = 2;
                idlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                idlabel.Location = new System.Drawing.Point(275, 90 + distance);
                idlabel.Text = thisReader["id"].ToString();
                id.Add(thisReader["id"].ToString());
                
                namelabel.BackColor = System.Drawing.Color.White;
                namelabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                namelabel.Location = new System.Drawing.Point(381, 92);
                namelabel.Name = thisReader["name"].ToString(); ;
                namelabel.Size = new System.Drawing.Size(190, 29);
                namelabel.TabIndex = 2;
                namelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                namelabel.Location = new System.Drawing.Point(381, 90 + distance);
                namelabel.Text = thisReader["name"].ToString();
                name.Add(thisReader["name"].ToString());


                check.Location = new System.Drawing.Point(381, 92);
                check.Size = new System.Drawing.Size(40, 29);
                check.TabIndex = 2;
                check.Name = thisReader["id"].ToString();
                check.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                check.Location = new System.Drawing.Point(600, 92 + distance);
                check.CheckedChanged += new System.EventHandler(this.cb_CheckedChanged);

                distance += 50;
            }




        }

        private void cb_CheckedChanged(Object sender, EventArgs e)
        {
            int flag = 0;
            string NameSet = (sender as CheckBox).Name;
            for (int i = 0; i < studentlist.Count; i++)
            {
                if (studentlist[i].ToString() == NameSet)
                {
                    studentlist.Remove(NameSet);

                    flag = 1;
                    break;
                }
            }
            if (flag == 0)
            {
                studentlist.Add(NameSet);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Database d = new Database();
            string std="";
            for (int i = 0; i < studentlist.Count; i++)
            {
                if (i == 0)
                {
                    std += studentlist[i]; 
                }
                else
                {
                    std += ","+studentlist[i];
                }
            }
            d.SaveAttendence(sDate, std);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Options op = new Options();
            this.Hide();
            op.Show();
        }
    }
}
