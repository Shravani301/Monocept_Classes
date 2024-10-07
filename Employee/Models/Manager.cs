using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Models
{
    internal class Manager:Employee1
    {
        const int TA = 50;
        const int DA = 40;
        const int TOTAL_MONTH = 12;
        const int DIVIDER = 100;
        public Manager(int id, string name, double basicSalary) : base(id, name, basicSalary)
        {
        }
        public override double CalculateSalary()
        {
            return (EmpBasicSalary + (EmpBasicSalary * TA) / DIVIDER + (EmpBasicSalary * DA) / DIVIDER)*TOTAL_MONTH;
        }

    }
}
