using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountWithMaxBalanceApp.Models
{
    internal class Account
    {
        const int MIN_BALANCE = 500;
        public int AccountNo { get; set; }
        public string AccountHolderName { get; set; }
        public string BankName { get; set; }
        public double Balance { get; set; }

        public Account(int accNo, string name, string bName) {
            AccountNo = accNo;
            AccountHolderName = name;
            BankName = bName;
            Balance = MIN_BALANCE;
        }
        public Account(int accNo, string name, string bName,double balance)
            :this(accNo,name, bName) {
            Balance = balance > MIN_BALANCE ? balance : MIN_BALANCE;
        }

        public override string ToString()
        {
            return $"=================================\n" +
                $"Account Number is: {AccountNo}\n" +
                $"Account Holder Nmae is: {AccountHolderName}\n"+
                $"Bank Name is: {BankName}\n"+
                $"Balance is: {Balance}\n";
        }

        public void Deposite(double amount)
        {
            Balance += amount;

        }
        public string Withdraw(double amount)
        {
            if (Balance - amount > MIN_BALANCE)
            {
                Balance -= amount;
                return "Withdraw Successfull";
            }
            else
                return "Insuffient funds, Withdraw denied!";
        }
        public static Account AccountWithMaxBalance(Account[] accounts)
        { 
            Account maxAccount=accounts[0];
            double max = accounts[0].Balance;
            for (int i = 1; i < accounts.Length; i++)
            {
                if (accounts[i].Balance > max)
                { 
                    max=accounts[i].Balance;   
                    maxAccount = accounts[i];
                }
            }
            return maxAccount;
        }
    }
}
