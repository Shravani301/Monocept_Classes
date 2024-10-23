using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo
{
    internal class Electriccar : ICarFactory
    {
        public IBMW MakeBMWCar()
        {
            return new BmwElectric();
        }

        public ITesla MakeTeslaCar()
        {
           return new TeslaElectric();
        }
    }
}
