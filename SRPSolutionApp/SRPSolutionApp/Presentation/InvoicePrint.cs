using SRPSolutionApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPSolutionApp.Presentation
{
    internal class InvoicePrint
    {
       public static void PrintInvoiceToConsole(Invoice invoice)
        {
            Console.WriteLine($"Id:{invoice.Id}\n" +
                $"Description:{invoice.Desc}\n" +
                $"Price:{invoice.Cost}\n" +
                $"Tax:{invoice.CalculateTax(invoice.Cost)}\n" +
                $"Discount:{invoice.CalculateDiscount(invoice.Cost)}\n" +
                $"Final Cost:{invoice.CalculateFinalCost(invoice.Cost)}\n");
        }
        public static void PrintInvoiceToHtml(Invoice invoice)
        {
            string InvoiceData =
                 "<html>" +
                 "<head>" +
                 "    <title>Invoice</title>" +
                 "</head>" +
                 "<body>" +
                 "    <h1>Invoice Details</h1>" +
                 "    <table>" +
                 "        <tr>" +
                 "            <th>Invoice Property</th>" +
                 "            <th>Value</th>" +
                 "        </tr>" +
                 "        <tr>" +
                 "            <td>Id</td>" +
                 "            <td>" + invoice.Id + "</td>" +
                 "        </tr>" +
                 "        <tr>" +
                 "            <td>Description</td>" +
                 "            <td>" + invoice.Desc + "</td>" +
                 "        </tr>" +
                 "        <tr>" +
                 "            <td>Price</td>" +
                 "            <td>" + invoice.Cost + "</td>" +
                 "        </tr>" +
                 "        <tr>" +
                 "            <td>Tax</td>" +
                 "            <td>" + invoice.CalculateTax(invoice.Cost) + "</td>" +
                 "        </tr>" +
                 "        <tr>" +
                 "            <td>Discount</td>" +
                 "            <td>" + invoice.CalculateDiscount(invoice.Cost) + "</td>" +
                 "        </tr>" +
                 "        <tr>" +
                 "            <td>Final Cost</td>" +
                 "            <td>" + invoice.CalculateFinalCost(invoice.Cost) + "</td>" +
                 "        </tr>" +
                 "    </table>" +
                 "</body>" +
                 "</html>";

            string filePath = @"E:\DotNet\Monocept_Classes\SRPSolutionApp\Invoice.html";
            File.WriteAllText(filePath, InvoiceData);
            Console.WriteLine("Invoice successfully written to " + filePath);

        }
    }
}
