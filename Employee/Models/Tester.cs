using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Models
{
    internal class Tester:Employee1
    {
        const int PERKS = 30;
        const int TOTAL_MONTH = 12;
        const int DIVIDER = 100;

        public Tester(int id, string name, double basicSalary) : base(id, name, basicSalary)
        {
        }
        public override double CalculateSalary()
        {
            return (EmpBasicSalary+(EmpBasicSalary*PERKS)/DIVIDER)*TOTAL_MONTH;
        }
    }
}
