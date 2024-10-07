using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overloading
{
    internal class Program
    {
        public void DoWork()
        {
            Console.WriteLine("No args method");
        }
        public void DoWork(double i)
        { 
            Console.WriteLine("Int Args method");
        }
        public void DoWork(string str)
        { 
            Console.WriteLine("String Args method");
        }
        public void DoWork(int i, float x)
        { 
            Console.WriteLine("int float Args method");
        }
        public void DoWork(float x, int i)
        { 
            Console.WriteLine("float int Args Method");
        }
        static void Main(string[] args)
        {
            Program program = new Program();
            program.DoWork();
            program.DoWork(20);
            program.DoWork("Overloading");
            program.DoWork('z');
            program.DoWork(10, 20.5f);
            program.DoWork(20.8f, 50);
            Main(10);
            
        }
        static void Main(int a)
        {
            Console.WriteLine("Main method overloaded");
        }
    }
}
