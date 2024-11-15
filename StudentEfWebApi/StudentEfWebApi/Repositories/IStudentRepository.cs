using StudentEfWebApi.Models;

namespace StudentEfWebApi.Repositories
{
    public interface IStudentRepository
    {
        public List<Student> GetStudents();
        public Student GetStudentById(int id);
        public int Add(Student student);    
        public int Update(Student student); 
        public void Delete(Student student);
    }
}
