using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterDesignPattern
{
    internal class HatAdapter : IItems
    {
        Hat hat;
        public HatAdapter(Hat hatObj)
        { 
            hat = hatObj;
        } 
        public string GetName()
        {
            return hat.GetFullName();
        }

        public double GetPrice()
        {
            return hat.GetTotalPrice();
        }
    }
}
