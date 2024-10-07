using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractApp.Models
{
    internal class Developer:Employee
    {
        const double PA = 0.40;
        const double TA = 0.30;
        int Months = 12;

        public Developer(int eId,string eName, double eBasic):base(eId,eName,eBasic) 
        {            
        }

        public override double CalculateCTC()
        {
            return ((EmployeeBasic + (PA * EmployeeBasic) + (TA * EmployeeBasic))*Months);
        }

    }
}
