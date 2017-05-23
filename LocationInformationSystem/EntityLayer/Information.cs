using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class Information
    {
        protected int id;
        protected string name;
        protected string address;
        protected string phone;
        protected string area;
        public int Id
        {
            set
            {
                id = value;
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
                name = value;
            }
            get
            {
                return name;
            }
        }
        public string Address
        {
            set
            {
                address = value;
            }
            get
            {
                return address;
            }
        }
        public string Phone
        {
            set
            {
                phone = value;
            }
            get
            {
                return phone;
            }
        }
        public string Area
        {
            set
            {
                area = value;
            }
            get
            {
                return area;
            }
        }
    }
}
