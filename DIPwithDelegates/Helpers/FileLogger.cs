using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPwithDelegates.Helpers
{
    internal class FileLogger
    {
        public void Log(string errorMessage)
        {
            Console.WriteLine("Error logged to File:" + errorMessage);
        }
    }
}
