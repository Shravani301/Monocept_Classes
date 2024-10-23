using DIPSolution.Helpers;
using DIPSolution.Models;

namespace DIPSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaxCalculator taxCalculator = new TaxCalculator(new DbLogger());
            Console.WriteLine(taxCalculator.CalculateTax(10000, 4));

            TaxCalculator taxCalculator1 = new TaxCalculator(new FileLogger());
            Console.WriteLine(taxCalculator.CalculateTax(10000, 0));
        }

    }
}
