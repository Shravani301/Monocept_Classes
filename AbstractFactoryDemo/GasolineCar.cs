using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo
{
    internal class GasolineCar: ICarFactory
    {
        public IBMW MakeBMWCar()
        {
            return new BmwGasoline();
        }

        public ITesla MakeTeslaCar()
        {
            return new TeslaGasoline();
        }
    }
}
