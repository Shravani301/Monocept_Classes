using AccountWithMaxBalanceApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountWithMaxBalanceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account[] accounts = new Account[]
            {
                new Account(101,"Allen","SBI"),
                new Account(102,"Mary","BOI",5000),
                new Account(103,"Kate","IB",4500),
            };
            foreach (Account account in accounts)
            {
                Console.WriteLine(account);
            }

            accounts[0].Deposite(4700);
            accounts[1].Withdraw(500);
            accounts[2].Deposite(1500);
            accounts[2].Withdraw(4800);

            Console.WriteLine("\n\n Account with Maximum Balance is:");
            Console.WriteLine(Account.AccountWithMaxBalance(accounts));
        }

    }
}
