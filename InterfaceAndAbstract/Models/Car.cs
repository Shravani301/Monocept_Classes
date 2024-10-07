using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceAndAbstract.Models
{
    internal class Car:Vehicle
    {
        public override void Move()
        {
            Console.WriteLine("Inside the Move method of Car Class");
        }
    }
}
