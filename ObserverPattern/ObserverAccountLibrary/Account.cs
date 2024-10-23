using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverAccountLibrary
{
    public class Account
    {
        public int AccountNo {  get; set; }    
        public string AccountHolderName {  get; set; }
        public double Balance { get; set; }
        private List<INotifier> NotifierList { get; set; }
        public Account(int accNo, string accName, double balance) 
        {
            AccountNo = accNo;
            AccountHolderName = accName;
            Balance = balance;
            NotifierList = new List<INotifier>();
        }
        public string Deposit(double amount)
        {
            Balance += amount;

            string message = "";
            NotifierList.ForEach(notifier =>
            {
                message += notifier.Notify(this) + "\n";
            });

            return $"Deposit of {amount} successful.\n"
                + message;
        }

        public string Withdraw(double amount)
        {
            Balance -= amount;

            string message = "";
            NotifierList.ForEach(notifier =>
            {
                message += notifier.Notify(this) + "\n";
            });

            return $"Withdrawal of {amount} successful.\n"
                + message;
        }

        public void RegisterNotifier(INotifier notifier)
        {
            NotifierList.Add(notifier);
        }
    }


}
