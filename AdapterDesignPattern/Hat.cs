using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    internal class Hat
    {
        string _shortName { get; set; }
        string _longName { get; set; }
        double _basicPrice {  get; set; }
        double _tax {  get; set; }

        public Hat(string shortName, string longName, double basicPrice, double tax)
        {
            _shortName = shortName;
            _longName = longName;
            _basicPrice = basicPrice;
            _tax = tax;
        }
        public string GetFullName()
        {
            return $"{_longName}({_shortName})";
        }
        public double GetTotalPrice()
        {
            return _basicPrice+(_basicPrice*_tax)/ 100;
        }
    }
}
