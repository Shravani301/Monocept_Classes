using StudentEfWebApi.Models;

namespace StudentEfWebApi.Services
{
    public interface IStudentService
    {
        public List<Student> GetStudents();
        public Student GetStudentById(int id);
        public int Add(Student student);    
        public bool Update(Student student);
        public bool Delete(int id);

    }
}
