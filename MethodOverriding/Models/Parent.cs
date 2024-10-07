using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding.Models
{
    internal class Parent
    {
        public void Drawing()
        {
            Console.WriteLine("Inside Parent Drawing");
        }
        public virtual void Print()
        {
            Console.WriteLine("Inside Parent Print");
        }
    }
}
