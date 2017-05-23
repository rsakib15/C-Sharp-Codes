using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labexam
{
    class Program
    {
        static void Main(string[] args)
        {
            Address addressOne = new Address("1","12","Banani");
            Address addressTwo = new Address("580", "2", "Mirpur");


            OverDraftAccount account1 = new OverDraftAccount("Shanto","1",500,addressOne,100);
            OverDraftAccount account2 = new OverDraftAccount("XYZ", "2", 400, addressTwo, 200);

            account1.ShowOverDraftAccountInfo();
            account2.ShowOverDraftAccountInfo();
            Console.WriteLine("\n");

            account1.Deposit(100);
            account1.ShowAccountInfo();

            account2.Withdraw(200);
            account2.ShowAccountInfo();

            account1.Transfer(300,account2);

            account1.ShowOverDraftAccountInfo();
            account2.ShowOverDraftAccountInfo();

        }
    }
}
