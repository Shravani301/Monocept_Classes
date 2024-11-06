using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToManyDemo.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public string StudentName { get; set; }
        public List<Course> CourseList { get; set; }
    }
}
