using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPSolution.Helpers
{
    internal class FileLogger : ILogger
    {
        public void Log(string errorMessage)
        {
            Console.WriteLine("Error logged to File:" + errorMessage);
        }
    }
}
