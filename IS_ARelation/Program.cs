using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IS_ARelation
{
    class Parent
    {
        public virtual void PrintParent()
        {
            Console.WriteLine("Parent print method");
        }
    }
    class Child : Parent
    {
        public void PrintChild()
        {
            Console.WriteLine("Child Print Method");
        }

        public override void PrintParent()
        {
            Console.WriteLine("Parent print method- overrided");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Case-I
            Parent parent1 = new Parent();
            Console.WriteLine("Case-I");
            parent1.PrintParent();

            //Case-II
            Child child1 = new Child();

            Console.WriteLine("Case-II");
            child1.PrintParent();
            child1.PrintChild();

            //Case-III
            Parent parent2 = new Child();
            Console.WriteLine("Case-III");
            parent2.PrintParent();

            //Case-IV
            Child child2 = (Child) new Parent();

            Console.WriteLine("Case-IV");
            child2.PrintChild();
        }
    }
}
