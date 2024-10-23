namespace StateDesignPatternAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account(5000); 
            Console.WriteLine($"Initial Balance: {account.Balance}");
            account.GetBenefits();

            account.Deposit(7000);  
            Console.WriteLine($"\nBalance after deposit: {account.Balance}");
            account.GetBenefits();

            account.Deposit(20000);
            Console.WriteLine($"\nBalance after another deposit: {account.Balance}");
            account.GetBenefits();

            account.Withdraw(10000); 
            Console.WriteLine($"\nBalance after withdrawal: {account.Balance}");
            account.GetBenefits();

            account.Deposit(40000); 
            Console.WriteLine($"\nBalance after large deposit: {account.Balance}");
            account.GetBenefits();
        }
    }
}
