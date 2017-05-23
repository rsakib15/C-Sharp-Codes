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
    public partial class AddForm : Form
    {
        
        public AddForm()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void AddForm_Load(object sender, EventArgs e)
        {
            //panel2.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (hospitalradiobutton.Checked)
            {
                //button3.Hide();
                //panel2.Show();
                Hospital hospital = new Hospital();
                hospital.Id = int.Parse(textBox1.Text);
                hospital.Name = textBox2.Text;
                hospital.Address = textBox3.Text;
                hospital.Phone = textBox4.Text;
                hospital.Area = textBox5.Text;
                HospitalService hospitalSercvice = new HospitalService();
                if (hospitalSercvice.Add(hospital) > 0)
                {
                    MessageBox.Show("New record added");
                }
            }
            else if (phramacyradiobutton.Checked)
            {
                Pharmacy pharmacy = new Pharmacy();
                pharmacy.Id = int.Parse(textBox1.Text);
                pharmacy.Name = textBox2.Text;
                pharmacy.Address = textBox3.Text;
                pharmacy.Phone = textBox4.Text;
                pharmacy.Area = textBox5.Text;
                PharmacyService pharmacySercvice = new PharmacyService();
                if (pharmacySercvice.Add(pharmacy) > 0)
                {
                    MessageBox.Show("New record added");
                }
            }
            else if (shoppingmallradiobutton.Checked == true)
            {
                ShoppingMall shoppingMall = new ShoppingMall();
                shoppingMall.Id = int.Parse(textBox1.Text);
                shoppingMall.Name = textBox2.Text;
                shoppingMall.Address = textBox3.Text;
                shoppingMall.Phone = textBox4.Text;
                shoppingMall.Area = textBox5.Text;
                ShoppingMallService shoppingMallSercvice = new ShoppingMallService();
                if (shoppingMallSercvice.Add(shoppingMall) > 0)
                {
                    MessageBox.Show("New record added");
                }
            }
            else
            {
                Restaurant restaurant = new Restaurant();
                restaurant.Id = int.Parse(textBox1.Text);
                restaurant.Name = textBox2.Text;
                restaurant.Address = textBox3.Text;
                restaurant.Phone = textBox4.Text;
                restaurant.Area = textBox5.Text;
                RestaurantService restaurantSercvice = new RestaurantService();
                if (restaurantSercvice.Add(restaurant) > 0)
                {
                    MessageBox.Show("New record added");
                }
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (hospitalradiobutton.Checked == true)
            {
                panel2.Show();
                Hospital hospital = new Hospital();
                hospital.Id = int.Parse(textBox1.Text);
                hospital.Name = textBox2.Text;
                hospital.Address = textBox3.Text;
                hospital.Phone = textBox4.Text;
                hospital.Area = textBox5.Text;
                HospitalService hospitalSercvice = new HospitalService();
                if (hospitalSercvice.Add(hospital) > 0)
                {
                    MessageBox.Show("New record added");
                }
            }
            else if (phramacyradiobutton.Checked == true)
            {
                Pharmacy pharmacy = new Pharmacy();
                pharmacy.Id = int.Parse(textBox1.Text);
                pharmacy.Name = textBox2.Text;
                pharmacy.Address = textBox3.Text;
                pharmacy.Phone = textBox4.Text;
                pharmacy.Area = textBox5.Text;
                PharmacyService pharmacySercvice = new PharmacyService();
                if (pharmacySercvice.Add(pharmacy) > 0)
                {
                    MessageBox.Show("New record added");
                }
            }
            else if (shoppingmallradiobutton.Checked == true)
            {
                ShoppingMall shoppingMall = new ShoppingMall();
                shoppingMall.Id = int.Parse(textBox1.Text);
                shoppingMall.Name = textBox2.Text;
                shoppingMall.Address = textBox3.Text;
                shoppingMall.Phone = textBox4.Text;
                shoppingMall.Area = textBox5.Text;
                ShoppingMallService shoppingMallSercvice = new ShoppingMallService();
                if (shoppingMallSercvice.Add(shoppingMall) > 0)
                {
                    MessageBox.Show("New record added");
                }
            }
            else
            {
                Restaurant restaurant = new Restaurant();
                restaurant.Id = int.Parse(textBox1.Text);
                restaurant.Name = textBox2.Text;
                restaurant.Address = textBox3.Text;
                restaurant.Phone = textBox4.Text;
                restaurant.Area = textBox5.Text;
                RestaurantService restaurantSercvice = new RestaurantService();
                if (restaurantSercvice.Add(restaurant) > 0)
                {
                    MessageBox.Show("New record added");
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            StartForm startForm = new StartForm();
            this.Hide();
            startForm.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
