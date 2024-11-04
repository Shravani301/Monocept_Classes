using AccountAppWithMsUnitTest.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace AccountAppWithMsUnitTest.Models
{
    internal class Account
    {
        public int AccountId { get; set; }
        public string AccountHolderName { get; set; }
        public string BankName { get; set; }
        public double AccountBalance { get; set; }
        public const int MINIMUM_BALANCE = 500;

        public Account(int accountId, string accountHolderName, string bankName, double accountBalance)
        {
            AccountId = accountId;
            AccountHolderName = accountHolderName;
            BankName = bankName;
            AccountBalance = accountBalance > MINIMUM_BALANCE ? accountBalance : MINIMUM_BALANCE;
        }

        public string DepositAmount(double amount)
        {
            if (amount <= 0)
                throw new InvalidAmountException("Deposit amount must be greater than zero.");

            AccountBalance += amount;
            return "Deposit Successful!";
        }

        public void WithdrawAmount(double amount)
        {
            if (amount <= 0)
                throw new InvalidAmountException("Withdrawal amount must be greater than zero.");

            if (AccountBalance - amount < MINIMUM_BALANCE)
                throw new InsufficientBalanceException("Insufficient balance to complete the withdrawal.");

            AccountBalance -= amount;
        }

        public void TransferAmount(Account account, double amount)
        {
            if (account == null)
                throw new InvalidAccountException("account cannot be null.");

            if (amount <= 0)
                throw new InvalidAmountException("Transfer amount must be greater than zero.");

            if (AccountBalance - amount < MINIMUM_BALANCE)
                throw new InsufficientBalanceException("Insufficient balance.");

            WithdrawAmount(amount);
            account.DepositAmount(amount);
        }

        public double GetBalance()
        {
            return AccountBalance;
        }
    }
}
