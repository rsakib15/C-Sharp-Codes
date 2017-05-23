using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labexam
{
    class OverDraftAccount : Account
    {
        private double overDraftLimit;

        public OverDraftAccount() { }
        public OverDraftAccount(string accName, string acId, double balance, Address addRess, double overDraftLimit)
        {
            this.AccountName = accName;
            this.AccountId = acId;
            this.Balance = balance;
            this.AddRess = addRess;
            this.overDraftLimit = overDraftLimit;
        }
        public double OverDraftLimit
        {
            set { this.overDraftLimit = value; }
            get { return this.overDraftLimit; }
        }
        public void Withdraw(double amount)
        {
            if (amount > this.Balance + this.overDraftLimit)
            {
                Console.WriteLine("\nYou do not have sufficient money\n");
                Console.WriteLine();
            }
            else
            {
                this.Balance = this.Balance - amount;
            }
        }
        public void ShowOverDraftAccountInfo()
        {
            ShowAccountInfo();
            Console.WriteLine("Over Draft Limit: " + OverDraftLimit);
            Console.WriteLine();

        }
    }
}
