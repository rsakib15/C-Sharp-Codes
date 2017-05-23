using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessAccessLayer;
using EntityLayer;

namespace PresentationLayer
{
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Edit_Load(object sender, EventArgs e)
        {
            panel2.Hide();
            panel3.Hide();
            panel4.Hide();
            panel5.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (hospitalrb.Checked == true)
            {
                panel2.Show();
                if (namerb.Checked == true)
                {
                    HospitalService hospitalService = new HospitalService();
                    Hospital hospital = new Hospital();
                    hospital.Id = int.Parse(textBox1.Text);
                    hospital.Name = textBox2.Text;
                    if (hospitalService.EditName(hospital) == 1)
                    {
                        MessageBox.Show("Name Upadated");
                    }
                }
                else if (addressrb.Checked == true)
                {
                    HospitalService hospitalService = new HospitalService();
                    Hospital hospital = new Hospital();
                    hospital.Id = int.Parse(textBox4.Text);
                    hospital.Address = textBox3.Text;
                    if (hospitalService.EditAddress(hospital) == 1)
                    {
                        MessageBox.Show("Name Upadated");
                    }
                }
                else if (phnoerb.Checked == true)
                {
                    HospitalService hospitalService = new HospitalService();
                    Hospital hospital = new Hospital();
                    hospital.Id = int.Parse(textBox6.Text);
                    hospital.Phone = textBox5.Text;
                    if (hospitalService.EditPhone(hospital) == 1)
                    {
                        MessageBox.Show("Name Upadated");
                    }
                }
                else
                {
                    HospitalService hospitalService = new HospitalService();
                    Hospital hospital = new Hospital();
                    hospital.Id = int.Parse(textBox8.Text);
                    hospital.Phone = textBox7.Text;
                    if (hospitalService.EditPhone(hospital) == 1)
                    {
                        MessageBox.Show("Name Upadated");
                    }
                }

            }
        }
    }
}
