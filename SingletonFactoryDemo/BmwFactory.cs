using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonFactoryDemo
{
    internal class BmwFactory : ICarFactory
    {
        private static BmwFactory _instance;
        public static BmwFactory GetInstance()
        {
            if (_instance == null)
            {
                _instance = new BmwFactory();
            }
            return _instance;
        }

        public ICar MakeCar()
        {
            return new Bmw();
        }
    }
}
