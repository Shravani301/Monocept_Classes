using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonFactoryDemo
{
    internal class Tesla : ICar
    {
        public void Start()
        {
            Console.WriteLine("Tesla starts");
        }
    }
}
