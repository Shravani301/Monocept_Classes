using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildParentReferenceApp.Models
{
    internal class Child2:Parent
    {
        public void Coloring()
        {
            Console.WriteLine("Inside child2 coloring");
        }
        public override void Print()
        {
            Console.WriteLine("Inside Child2 Print");
        }
    }
}
