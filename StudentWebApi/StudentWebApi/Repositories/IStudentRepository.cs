using StudentWebApi.Models;

namespace StudentWebApi.Repositories
{
    public interface IStudentRepository
    {
        public Student GetStudentById(int id); 
        public List<Student> GetAllStudents();


    }
}
