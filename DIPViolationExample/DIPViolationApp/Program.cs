using DIPViolationApp.HLM;

namespace DIPViolationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaxCalculator taxCalculator= new TaxCalculator();
            Console.WriteLine(taxCalculator.CalculateTax(10000, 4));
        }
    }
}
