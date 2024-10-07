using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numArray = { 1, 2, 3, 4, 5 };
            int[] incrementedArray = IncrementArray(numArray);
            for (int i = 0; i < incrementedArray.Length; i++)
            {
                Console.WriteLine(incrementedArray[i]);
            }
        }
        static int[] IncrementArray(int[] numArray)
        {
            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i]++;

            }
            return numArray;
        }
    }
}
