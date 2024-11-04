using CompanyEFDemo.Models;
using CompanyEFDemo.Repositories;

namespace CompanyEFDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DepartmentRepository departmentRepository = new DepartmentRepository(); 
            GetAllDepartments(departmentRepository);
            GetDepartmentById(departmentRepository);
            AddDepartment(departmentRepository);
        }
        public static void GetAllDepartments(DepartmentRepository departmentRepository)
        {
            var departmentsList = departmentRepository.GetAll();
            departmentsList.ForEach(department =>
            {
                Console.WriteLine(department);
            });
        }
        public static void AddDepartment(DepartmentRepository departmentRepository)
        {
            Console.WriteLine("Enter Department Name:");
            string name=Console.ReadLine();
            Department department = new Department()
            {
                Name=name
            };
            departmentRepository.AddDepartment(department);                
        }
        public static void GetDepartmentById(DepartmentRepository departmentRepository)
        {
            Console.WriteLine("Enter DepartmentId:");
            int id=Convert.ToInt32(Console.ReadLine());
            try
            {
                var department = departmentRepository.Get(id);
                Console.WriteLine(department);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}
