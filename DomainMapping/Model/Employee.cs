using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainMapping.Model
{
    internal class Employee
    {
        private int employeeId;
        private string employeeName;
        private int employeeExp;
        private int employeeEmail;
        private int employeePhone;

        public void EmpDetails()
        {
            Console.WriteLine("Domain Mapping Tutorial in C# ");
        }
        public string GetEmployeeName()
        {
            return "Shravani";
        }
        public int GetEmployeeId() {
            return 000091;
        }

    }
}
