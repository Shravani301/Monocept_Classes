using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPSolutionApp.Models
{
    internal class Invoice
    {
        public int Id;
        public string Desc;
        public double Cost;
        public double Discount;
        public const double TAX = 0.10;
        const int DIVISOR = 100;

        public Invoice(int id, string desc, double cost, double discount)
        {
            Id = id;
            Desc = desc;
            Cost = cost;
            Discount = discount;
        }

        public double CalculateTax(double price)
        {
            return TAX * price;
        }
        public double CalculateDiscount(double price)
        {
            return (Discount / DIVISOR) * price;
        }
        public double CalculateFinalCost(double price)
        {
            return price + CalculateTax(price) - CalculateDiscount(price);
        }
        
    }
}
