using EmployeeApp.Models;
using System.Security.Cryptography.X509Certificates;

namespace EmployeeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee;
            employee=  new Employee(101,"Allen",28,20000);
            Print(employee);
            employee = new Manager(102, "Bob", 34, 30000,6000);
            Print(employee);
            employee = new Clerk(103, "Kate", 36, 23790, 4000);
            Print(employee);
        }
        public static void Print(Employee emp)
        {
            Console.WriteLine($"{emp.GetType().Name} Details is:\n" + emp.PrintDetails());

        }
    }
}
