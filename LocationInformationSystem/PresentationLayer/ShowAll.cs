using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using BusinessAccessLayer;

namespace PresentationLayer
{
    public partial class ShowAll : Form
    {
        public ShowAll()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (hospitalrb.Checked == true)
            {
                List<Hospital> hospitalList = new List<Hospital>();
                Hospital hospital = new Hospital();
                HospitalService hospitalService = new HospitalService();
                hospitalList = hospitalService.GetAll();
                dataGridView1.DataSource = hospitalList;
            }
            else if (pharmacyrb.Checked == true)
            {
                List<Pharmacy> pharmacyList = new List<Pharmacy>();
                Pharmacy pharmacy = new Pharmacy();
                PharmacyService pharmacyService = new PharmacyService();
                pharmacyList = pharmacyService.GetAll();
                dataGridView1.DataSource = pharmacyList;
            }
            else if (ShoppingMallrb.Checked == true)
            {
                List<ShoppingMall> shoppingMallList = new List<ShoppingMall>();
                ShoppingMall shoppingMall = new ShoppingMall();
                ShoppingMallService shoppingMallService = new ShoppingMallService();
                shoppingMallList = shoppingMallService.GetAll();
                dataGridView1.DataSource = shoppingMallList;
            }
            else
            {
                List<Restaurant> restaurantList = new List<Restaurant>();
                Restaurant restaurant = new Restaurant();
                RestaurantService resturaunService = new RestaurantService();
                restaurantList = resturaunService.GetAll();
                dataGridView1.DataSource = restaurantList;
            }
        }

        private void hospitalrb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pharmacyrb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Restarauntrb_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm startform = new StartForm();
            startform.Show();
            
        }
    }
}
