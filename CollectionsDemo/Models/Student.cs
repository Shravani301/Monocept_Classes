using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsDemo.Models
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentEmail { get; set; }

        public Student(int studentId, string studentName, string studentEmail)
        {
            StudentId = studentId;
            StudentName = studentName;
            StudentEmail = studentEmail;
        }

        public override string ToString()
        {
            return $"Student Id: {StudentId}\n" +
                   $"Student Name: {StudentName}\n" +
                   $"Student Email: {StudentEmail}\n";
        }
    }
}
