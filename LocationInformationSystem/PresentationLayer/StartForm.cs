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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }
   

        private void StartForm_Load(object sender, EventArgs e)
        {
            panel1.Hide();
            panel3.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            panel3.Show();
            //panel2.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            AdminService adminService = new AdminService();
            List<Admin> adminList = new List<Admin>();
            adminList = adminService.GetAll();
            for(int i = 0; i < adminList.Count; i++)
            {
                if (adminList[i].Password == AdminPass.Text)
                {
                    panel1.Show();
                }
            }
        }

        private void AdminPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddForm addForm = new AddForm();
            addForm.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchUser search = new SearchUser();
            search.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditAddress editaddress = new EditAddress();
            editaddress.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShowAll showAll = new ShowAll();
            this.Hide();
            showAll.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            SearchArea searchArea = new SearchArea();
            this.Hide();
            searchArea.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Edit edit = new Edit();
            this.Hide();
            edit.Show();
        }
    }
}
