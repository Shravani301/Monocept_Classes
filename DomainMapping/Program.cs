using DomainMapping.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainMapping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.EmpDetails();
            String name = employee.GetEmployeeName();
            Console.WriteLine("Employees name : "+name);
            Console.WriteLine("Employee Id is : "+employee.GetEmployeeId());
        }
    }
}
