using CompanyEFDemo.Data;
using CompanyEFDemo.Exceptions;
using CompanyEFDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyEFDemo.Repositories
{
    internal class DepartmentRepository
    {
        private CompanyContext _companyContext;
        public DepartmentRepository()
        {
            _companyContext = new CompanyContext();
        }
        public List<Department> GetAll()
        {
            var departmentList = _companyContext.Departments.ToList();
            return departmentList;
        }
        public Department Get(int id)
        {
            var department=_companyContext.Departments.FirstOrDefault(dept => dept.Id == id);
            if (department == null)
                throw new DepartmentNotFoundException("No such Department exist");
            return department;
        }
        public void AddDepartment(Department department)
        {
            _companyContext.Departments.Add(department);
            _companyContext.SaveChanges();
        }
    }
}
