using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternDemo
{
    internal class OilChange:CarServiceDecorator
    {
        public OilChange(ICarService carService) : base(carService) { }

        public override double GetCost()
        {
            return 500 + base.GetCost();
        }

    }
}
