using OCPExample.Models;
using OCPExample.Types;

namespace OCPExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FixedDeposit fixedDeposit = new FixedDeposit(101, "Shravani", 50000, 1, FestivalType.DIWALI);
            Console.WriteLine(FixedDeposit.CalculateSimpleInterest(fixedDeposit));   
        }
    }
}
