using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo
{
    internal class TeslaElectric : ITesla
    {
        public void Start()
        {
            Console.WriteLine("Tesla Car with Electric Engine");
        }
    }
}
