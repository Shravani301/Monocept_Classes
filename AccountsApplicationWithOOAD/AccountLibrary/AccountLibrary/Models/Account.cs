using AccountLibrary.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AccountLibrary.Models
{
    public class Account
    {
        public int AccountId { get; set; }
        public string AccountHolderName { get; set; }
        public string BankName { get; set; }
        public double AccountBalance { get; set; }
        public const int MINIMUM_BALANCE = 500;
        
        public static List<Transaction> transactions=new List<Transaction>();

        public Account() { }
        public Account(int accountId, string accountHolderName, string bankName, double accountBalance)
        {
            AccountId = accountId;
            AccountHolderName = accountHolderName;
            BankName = bankName;
            AccountBalance = accountBalance > MINIMUM_BALANCE ? accountBalance : MINIMUM_BALANCE;
            transactions = new List<Transaction>();
            AddTransaction(accountId, AccountBalance, TransactionType.Credit);

        }

        public string DepositAmount(double amount)
        {
            AccountBalance += amount;
            return "Deposit Successfull!";
        }
        public void WithdrawAmount(double amount)
        {
            AccountBalance -= amount;

        }

        public void AddTransaction(int accId, double amount, TransactionType transactionType)
        {
            Transaction transaction = new Transaction()
            {
                Id = Transaction.GenerateTransactionId(accId),
                Amount = amount,
                Type = transactionType,
                DateTime = DateTime.Now,
                AccountId = accId
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
                result += $"--TransactionId:{transaction.Id}--\n" +
                    $"Transaction Type: {transaction.Type}\n" +
                    $"Transaction Amount:{transaction.Amount}\n" +
                    $"Transaction Date:{transaction.DateTime}\n";
            }
            return result;
        }

        public override string ToString()
        {
            return $"Account ID is: {AccountId}\n" +
                $"Account Holder Name is: {AccountHolderName}\n" +
                $"Bank Name is: {BankName}\n" +
                $"Balance is: {AccountBalance}";
        }

    }
}
