using ChildParentReferenceApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildParentReferenceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parent parent = new Parent();
            Child1 child1 = new Child1();
            Child2 child2 = new Child2();
            CallReference(child1);
            CallReference(child2);
        }
        static void CallReference(Parent parent)
        {
            parent.Drawing();
            parent.Print();
        }
    }
}
