using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseAndThisApp.Models
{
    internal class Child:Parent
    {
        public Child()
        {
            Console.WriteLine("Inside the child Constructor");
        }
        public Child(int value) : base(value)
        {
            base.number = value;
            Console.WriteLine(base.number);
            Console.WriteLine("Inside the Child Arg Constructor");
        }
    }
}
