using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInheritance.Models
{
    internal class Child:Boy,IHuman
    {
        public void Display()
        {
            Console.WriteLine("Inside the Child Class");
        }
        public override void Eat()
        {
            Console.WriteLine("Child Eats");
        }
    }
}
