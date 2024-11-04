using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyEFCode.Models
{
    internal class Employee
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }

        public Workstation Workstation { get; set; }

        [ForeignKey("Workstation")]
        public int? WorkstationId { get; set; }
        public Department Department { get; set; }

        [ForeignKey("Department")]

        public int? DepartmentId { get; set; }

        public override string ToString()
        {
            return $"EmployeeId: {Id}\n" +
                $"EmployeeName: {Name}\n" +
                $"Email: {Email}\n" +
                $"Salary: {Salary}\n" +
                $"Workstation:{WorkstationId}\n";
        }
    }
}
