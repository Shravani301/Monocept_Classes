using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyEFDemo.Models
{
    internal class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }

        public Workstation Workstation { get; set; }   
        public Department Department { get; set; }
        
        [ForeignKey("Department")]

        public int? DepartmentId { get; set; }
    }
}
