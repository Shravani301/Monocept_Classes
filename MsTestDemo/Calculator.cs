using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MsTestDemo
{
    internal class Calculator
    {
        public int CubeOfEvenNumber(int num)
        {
            if (num % 2 == 0)
                return (int)Math.Pow(num, 3);
            return -1;
        }
    }
}
