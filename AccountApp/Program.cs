using AccountApp.Model;
using System;

namespace AccountApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account(101, "shravani", "UCO");
            Console.WriteLine("first Account: "+account1.AccountId);
            Console.WriteLine("Deafault_balance: "+Account.MINIMUM_BALANCE);

            Account.MINIMUM_BALANCE = 1000;
            Account account2 = new Account(102, "shirisha", "ADCC", 300);
            Console.WriteLine("Second Account: "+account2.AccountId);
            Console.WriteLine("Deafault_balance: " + Account.MINIMUM_BALANCE);

            Account account3 = new Account(103, "Manisha", "SBI");
            Console.WriteLine("third Account: "+account3.AccountId);
            Console.WriteLine("Deafault_balance: "+Account.MINIMUM_BALANCE);


            /*Account[] accounts = new Account[]
            {
                new Account(12345, "shravani", "SBI", 1000),
                new Account(12346, "shirisha", "ADCC", 300),
                Account.MINIMUM_BALANCE = 1000;
                new Account(12347, "chandana", "UCO")
            };

            Console.WriteLine("====== Account Details ======");
            foreach (var account in accounts)
            {
                account.PrintAccountDetails();
                Console.WriteLine();
            }

            bool continueOperations = true;
            while (continueOperations)
            {
                Console.WriteLine("Select an account by index (0-2) or -1 to exit:");
                int accountIndex = Convert.ToInt32(Console.ReadLine());

                if (accountIndex == -1)
                {
                    continueOperations = false;
                    continue;
                }

                if (accountIndex < 0 || accountIndex >= accounts.Length)
                {
                    Console.WriteLine("Invalid account index. Please try again.");
                    continue;
                }

                Account selectedAccount = accounts[accountIndex];
                bool continueWithCurrentAccount = true;

                while (continueWithCurrentAccount)
                {
                    Console.WriteLine("Choose an operation: ");
                    Console.WriteLine("1. Deposit");
                    Console.WriteLine("2. Withdraw");
                    Console.WriteLine("3. Print Account Details");
                    Console.WriteLine("4. Exit to Account Selection");

                    int operation = Convert.ToInt32(Console.ReadLine());
                    switch (operation)
                    {
                        case 1:
                            Console.WriteLine("Enter amount to deposit:");
                            double depositAmount = Convert.ToDouble(Console.ReadLine());
                            selectedAccount.Deposite(depositAmount);
                            Console.WriteLine("Deposit successful.");
                            break;
                        case 2:
                            Console.WriteLine("Enter amount to withdraw:");
                            double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                            if (selectedAccount.Withdraw(withdrawAmount))
                            {
                                Console.WriteLine("Withdrawal successful.");
                            }
                            else
                            {
                                Console.WriteLine("Insufficient funds.");
                            }
                            break;
                        case 3:
                            selectedAccount.PrintAccountDetails();
                            break;
                        case 4:
                            continueWithCurrentAccount = false;
                            break;
                        default:
                            Console.WriteLine("Invalid operation. Please try again.");
                            break;
                    }

                    if (continueWithCurrentAccount)
                    {
                        Console.WriteLine("Do you want to continue with the current account? (y/n)");
                        string userChoice = Console.ReadLine().ToLower();

                        if (userChoice == "n")
                        {
                            continueWithCurrentAccount = false;
                        }
                    }

                    Console.WriteLine();
                }
            }*/
        }
    }
}
