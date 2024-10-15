using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBuddy.Models
{
    internal class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string StudentEmail { get; set; }

        static LinkedList<Student> students = new LinkedList<Student>();

        public Student(int studentId, string studentName, string studentEmail)
        {
            StudentId = studentId;
            StudentName = studentName;
            StudentEmail = studentEmail;
        }


        public static void AddStudent(Student student)
        {
            students.AddLast(student);
        }


        public static void PrintStudents(Student student)
        {
            bool startPrinting = false;
            foreach (var stud in students)
            {
                if (stud.Equals(student))
                {
                    startPrinting = true;
                    Console.WriteLine($"==== Using Student{student.StudentId} ====");
                }
                if (startPrinting)
                    Console.WriteLine(stud);
            }
            if (students.Last.Value.Equals(student))
                Console.WriteLine("No friends to display.");
            
        }

        public override string ToString()
        {
            return $"Student Id: {StudentId}\n" +
                   $"Student Name: {StudentName}\n" +
                   $"Student Email: {StudentEmail}\n";
        }


    }
}
