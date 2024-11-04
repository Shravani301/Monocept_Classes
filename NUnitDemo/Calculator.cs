using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitDemo
{
    internal class Calculator
    {
        public int CubeOfEvenNumber(int number)
        {
            if(number%2==0)
                return (int)Math.Pow(number, 3);
            return -1;
        }
    }
}
