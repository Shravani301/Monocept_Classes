using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPatternDemo
{
    internal class WheelAlign : CarServiceDecorator
    {
        public WheelAlign(ICarService carService) : base(carService) { }

        public override double GetCost()
        {
            return 400 + base.GetCost();
        }
    }
}
