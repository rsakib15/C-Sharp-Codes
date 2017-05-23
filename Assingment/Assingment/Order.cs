using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Order
    {
        private int orderId;
        private Product product;
        private Customer customer;


        public int OrderId
        {
            set
            {
                this.orderId = value;
            }
            get
            {
                return orderId;
            }
        }
        public Product Product
        {
            set
            {
                this.product = value;
            }
            get
            {
                return product;
            }
            }
        public Customer Customer
        {
            set
            {
                this.customer = value;
            }
            get
            {
                return customer;
            }
        }

        }
    }


