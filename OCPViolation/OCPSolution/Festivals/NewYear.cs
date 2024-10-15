using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPSolution.Festivals
{
    internal class NewYear : IFestival
    {
        public double GetInterestRate()
        {
            return 8.0;
        }
    }
}
