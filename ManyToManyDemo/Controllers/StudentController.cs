using ManyToManyDemo.Models;
using ManyToManyDemo.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToManyDemo.Controllers
{
    internal class StudentController
    {
        StudentRepository _studentRepository;
        public StudentController()
        {
            _studentRepository = new StudentRepository();
        }
        public void GetAllStudents()
        {
            var students = _studentRepository.GetAll();
            students.ForEach(student =>
            {
                Console.WriteLine($"StudentID:{student.Id}\nStudentName:{student.StudentName}\nTotal courses enrolled:{student.CourseList.Count}");
                Console.WriteLine("-----------------------------------");
            });
        }
        public void AddStudent()
        {
            Console.WriteLine("Enter student name:");
            string studentName=Console.ReadLine();
            var student = new Student() { StudentName=studentName};
            _studentRepository.Add(student);
        }
        public void EnrollStudent()
        {
            Console.WriteLine("Enter student name:");
            string studentName = Console.ReadLine();
            Console.WriteLine("How many course do you wish to enrolled in");
            int numberOfCourses=Convert.ToInt32(Console.ReadLine());
            var courseList=new HashSet<int>();   
            for (int i = 0; i < numberOfCourses; i++)
            {
                Console.WriteLine("Enter courseId");
                int courseId=Convert.ToInt32(Console.ReadLine()); 
                courseList.Add(courseId);
            }
            _studentRepository.Enroll(studentName,courseList);
            Console.WriteLine("Enrolled Successfull");
        }
        public void AddAndEnrollStudent()
        {
            Console.WriteLine("Enter student name:");
            string studentName = Console.ReadLine();
            var student = new Student() { StudentName = studentName };
            Console.WriteLine("How many course do you wish to enrolled in");
            int numberOfCourses = Convert.ToInt32(Console.ReadLine());
            var courseList = new HashSet<int>();
            for (int i = 0; i < numberOfCourses; i++)
            {
                Console.WriteLine("Enter courseID");
                int courseId=Convert.ToInt32(Console.ReadLine());
                courseList.Add(courseId);
            }
            _studentRepository.AddAndEnroll(student, courseList);
            Console.WriteLine("Student added and enrolled successfull");

        }
        public void TransferStudentCourse()
        {
            Console.WriteLine("Enter student name:");
            string studentName = Console.ReadLine();
            Console.WriteLine("Enter Initial courseID");
            int initailCourseId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter new courseID");
            int newCourseId = Convert.ToInt32(Console.ReadLine());
            _studentRepository.TransferCourse(studentName, initailCourseId,newCourseId);
        }

    }
}
