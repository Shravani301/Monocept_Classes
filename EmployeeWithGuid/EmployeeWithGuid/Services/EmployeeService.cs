using AutoMapper;
using EmployeeWithGuid.Exceptions;
using EmployeeWithGuid.Models;
using EmployeeWithGuid.Repositories;

namespace EmployeeWithGuid.Services
{
    public class EmployeeService : IEmployeeService
    {
        private readonly IRepository<Employee> _repository;
        public EmployeeService(IRepository<Employee> repository)
        {
            _repository = repository;
        }
        public Guid Add(Employee employee)
        {
            _repository.Add(employee);
            return employee.Id;
        }

        public Employee GetById(Guid id)
        {
            var employee = _repository.GetById(id);
            if (employee != null)
                return employee;
            throw new EmployeeNotFoundException("No such employee found");
        }

        public List<Employee> GetEmployees()
        {
            var employees = _repository.GetAll().ToList();
            if (employees != null)
            {
                return employees;
            }
            throw new EmployeesDoesNotExistException("No employees Exist");
        }
    }
}
