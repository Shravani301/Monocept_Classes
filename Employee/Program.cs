using Employee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Employee1 employee1=new Manager(101, "Alice", 90000);

            Console.WriteLine(Display(employee1));

            Employee1 employee2 = new Developer(102, "Bob", 60000);
            Console.WriteLine(Display(employee2));

            Employee1 employee3 = new Tester(103, "Rohan", 30000);
            Console.WriteLine(Display(employee3));

        }
        public static string Display(Employee1 emp)
        {
            return $"{emp.GetType().Name} Information is:\n"+
                $"Employee Id: {emp.EmpId}\n" +
                $"Employee Name: {emp.EmpName}\n" +
                $"Employee Salary: {emp.EmpBasicSalary}\n" +
                $"Employee CTC: {emp.CalculateSalary()}\n";
        }
    }
}
