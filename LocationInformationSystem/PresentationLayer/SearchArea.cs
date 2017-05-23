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
    public partial class SearchArea : Form
    {
        public SearchArea()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (hospitalrb.Checked == true)
            {
                List<Hospital> hospitalList = new List<Hospital>();
                Hospital hospital = new Hospital();
                hospital.Area = textBox1.Text;
                HospitalService hospitalService = new HospitalService();
                hospitalList = hospitalService.GetByArea(hospital);
                dataGridView1.DataSource = hospitalList;
            }
            else if (pharmacyrb.Checked == true)
            {
                List<Pharmacy> pharmacyList = new List<Pharmacy>();
                Pharmacy pharmacy = new Pharmacy();
                pharmacy.Area = textBox1.Text;
                PharmacyService pharmacyService = new PharmacyService();
                pharmacyList = pharmacyService.GetByArea(pharmacy);
                dataGridView1.DataSource = pharmacyList;
            }
            else if (ShoppingMallrb.Checked == true)
            {
                List<ShoppingMall> shoppingMallList = new List<ShoppingMall>();
                ShoppingMall shoppingMall = new ShoppingMall();
                shoppingMall.Area = textBox1.Text;
                ShoppingMallService shoppingMallService = new ShoppingMallService();
                shoppingMallList = shoppingMallService.GetByArea(shoppingMall);
                dataGridView1.DataSource = shoppingMallList;
            }
            else
            {
                List<Restaurant> restaurantList = new List<Restaurant>();
                Restaurant restaurant = new Restaurant();
                restaurant.Area = textBox1.Text;
                RestaurantService resturaunService = new RestaurantService();
                restaurantList = resturaunService.GetByArea(restaurant);
                dataGridView1.DataSource = restaurantList;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartForm startform=new StartForm();
            startform.Show();
          
        }
    }
}