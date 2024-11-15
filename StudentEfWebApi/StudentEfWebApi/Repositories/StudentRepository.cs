using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using StudentEfWebApi.Data;
using StudentEfWebApi.Models;

namespace StudentEfWebApi.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentContext _context;
        public StudentRepository(StudentContext context)
        {
            _context = context;
        }
        public Student GetStudentById(int id)
        {
            return _context.students.AsNoTracking().FirstOrDefault(s=>s.Id==id);
        }

        public List<Student> GetStudents()
        {
            return _context.students.ToList();
        }
        public int Add(Student student)
        {
            _context.students.Add(student);
            _context.SaveChanges();
            return student.Id;
        }
        public int Update(Student student)
        {
            _context.students.Entry(student).State = EntityState.Modified;
            _context.students.Update(student);
            _context.SaveChanges();
            return student.Id;
        }
        public void Delete(Student student)
        {
            _context.students.Remove(student);
            _context.SaveChanges();            
        }
    }
}
