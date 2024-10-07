using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildParentReferenceApp.Models
{
    internal class Child1:Parent
    {
        public void Coloring()
        {
            Console.WriteLine("Inside child1 coloring");
        }
        public override void Print()
        {
            Console.WriteLine("Inside Child1 Print");
        }
    }
}
