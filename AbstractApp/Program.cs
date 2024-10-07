using AbstractApp.Models;

namespace AbstractApp
{
    internal class Program
    {
        static void Main()
        {
            Print(new ProjectManager(101,"Allen",90000));
            Print(new Developer(102, "Bob", 50000));
            Print(new Developer(103, "Mark", 30000));
        }
        static void Print(Employee employee)
        {
            Console.WriteLine($"{employee.GetType().Name} details is:\n" +employee.PrintDetails());
            Console.WriteLine($"{employee.GetType().Name} Annual CTC is:{employee.CalculateCTC()}\n");
            
        }
    }
}
