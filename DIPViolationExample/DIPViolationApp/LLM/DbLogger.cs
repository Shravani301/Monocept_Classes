using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPViolationApp.LLM
{
    internal class DbLogger
    {
        public void Log(string errorMessage)
        {
            Console.WriteLine(errorMessage);
        }
    }

}
