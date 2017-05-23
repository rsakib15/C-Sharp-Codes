using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labexam
{
    class Address
    {
        private string houseNo;
        private string roadNo;
        private string area;

        public Address()
        {
            this.houseNo = "No House Number";
            this.roadNo = "No Road Number";
            this.area = "No area";
        }
        public Address(string houseNo, string roadNo, string area)
        {
            this.houseNo = houseNo;
            this.roadNo = roadNo;
            this.area = area;
        }
        public void getAddress()
        {
            Console.WriteLine("House No: " + this.houseNo);
            Console.WriteLine("Road No: " + this.roadNo);
            Console.WriteLine("Area: " + this.area);
        }
    }
}
