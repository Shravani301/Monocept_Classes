using DelegatesWithEvent.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesWithEvent.Models
{
    internal class Account
    {
        public delegate void DAccountBalanceChanged(Account account);
        public int AccountNo;
        public string Name;
        public double AccountBalance;
        const int MINIMUM_BALANCE = 500;

        public event DAccountBalanceChanged accountBalanceChanged;
        public Account(int accNo, string name,double balance )
        {
            AccountNo = accNo;
            Name = name;
            AccountBalance = balance>MINIMUM_BALANCE?balance:MINIMUM_BALANCE;
        }
        public void Deposite(double amount)
        {
            AccountBalance += amount;
            accountBalanceChanged(this);
        }
        public void Withdraw(double amount)
        {
            try
            {
                if (AccountBalance - amount >= MINIMUM_BALANCE)
                {
                    AccountBalance -= amount;
                    accountBalanceChanged(this);
                }
                else
                    throw new InsufficientFundsException("Insufficient Funds");
            }
            catch (InsufficientFundsException e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

    }
}
