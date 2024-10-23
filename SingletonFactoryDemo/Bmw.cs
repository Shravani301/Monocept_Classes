using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonFactoryDemo
{
    internal class Bmw : ICar
    {
        public void Start()
        {
            Console.WriteLine("BMW starts");
        }
    }
}
