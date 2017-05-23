using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Customer
    {
        private string phone;
        private string name;
        private string email;
        private int noOfCustomer;
        public Customer()
        {

        }

        public Customer(string p,string na,string e,int n)
        {
            this.phone = p;
            this.name = na;
            this.email = e;
            this.noOfCustomer = n;
        }
        public string Phone
        {
            set
            {
                this.phone = value;
            }
            get
            {
                return phone;
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
        public string Email
        {
            set
            {
                this.email = value;
            }
            get
            {
                return email;
            }
        }
        public int NoOfCustomer
        {
            set
            {
                this.noOfCustomer = value;
            }
            get
            {
                return noOfCustomer;
            }
        }
    }
}
                

        

