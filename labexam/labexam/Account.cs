using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labexam
{
    class Account
    {
        private string accName;
        private string acId;
        private double balance;
        private Address address;

        public Account() { }
        public Account(string accName, string acId, double balance, Address address)
        {
            this.accName = accName;
            this.acId = acId;
            this.balance = balance;
            this.address = address;
        }
        public void GetAddress()
        {
            address.getAddress();
        }
        public Address AddRess
        {
            set { this.address = value; }
            get { return this.address; }
        }
        public void Deposit(double amount)
        {
            this.balance = balance + amount;
        }
        public void Withdraw(double amount)
        {
            this.balance = balance - amount;
        }
        public string AccountName
        {
            set { this.accName = value; }
            get { return this.accName; }
        }
        public string AccountId
        {
            set { this.acId = value; }
            get { return this.acId; }
        }
        public double Balance
        {
            set { this.balance = value; }
            get { return this.balance; }
        }
        public void Transfer(double amount, Account receiver)
        {
            if (this.Balance - amount > 0)
            {
                this.balance = this.balance - amount;
                receiver.Balance = receiver.Balance + amount;
            }
            else
            {
                Console.WriteLine("You dont have sufficient amount");
            }
        }

        public void ShowAccountInfo()
        {
            Console.WriteLine("Account Name: " + AccountName);
            Console.WriteLine("Account Id: " + AccountId);
            Console.WriteLine("Balance: " + Balance);
            address.getAddress();
            Console.WriteLine();
        }

    }
}
