using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo
{
    internal class TeslaGasoline:ITesla
    {
        public void Start()
        {
            Console.WriteLine("Telsa with Gasoline Engine");
        }

    }
}
