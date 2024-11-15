using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentEfWebApi.Data;
using StudentEfWebApi.Models;
using StudentEfWebApi.Services;

namespace StudentEfWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_studentService.GetStudents());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_studentService.GetStudentById(id));
        }
        [HttpPost]
        public IActionResult Add(Student student)
        {
            return Ok(_studentService.Add(student));
        }

        [HttpPut]
        public IActionResult Modify(Student student)
        {
            if (_studentService.Update(student))
            
                return Ok(student); 
            
            return NotFound("No such Student found");
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (_studentService.Delete(id))
            {
               return Ok();
            }
            return NotFound("No such student found to delete");
        }
    }
}
