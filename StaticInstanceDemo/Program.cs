using StaticInstanceDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticInstanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account();
            account1.AccountId = 101;
            Console.WriteLine("first Account: " + account1.AccountId);
            Console.WriteLine("Deafault_balance: " + Account.MINIMUM_BALANCE);

            Account.MINIMUM_BALANCE = 1000;

            Account account2 = new Account();
            account2.AccountId = 102;
            Console.WriteLine("Second Account: " + account2.AccountId);
            Console.WriteLine("Deafault_balance: " + Account.MINIMUM_BALANCE);

            Account account3 = new Account();
            account3.AccountId = 103;
            Console.WriteLine("third Account: " + account3.AccountId);
            Console.WriteLine("Deafault_balance: " + Account.MINIMUM_BALANCE);

        }
    }
}
