using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentWebApi.Models;

namespace StudentWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private List<Student> students { get; set; }
        public StudentController() 
        {
            students = new List<Student>() 
            {
                new Student(){ Id=101,Name="Shravani", Email="shravanikonga@gmail.com"},
                new Student(){ Id=102,Name="Shirisha", Email="shirisha@gmail.com"},
                new Student(){ Id=103,Name="Sneha",Email="sneha@gmail.com"},
            };
        
        }
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(students);
        }

        [HttpPost]
        public IActionResult Add(Student student)
        {
            students.Add(student);
            return Ok(students);
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var student=students.Where(s=>s.Id==id).FirstOrDefault(); 
            return Ok(student); 
        }
        [HttpPut("{id}")]
        public IActionResult Modify(int id, Student student)
        {
            var existingStudent=students.Where(s=>s.Id==id).FirstOrDefault();
            if (existingStudent != null)
            {
                existingStudent.Name = student.Name;
                existingStudent.Email = student.Email;
                return Ok(students);
            }
            return NotFound();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var existingStudent = students.Where(s => s.Id == id).FirstOrDefault();
            if (existingStudent != null)
            {
                students.Remove(existingStudent);
                return Ok(students);
            }
            return NotFound();
        }

    }
}
