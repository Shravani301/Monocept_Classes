using EmployeeWithGuid.Models;

namespace EmployeeWithGuid.Services
{
    public interface IEmployeeService
    {
        public List<Employee> GetEmployees();
        public Employee GetById(Guid id);
        public Guid Add(Employee employee);

    }
}
