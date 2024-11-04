using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyEFCode.Models
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Employee> Employees { get; set; }

        public override string ToString()
        {
            return $"DepartmentId:{Id}\n" +
                $"DepartmentName:{Name}\n" +
                $"=======================";
        }
    }
}
