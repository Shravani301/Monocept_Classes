using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding.Models
{
    internal class Child:Parent
    {
        public void Coloring()
        {
            Console.WriteLine("Isnide Child Colouring");
        }
        public override void Print()
        {
            Console.WriteLine("Inside Child Print");
        }
    }
}
