using AccountLibrary.Exceptions;
using AccountLibrary.Models;
using AccountLibrary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountLibrary.Controller
{
    public class AccountManager
    {
        static List<Account> accounts = new List<Account>();
        static List<Transaction> transactions=new List<Transaction>();

        public double MINIMUM_BALANCE { get; private set; }

        public AccountManager()
        {
            accounts = Serialization.Deserialze();

        }
        public string Deposit(Account account, double amount)
        {
            if (amount > 50000)
            {

                throw new DepositLimitException("Deposit Limit exceeded, You can deposit at a time only 50000");
            }
            AddTransaction(account,amount,TransactionType.Credit);

            return account.DepositAmount(amount);
        }
        public static Account GetAccount(int accId)
        {
            var account= accounts.Where(accounts => accounts.AccountId == accId).FirstOrDefault();
            if (account == null)
                throw new AccountNotFoundException("No such Account exist");
            return account;
        }
        public void Withdraw(Account account, double amount)
        {
            
            if (account.AccountBalance - amount <= MINIMUM_BALANCE)
                    throw new MinimumBalanceException("Insufficient Balance");
            AddTransaction(account, amount, TransactionType.Debit);
            account.WithdrawAmount(amount);
            
        }

        public void Create(int accId, string name, string bankName, double openingBalance)
        {
            accounts.Add(new Account(accId, name, bankName, openingBalance));
        }

       public List<Account> DisplayAccounts()
        {
            if (accounts.Count == 0)
                {
                    throw new ZeroAccountsException("Zero Accounts exist");
                }

            return accounts;

        }
        public string SerializeAccount()
        {
            return Serialization.Serialize(accounts,transactions);
        }

        public void AddTransaction(Account account, double amount, TransactionType transactionType)
        {
            Transaction transaction =new Transaction()
            {
                Id = Transaction.GenerateTransactionId(account),
                Amount = amount,
                Type = transactionType,
                DateTime = DateTime.Now,
                AccountId = account.AccountId
            };

            transactions.Add(transaction); 

        }
        public List<Transaction> GetTransactionsForAccount(int accId)
        {
            return transactions.Where(t => t.AccountId == accId).ToList();
        }

        public string ShowTransactionsForAccount(int accId)
        {
            List<Transaction> transactionsForAccount = GetTransactionsForAccount(accId);
            if (transactionsForAccount.Count == 0)
            {
                return "No transactions found for this account.";
            }
            string result = "";
            foreach (Transaction transaction in transactions)
            {
                result += $"-----TransactionId:{transaction.Id}-----\n" +
                    $"Transaction Type: {transaction.Type}\n" +
                    $"Transaction Amount:{transaction.Amount}\n" +
                    $"Transaction Date:{transaction.DateTime}";
            }
            return result;
        }
        
    }

}
