using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstProject
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C#");
            int myNumber;
            Console.WriteLine("Enter myNumber:");
            myNumber=Convert.ToInt32(Console.ReadLine());

            if (CheckEvenOdd6(myNumber))
                Console.WriteLine("myNumber is Even");
            else 
                Console.WriteLine("myNumber is Odd");
        }
        static void CheckEvenOdd(int myNumber)
        {
            if (myNumber % 2 == 0)
            {
                Console.WriteLine("myNumber is Even");
            }
            else
            {
                Console.WriteLine("myNUmber is Odd");
            }
        }
        static void CheckEvenOdd1(int myNumber)
        {
            if (myNumber % 2 == 0)
                Console.WriteLine("myNumber is Even");
            else
                Console.WriteLine("myNUmber is Odd");
        }
        static bool CheckEvenOdd3(int myNumber)
        {
            if (myNumber % 2 == 0)
                return true;
            else
                return false;
        }
        static bool CheckEvenOdd4(int myNumber)
        {
            if (myNumber % 2 == 0)
                return true;
           return false;
        }
        static bool CheckEvenOdd5(int myNumber)
        {
            var result= myNumber % 2 == 0?true:false;
            return result;
        }
        static bool CheckEvenOdd6(int myNumber)
        {
            return myNumber % 2 == 0;
        }
    }
}
