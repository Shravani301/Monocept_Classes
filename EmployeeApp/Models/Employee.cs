using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeApp.Models
{
    internal class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int  EmployeeAge { get; set; }
        public double EmployeeSalary { get; set; }

        public Employee(int eId,string eName,int eAge,double eSalary)
        {
            EmployeeId = eId;
            EmployeeName = eName;
            EmployeeAge = eAge;
            EmployeeSalary = eSalary;
        }
        public virtual string PrintDetails()
        {
            return $"Employee Id is: {EmployeeId}\n" +
                $"Employee Name is: {EmployeeName}\n"+
                $"Employee Age is: {EmployeeAge}\n"+
                $"Employee Salaray is:{EmployeeSalary}\n";
        }

    }
}
