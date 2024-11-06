using ManyToManyDemo.Models;
using ManyToManyDemo.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToManyDemo.Controllers
{
    internal class CourseController
    {
        private CourseRepository _repository;
        public CourseController() 
        {
            _repository = new CourseRepository();
        }
        public void GetAllCourses()
        {
            var courses = _repository.GetAll();
            courses.ForEach(course =>
            {
                Console.WriteLine($"CourseID:{course.Id}\nCourseName:{course.CourseName}\nStudent Enrolled:{course.StudentList.Count}");
                Console.WriteLine("=======================");
            });
        }
        public void AddCourse()
        {
            Console.WriteLine("Enter course name:");
            string courseName=Console.ReadLine();
            Course course = new Course() { CourseName=courseName};
            _repository.Add( course );
        }
    }
}
