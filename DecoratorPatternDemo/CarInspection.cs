using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternDemo
{
    internal class CarInspection:ICarService
    {
        const double ServiceCharge = 1000;
        public double GetCost()
        {
            return ServiceCharge;
        }

    }
}
