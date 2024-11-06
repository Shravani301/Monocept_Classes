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
    internal class CourseRepository
    {
        MyContext _context;
        public CourseRepository()
        {
            _context = new MyContext();
        }
        public List<Course> GetAll()
        {
            return _context.Courses.Include(Course=>Course.StudentList).ToList();
        }
        public void Add(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
        }
    }
}
