using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Models
{
    internal class Manager:Employee
    {
        public double EmployeeIncentives {  get; set; }
        public Manager(int eId, string eName, int eAge, double eSalary, double eIncentives) : base(eId, eName, eAge, eSalary)
        { 
            EmployeeIncentives =eIncentives;
        }

        public override string PrintDetails()
        {
            return base.PrintDetails()+
                $"Employee Bonus is:{EmployeeIncentives}\n";
        }
    }
}
