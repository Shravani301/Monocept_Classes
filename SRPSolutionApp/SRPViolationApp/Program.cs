using SRPViolationApp.Models;

namespace SRPViolationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(101, "Laptop", 55300, 15);
            invoice.PrintInvoice(invoice);
        }
    }
}
