using DelegatesWithEvent.Models;

namespace DelegatesWithEvent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(101, "Shravani", 5000);
            account.accountBalanceChanged += SendSMS;
            account.Deposite(4500);
            account.Withdraw(14500);
            account.Withdraw(5000);

        }
        public static void SendSMS(Account account)
        {
            Console.WriteLine($"Sending sms to {account.Name}:\n" +
                $"Your account's {account.AccountNo} balance is updated and" +
                $" current balance is:{account.AccountBalance}");
        }
    }
}
