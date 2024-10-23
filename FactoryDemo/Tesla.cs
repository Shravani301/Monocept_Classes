using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDemo
{
    internal class Tesla :ICar
    {
        public void Start()
        {
            Console.WriteLine("Telsa Starts");
        }
    }
}
