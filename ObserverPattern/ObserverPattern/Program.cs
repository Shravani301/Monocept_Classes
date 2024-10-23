using ObserverAccountLibrary;

namespace ObserverPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account1 = new Account(101, "Shravani", 4500);
            account1.RegisterNotifier(new SMSNotifier());
            account1.RegisterNotifier(new EmailNotifier());
            account1.RegisterNotifier(new WhatsappNotifier());
           Console.WriteLine( account1.Deposit(4550));
            Console.WriteLine(account1.Withdraw(4000));
        }
    }
}
