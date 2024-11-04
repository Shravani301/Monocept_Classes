using CompanyEFCode.Models;
using CompanyEFCode.Repositories;

namespace CompanyEFCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DepartmentRepository departmentRepository = new DepartmentRepository();
            //GetDepartmentById(departmentRepository);
            //AddDepartment(departmentRepository);
            DeleteDepartment(departmentRepository);
            //GetAllDepartments(departmentRepository);
            //UpdateDepartment(departmentRepository);
            PrintAllInformation(departmentRepository);

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
            string name = Console.ReadLine();
            Department department = new Department()
            {
                Name = name
            };
            departmentRepository.AddDepartment(department);
        }

        public static Department GetDepartmentById(DepartmentRepository departmentRepository)
        {
            Console.WriteLine("Enter DepartmentId:");
            int id = Convert.ToInt32(Console.ReadLine());
            try
            {
                var department = departmentRepository.Get(id);
                return department;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        public static void UpdateDepartment(DepartmentRepository departmentRepository)
        {
            var department = GetDepartmentById(departmentRepository);
            if (department != null)
            {
                Console.WriteLine("Enter Department Name:");
                string name= Console.ReadLine();
                department.Name = name;
            }
        }

        public static void DeleteDepartment(DepartmentRepository departmentRepository)
        {
            var department= GetDepartmentById(departmentRepository);
            if (department != null)
            {
                departmentRepository.Delete(department);
                Console.WriteLine("Department Deleted Successfully");
            }
        }
        public static void PrintAllInformation(DepartmentRepository departmentRepository)
        {
            var departmentsList = departmentRepository.GetAllInformation();
            departmentsList.ForEach(department =>
            {
                Console.WriteLine(department);
                Console.WriteLine("*****Employee Details*****");
                department.Employees.ForEach(employees => 
                Console.WriteLine(employees));
                Console.WriteLine();
            });
        }

    }
}
