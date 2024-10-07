using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Models
{
    internal class Clerk:Employee
    {
        double EmployeeBonus { get; set; }
        public Clerk(int eId, string eName, int eAge, double eSalary, double eBonus) : base(eId, eName, eAge, eSalary)
        {
            EmployeeBonus = eBonus;
        }

        public override string PrintDetails()
        {
            return base.PrintDetails()+
                $"Employee Bonus is:{EmployeeBonus}\n";
        }

    }
}
