using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDemo
{
    internal class TeslaFactory :ICarFactory
    {
        public ICar MakeCar()
        {
            return new Tesla();
        }
    }
}
