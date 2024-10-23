using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPSolution.Helpers
{
    internal interface ILogger
    {
        public void Log(string errorMessage);
    }
}
