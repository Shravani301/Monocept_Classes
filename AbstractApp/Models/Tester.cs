using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractApp.Models
{
    internal class Tester:Employee
    {
       const double OT = 0.30;
        int Months = 12;

        public Tester(int eId, string eName, double eBasic) : base(eId, eName, eBasic)
        { }

        public override double CalculateCTC()
        {
            return (EmployeeBasic + (EmployeeBasic * OT))*Months;
        }
    }
}
