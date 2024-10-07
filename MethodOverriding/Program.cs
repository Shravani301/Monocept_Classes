using MethodOverriding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parent parent = new Parent();
            parent.Print();
            parent.Drawing();

            Child child = new Child();
            child.Drawing();
            child.Print();
            child.Coloring();

            Parent parent1 = new Child();
            parent1.Drawing();
            parent1.Print();
        }
    }
}
