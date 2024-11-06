using ManyToManyDemo.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToManyDemo.Data
{
    internal class MyContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses {  get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.AppSettings["ConnString"]);
        }
    }
}
