using ManyToManyDemo.Data;
using ManyToManyDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToManyDemo.Repositories
{
    internal class StudentRepository
    {
        MyContext _context;
        public StudentRepository()
        {
            _context = new MyContext();
        }
        public List<Student> GetAll()
        {
            return _context.Students.Include(Student=>Student.CourseList).ToList();
        }
        public void Add(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }
        public void Enroll(string studentName, ISet<int>courseIds)
        {
            var studentToEnroll = _context.Students
                                   .Include(s => s.CourseList)
                                   .FirstOrDefault(s => s.StudentName == studentName);

            if (studentToEnroll == null)
            {
                Console.WriteLine("Student not found.");
                return;
            }

            foreach (var courseId in courseIds)
            {
                var course = _context.Courses.Find(courseId);
                if (course != null && !studentToEnroll.CourseList.Contains(course))
                {
                    studentToEnroll.CourseList.Add(course);
                }
            }
            _context.SaveChanges();
        }
        public void AddAndEnroll(Student student, ISet<int> courseIds)
        {
            var coursesList=new List<Course>();
            foreach (var courseId in courseIds)
            {
                var course=_context.Courses.Find(courseId);
                coursesList.Add(course);
            }
            var newStudent = new Student()
            {
                StudentName = student.StudentName,
                CourseList = coursesList,
            };

            _context.Students.Add(newStudent);
            _context.SaveChanges();
        }
        public void TransferCourse(string studentName, int initialCourseId, int newCourseId)
        {
            var student = _context.Students
                                  .Include(s => s.CourseList)
                                  .FirstOrDefault(s => s.StudentName == studentName);

            var initialCourse = student.CourseList.FirstOrDefault(c => c.Id == initialCourseId);

            student.CourseList.Remove(initialCourse);
            student.CourseList.Add(_context.Courses.Find(newCourseId));

            _context.Entry(student).State = EntityState.Modified;

            _context.SaveChanges();

            Console.WriteLine("Course transfer successful.");
        }
    }
}
