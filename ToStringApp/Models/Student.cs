using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToStringApp.Models
{
    internal class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Student(int id, string name)
        { 
            this.Id = id;
            this.Name = name;
        }
        public override bool Equals(object obj)
        {
            Student student = (Student)obj;
            return (this.Id==student.Id && this.Name==student.Name) ;
        }
        public override string ToString()
        {
            return "Id is :"+Id+"......"+"Name is :"+Name;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
