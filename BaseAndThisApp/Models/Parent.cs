using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseAndThisApp.Models
{
    internal class Parent
    {
        public int number = 10;

        public Parent() {
            Console.WriteLine("Inside the Parent Consttructor");
        }
        public Parent(int value)
        {
            Console.WriteLine("Inside the Parent Arg Constructor");
        }
    }
}
