using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp
{
    public  class Account
    {
        public string accountNumber;
        public string customarName;
        private double balance;

        public string AccountNumber
        {

            get { return this.accountNumber; }
            set { this.accountNumber = value; }
        }
        public string CustomarName
        {

            get { return this.customarName; }
            set { this.customarName = value; }
        }
        public double Balance
        {

            get { return this.balance; }
            
        }

        public double GetDeposit(double amount)
        {
            balance=balance + amount;
            return balance;
        }

        public bool GetWithdraw(double amount)
        {
            if (amount < balance)
            {
                balance=balance - amount;
                return true;
            }
            return false;
        }

        public string GetReport()
        {
            return "Customar Name : " + customarName + " your account Number : " + accountNumber + " and it's balance: " +
                   balance + " taka ";
        }

        public void CreateAccount()

        {
            balance = 0.0;
        }
    }

}
