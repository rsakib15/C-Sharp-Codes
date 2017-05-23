using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Product
    {
        private int id;
        private string name;
        private float price;
        private int noOfProduct;
        public Product()
        {
            this.id = 0;
            this.name = "No Name";
            this.price = 0.0f;
            this.noOfProduct = 0;
        }
        public Product(string name,float price,int n)
        {
            this.name = name;
            this.price = price;
            this.noOfProduct = n;
        }
        ~Product()
        {
            
        }

        public int Id
        {
            set
            {
                this.id = value;
            }
            get
            {
                return id;
            }
        }
        public string Name
        {
            set
            {
                this.name = value;
            }
            get
            {
                return name;
            }
        }
        public float Unitprice
        {
            set
            {
                this.price = value;
            }
            get
            {
                return price;
            }
        }

        public int Stock
        {

            set
            {
                this.noOfProduct = value;
            }
            get
            {
                return noOfProduct;
            }
        } 
    }
}

