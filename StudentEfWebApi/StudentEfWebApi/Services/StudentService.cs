using StudentEfWebApi.Models;
using StudentEfWebApi.Repositories;

namespace StudentEfWebApi.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public Student GetStudentById(int id)
        {
            return _studentRepository.GetStudentById(id);
        }

        public List<Student> GetStudents()
        {
           return _studentRepository.GetStudents();
        }
        public int Add(Student student)
        {
            return _studentRepository.Add(student);
        }
        public bool Update(Student student)
        {
            var existingStudent= _studentRepository.GetStudentById(student.Id);
            if (existingStudent != null)
            {
                _studentRepository.Update(student);
                return true;
            }
            return false;
            
        }
        public bool Delete(int id)
        {
            var existingStudent = _studentRepository.GetStudentById(id);
            if (existingStudent != null)
            {
                _studentRepository.Delete(existingStudent);
                return true;
            }
            return false;
        }
    }
}
