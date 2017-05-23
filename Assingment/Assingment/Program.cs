using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer();
            c1.Phone = "017";
            c1.Name="Dina";

            Customer c2 =new Customer();
            c2.Phone = "018A";
            c2.Name="Mina";

            Console.WriteLine();

            System.Console.WriteLine(c1.Phone);
            System.Console.WriteLine(c1.Name);

            Console.WriteLine();
            System.Console.WriteLine(c2.Phone);
            System.Console.WriteLine(c2.Name);


            Product p1 = new Product();
            p1.Id = 1;
            p1.Name = "A";
            p1.Unitprice= (float) 1.2;
            p1.Stock = 1;


            Product p2 = new Product();
            p2.Id = 2;
            p2.Name = "B";
            p2.Unitprice = (float)1.3;
            p2.Stock = 2;

            Console.WriteLine();

            System.Console.WriteLine(p1.Id);
            System.Console.WriteLine(p1.Name);
            System.Console.WriteLine(p1.Unitprice);
            System.Console.WriteLine(p1.Stock);

            Console.WriteLine();


            System.Console.WriteLine(p2.Id);
            System.Console.WriteLine(p2.Name);
            System.Console.WriteLine(p2.Unitprice);
            System.Console.WriteLine(p2.Stock);


            Order o1 = new Order();
            o1.OrderId = 1;
            o1.Product = p1;
            o1.Customer = c1;

            Order o2;
            o2 = new Order();
            o2.OrderId = 2;
            o2.Product = p2;
            o2.Customer = c2;

            Console.Write("\nOrder details :\n");
            Console.Write(o1.OrderId + " " + o1.Product.Name + " " + o1.Customer.Name + " " + "\n");

            Console.Write(o2.OrderId + " " + o2.Product.Name + " " + o2.Customer.Name + " " + "\n");


        }
    }
}
            
            




            





