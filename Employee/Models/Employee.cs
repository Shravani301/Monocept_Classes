using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Models
{
    internal class Employee1
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public double EmpBasicSalary { get; set; }

        public Employee1(int id, string name, double basicSalary)
        {
            EmpId = id;
            EmpName = name;
            EmpBasicSalary = basicSalary;
        }

        public virtual double CalculateSalary() {
            return 0.0;
        }
        
    }
}
