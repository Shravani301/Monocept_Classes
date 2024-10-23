using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryApp.Models
{
    internal class CarFactory
    {
        public static ICar MakeCar(CarType type)
        {
            if (type == CarType.BMW)
                return new Bmw();
            return new Tesla();
        }
    }
}
