using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryDemo
{
    internal class BmwGasoline:IBMW
    {
        public void Start()
        {
            Console.WriteLine("BMW Car with Gasoline Engine");
        }
        
    }
}
