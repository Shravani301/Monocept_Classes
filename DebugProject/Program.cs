using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b=20,c;
            IncrementNumber(a,b,out c);
            Console.WriteLine("Value of a after Increment Number: " + c);
        }
        static void IncrementNumber(int a,int b,out int c)
        {
            c = a + b;
            Console.WriteLine("Value of c:" + c);
        }
    }
}
