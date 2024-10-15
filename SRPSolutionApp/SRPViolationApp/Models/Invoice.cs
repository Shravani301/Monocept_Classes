using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPViolationApp.Models
{
    internal class Invoice
    {
        private int _id;
        private string _desc;
        private double _cost;
        private double _discount;
        private const double TAX = 0.10;
        const int DIVISOR = 100;

        public Invoice(int id,string desc, double cost, double discount)
        {
            _id = id;
            _desc = desc;
            _cost = cost;
            _discount = discount;
        }

        public double CalculateTax(double price)
        { 
            return TAX*price;
        }
        public double CalculateDiscount(double price)
        { 
            return (_discount/DIVISOR)*price;
        }
        public double CalculateFinalCost(double price)
        {
            return price + CalculateTax(price) - CalculateDiscount(price);
        }
        public void PrintInvoice(Invoice invoice)
        {
            Console.WriteLine($"Id:{invoice._id}\n" +
                $"Description:{invoice._desc}\n" +
                $"Price:{invoice._cost}\n" +
                $"Tax:{CalculateTax(invoice._cost)}\n" +
                $"Discount:{CalculateDiscount(invoice._cost)}\n" +
                $"Final Cost:{CalculateFinalCost(invoice._cost)}\n");
        }

    }
}
