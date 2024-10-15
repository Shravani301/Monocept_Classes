using OCPSolution.Festivals;
using OCPSolution.Models;

namespace OCPSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FixedDeposit fixedDeposit = new FixedDeposit(101, "Shravani", 50000, 1, new Diwali());
            Console.WriteLine(fixedDeposit.CalculateSimpleInterest());
        }
    }
}
