using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 30;
            Object obj = number1;
            Console.WriteLine("Boxing->converting int value type to obj/reference type: "+obj);
            int number2 = (int)obj;
            Console.WriteLine("Unboxing-> COnverting Obj/ reference type to value type: "+number2);
        }
    }
}
