using ConstructorApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorApp
{
    internal class Program
    {
        static Program()
        {
            Console.WriteLine("Inside the static constructor");
        }
        public Program() {
            Console.WriteLine("Inside the default constructor");

        }
        public Program(int x)
        { 
            Console.WriteLine("Int Constructor");
        }

        public Program(string x)
        {
            Console.WriteLine("String Constructor");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Inside the Main Method");
            Program program1 = new Program();
            Program program2 = new Program(10);
            Program program3 = new Program("Ram");
            Program program4 = new Program('A');
            Console.WriteLine();
            Console.WriteLine("=====Product Details=====");
            Console.WriteLine();
            Product product1=new Product(10,"Laptop",40000);
            product1.PrintProduct();

            Product product2 = new Product(20, "Desktop");
            product2.PrintProduct();
        }
    }
}
