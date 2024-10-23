using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    internal class Biscuit :IItems
    {
        string _name { get; set; }
        double _price { get; set; }
        public Biscuit(string name, double price)
        {
            _name = name;
            _price = price;
        }
    
        public string GetName()
        {
            return _name;
        }

        public double GetPrice()
        {
            return _price;
        }

    }
}
