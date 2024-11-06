using LinQEmp.Models;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LinQEmp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){Id=101,Name="shirisha",Age=22,DepartmentName="Telecomm",Salary=9500,JoinDate=new DateTime(2024, 5, 5) },
                new Employee(){Id=102,Name="ALekhya",Age=24,DepartmentName="IT&Telecomm",Salary=2500,JoinDate=new DateTime(2024, 10, 5) },
                new Employee(){Id=103,Name="srivani",Age=23,DepartmentName="IT",Salary=12500,JoinDate=new DateTime(2024, 7, 16) },
                new Employee(){Id=104,Name="swetha",Age=21,DepartmentName="Sales",Salary=11500,JoinDate=new DateTime(2024, 8, 15) },
                new Employee(){Id=105,Name="Nikitha",Age=32,DepartmentName="IT",Salary=14000,JoinDate=new DateTime(2024, 9, 13) },
                new Employee(){Id=106,Name="Laya",Age=20,DepartmentName="IT",Salary=23500,JoinDate=new DateTime(2024, 8, 15) },
                new Employee(){Id=107,Name="shirisha",Age=22,DepartmentName="Sales",Salary=15500,JoinDate=new DateTime(2023, 10, 5) },
                new Employee(){Id=108,Name="Manisha",Age=34,DepartmentName="IT",Salary=68500,JoinDate=new DateTime(2020, 11, 5) },
                new Employee(){Id=109,Name="Manisha",Age=32,DepartmentName="Sales",Salary=9500,JoinDate=new DateTime(2024, 10, 5) },
                new Employee(){Id=110,Name="Vyshnavi",Age=21,DepartmentName="Sales",Salary=12000,JoinDate=new DateTime(2024, 4, 5) },
                new Employee(){Id=111,Name="Sneha",Age=34,DepartmentName="HR",Salary=71000,JoinDate=new DateTime(2022, 10, 5) },
                new Employee(){Id=112,Name="Sneha",Age=23,DepartmentName="Telecomm",Salary=7500,JoinDate=new DateTime(2024, 6, 4) },
                new Employee(){Id=113,Name="Chandana",Age=23,DepartmentName="Accounts",Salary=17500,JoinDate=new DateTime(2024, 9, 23) },
                new Employee(){Id=114,Name="Ashish",Age=41,DepartmentName="IT",Salary=65500,JoinDate=new DateTime(2021, 2, 15) },
                new Employee(){Id=115,Name="Rohit",Age=22,DepartmentName="IT",Salary=15000,JoinDate=new DateTime(2024, 4, 15) },
                new Employee(){Id=116,Name="Pavan",Age=24,DepartmentName="IT",Salary=10000,JoinDate=new DateTime(2024, 4, 5) },              
            };
            List<Department> departments=new List<Department>()
            {
                new Department(){ Id=1,DepartmentName="IT"},
                new Department(){ Id=2,DepartmentName="Sales"},
                new Department(){ Id=3, DepartmentName="IT&Telecomm"},
                new Department(){ Id=4,DepartmentName="Telcomm"},
                new Department(){ Id=5,DepartmentName="HR"},
                new Department(){ Id=6,DepartmentName="Accounts"},
                  
            };

            //1.List all employee names and their departments.
            Console.WriteLine("1.All employees with name and departments:\n" +
                "=====================================================");
            employees.ToList().ForEach(e => Console.WriteLine($"{e.Name,-15} {e.DepartmentName}"));

            //2.Retrieve all employees in the "IT" department whose salary is above 60,000
            Console.WriteLine("\n2.All employees in the \"IT\" department whose salary is above 60,000\n" +
                "===============================================================");
            employees.Where(Employee=>Employee.Salary>60000 && Employee.DepartmentName=="IT").ToList()
                .ForEach(e=>Console.WriteLine($"{e.Name,-15}{e.DepartmentName,-10}{e.Salary}"));

            //3.Display employees ordered by their joining date.
            Console.WriteLine("\n3.Employees orderd by their joining date\n" +
                "=============================================================");
            employees.OrderBy(employee => employee.JoinDate).ToList().
                ForEach(e => Console.WriteLine($"{e.Name,-15}{e.JoinDate}"));

            //4.//Display employees by descending order of their salary within each department.
            Console.WriteLine("\n4.Employees by descending order of their salary within each department.\n" +
                "=============================================================");
            employees.OrderByDescending(employee => employee.Salary).ThenBy(e => e.DepartmentName).ToList().
                ForEach(e => Console.WriteLine($"{e.Salary,-15}{e.DepartmentName}"));
            //Grouping (GroupBy):
            Console.WriteLine("\n5.Grouping employees by department and showing the number of employees in each department.\n" +
                "================================================================");
           employees.GroupBy(e => e.DepartmentName).ToList().
                ForEach(group => Console.WriteLine($"{group.Key,-15}{group.Count()}"));
            Console.WriteLine("\n6.Displaying the average salaries by department.\n" +
               "==============================================================");
                employees.GroupBy(e => e.DepartmentName)
             .Select(g => new { Department = g.Key, AverageSalary = g.Average(e => e.Salary) })
             .ToList()
             .ForEach(g => Console.WriteLine($"{g.Department,-18}{g.AverageSalary}"));

            //Joining (Join): Suppose there’s a list of Department objects with properties DepartmentId and DepartmentName. Perform an inner join to list employee names along with their department names.
            Console.WriteLine("\n7.Inner join display the list of employee names along with their department names.\n" +
                "==============================================================");
            var employeeDepartmentJoin = employees.Join(departments,
                employee => employee.DepartmentName,
                department => department.DepartmentName,
                (employee, department) => new
                {
                    EmployeeName = employee.Name,
                    DepartmentName = department.DepartmentName
                }
            );
            foreach (var item in employeeDepartmentJoin)
            {
                Console.WriteLine($"{item.EmployeeName,-15}{item.DepartmentName}");
            }

            //Aggregation (Count, Sum, Average, Min, Max):

            Console.WriteLine("\n8.Total number of employees.\n" +
                "====================================");
            Console.WriteLine(employees.Count());

            Console.WriteLine("\n9.Total salary expenditure.\n" +
                "===================================");
            Console.WriteLine(employees.Sum(e => e.Salary));
           
            Console.WriteLine("\n10.Average age of employees.\n" +
               "==============================");
            Console.WriteLine(employees.Average(e => e.Age));
            Console.WriteLine("\n11.Employee with the highest salary.\n" +
                "=====================================");
            Console.WriteLine(employees.Max(e => e.Salary));
            
            Console.WriteLine("\n12.Minimum salary in the \"HR\" department.\n" +
                "============================================");
            Console.WriteLine(employees.Where(e => e.DepartmentName == "HR").
                Min(e => e.Salary));
            //Partitioning (Take, Skip):
            
            Console.WriteLine("\n13.Displaying the top 3 highest-paid employees.\n" +
                "============================================="); 
            employees.OrderByDescending(e=>e.Salary).Take(3).ToList().
                ForEach(emp => Console.WriteLine($"{emp.Name,-15}{emp.Salary}"));
            
            Console.WriteLine("\n14.Skip the first 3 highest paid employees and displaying the next 3 highest-paid.\n" +
                "==========================================================");
            employees.OrderByDescending(e => e.Salary).Skip(3).ToList().
              ForEach(e => Console.WriteLine($"{e.Name,-15}{e.Salary}"));
            
            Console.WriteLine("\n15.Checking if any employee is under 25 years of age.\n" +
                "=====================================================");
            Console.WriteLine("employees under age 25:" + employees.Any(e => e.Age < 25));
            
            Console.WriteLine("\n16.Ensure all employees have a salary above 30,000.\n" +
                "========================================================");
            Console.WriteLine("All employees Salary above 30000" + employees.All(e => e.Salary> 30000));

            Console.WriteLine("\n17.List all unique departments (use a List<string> of department names as sample data)\n" +
                "===========================================================================================");

            employees.Select(e => e.DepartmentName).Distinct().ToList()
                     .ForEach(department => Console.WriteLine(department));
        }
    }
}