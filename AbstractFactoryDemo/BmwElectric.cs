using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo
{
    internal class BmwElectric : IBMW
    {
        public void Start()
        {
            Console.WriteLine("BMW Car with Electric Engine");
        }

    }
}
