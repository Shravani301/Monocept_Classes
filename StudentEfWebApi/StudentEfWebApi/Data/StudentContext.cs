using Microsoft.EntityFrameworkCore;
using StudentEfWebApi.Models;

namespace StudentEfWebApi.Data
{
    public class StudentContext:DbContext
    {
        public DbSet<Student> students {  get; set; }

        public StudentContext(DbContextOptions<StudentContext> options) : base(options) { }

        
    }
}
