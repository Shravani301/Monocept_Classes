using DIPwithDelegates.Helpers;
using DIPwithDelegates.Models;

namespace DIPwithDelegates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DbLogger dbLogger = new DbLogger();
            TaxCalculator taxCalculatorDb = new TaxCalculator(dbLogger.Log);
            taxCalculatorDb.CalculateTax(1000, 0);

            FileLogger fileLogger = new FileLogger();
            TaxCalculator taxCalculatorFile = new TaxCalculator(fileLogger.Log);
            taxCalculatorFile.CalculateTax(1000, 0);
        }
    }
}
