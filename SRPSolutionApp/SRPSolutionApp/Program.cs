using SRPSolutionApp.Models;
using SRPSolutionApp.Presentation;

namespace SRPSolutionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(101, "Laptop", 55300, 15);
            InvoicePrint.PrintInvoiceToConsole(invoice);
            Invoice invoice1 = new Invoice(102, "Mobile", 15500, 20);
            InvoicePrint.PrintInvoiceToHtml(invoice1);


        }
    }
}
