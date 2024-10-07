using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractApp.Models
{
    internal abstract class Employee
    {
        readonly int _employeeId;
        readonly string _employeeName;
        protected double EmployeeBasic;

        public Employee(int employeeId, string employeeName,double employeeBasic)
        { 
            _employeeId = employeeId;
            _employeeName = employeeName;
            EmployeeBasic = employeeBasic;
        }
        public abstract double CalculateCTC();
        public string PrintDetails()
        {
            return $"Employee Id is:{_employeeId}\n" +
                $"Employee Name is:{_employeeName}\n" +
                $"Employee Basic Salary is:{EmployeeBasic}";
        }

    }
}
