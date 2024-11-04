using CompanyEFCode.Data;
using CompanyEFCode.Exceptions;
using CompanyEFCode.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyEFCode.Repositories
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
            var department = _companyContext.Departments.FirstOrDefault(dept => dept.Id == id);
            if (department == null)
                throw new DepartmentNotFoundException("No such Department exist");
            return department;
        }
        public void AddDepartment(Department department)
        {
            _companyContext.Departments.Add(department);
            _companyContext.SaveChanges();
        }
        public List<Department> GetAllInformation()
        {
            var departmentList = _companyContext.Departments.Include(dept=>dept.Employees)
                .ThenInclude(emp=>emp.Workstation).ToList();
            return departmentList;
        }
        public void Update(Department department)
        {
            _companyContext.Entry(department).State = EntityState.Modified;
            _companyContext.SaveChanges();
        }
        public void Delete(Department department)
        {
            _companyContext.Remove(department);
            _companyContext.SaveChanges();
        }
    }
}
