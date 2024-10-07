using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApp.Model
{
    internal class Account
    {
        public int AccountId { get; set; }
        public string AccountHolderName { get; set; }
        public string BankName { get; set; }
        public double Balance { get; set; }

        public static int MINIMUM_BALANCE = 500;

        public Account(int accId, string accHolderName,string bankName ) {
            AccountId = accId;
            AccountHolderName = accHolderName;
            BankName = bankName;
            Balance = MINIMUM_BALANCE;
        }
        public Account(int accId, string accHolderName, string bankName, double balance)
            :this(accId, accHolderName, bankName)
        {
          Balance = (balance<MINIMUM_BALANCE)?MINIMUM_BALANCE:balance;
        }

        public void Deposite(double amount)
        {
            Balance += amount;
        }
        public bool Withdraw(double amount)
        {
            if ((Balance - amount) >= MINIMUM_BALANCE)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }
        public void PrintAccountDetails()
        { 
            Console.WriteLine("Account Number is: "+AccountId);
            Console.WriteLine("Account Holder Name is: "+AccountHolderName);
            Console.WriteLine("Bank Name is: "+BankName);
            Console.WriteLine("Current Balance is: "+Balance);
        }

    }
}
