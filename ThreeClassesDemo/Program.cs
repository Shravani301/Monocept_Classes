using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreeClassesDemo
{
    class StakeHolder
    {
        public static int Objects_Count;
        
        virtual public void PrintObjects()
        {
            Console.WriteLine("StackeHolder class objects are: " + Objects_Count);
        }
    }
    class Employee:StakeHolder
    {
       public static int Employees_Count;
       public Employee()
        {
            Employees_Count++;
            Objects_Count++;
        }
        public override void PrintObjects()
        {
            Console.WriteLine("Employees class objects are: "+Employees_Count);
        }
    }
    class Customer : StakeHolder
    {
        public static int Customers_Count;
        public Customer()
        {
            Customers_Count++;
            Objects_Count++;
        }
       override public void PrintObjects()
        {
            Console.WriteLine("Customer class objects are: " + Customers_Count);
        }

    }
    

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee[] employees = new Employee[]
                { new Employee(),
                new Employee(),
                new Employee()
                };
            employees[0].PrintObjects();
            Customer[] customers = new Customer[] {
                new Customer(),
                new Customer(),
                new Customer()
            };
            customers[0].PrintObjects();
            StakeHolder stakeholder = new StakeHolder();
            stakeholder.PrintObjects();


        }
    }
}
