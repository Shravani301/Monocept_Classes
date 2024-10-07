using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractApp.Models
{
    internal class ProjectManager:Employee
    {
        const double HRA = 0.50;
        const double DA = 0.40;
        const double TA = 0.50;
        int Months = 12;
        public ProjectManager(int eId, string eName, double eBasic) : base(eId, eName, eBasic)
        { 
        }

        public override double CalculateCTC()
        {
            return (EmployeeBasic + (EmployeeBasic * HRA) + (EmployeeBasic * DA) + (EmployeeBasic * TA))*(Months);
        }
    }
}
