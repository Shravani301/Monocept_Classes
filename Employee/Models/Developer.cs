using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Models
{
    internal class Developer:Employee1
    {
        const int PA = 40;
        const int TOTAL_MONTH = 12;
        const int DIVIDER = 100;
        public Developer(int id, string name, double basicSalary) : base(id, name, basicSalary)
        {
        }

        public override double CalculateSalary()
        {
            return (EmpBasicSalary+(EmpBasicSalary*PA)/DIVIDER)*TOTAL_MONTH;
        }
    }
}
