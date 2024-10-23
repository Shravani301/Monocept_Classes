using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonFactoryDemo
{
    internal class TeslaFactory : ICarFactory
    {
        private static TeslaFactory _instance;

        public static TeslaFactory GetInstance()
        {
            if (_instance == null)
            {
                _instance = new TeslaFactory();
            }
            return _instance;
        }

        public ICar MakeCar()
        {
            return new Tesla();
        }
    }
}
