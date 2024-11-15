using Microsoft.EntityFrameworkCore;
using MVCEmployee.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace MVCEmployee.Data
{
    public class EmpContext:DbContext
    {
        public DbSet<Employee> employees { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=SHRAVANI\\SQLEXPRESS;Initial Catalog=MVCEmployee;Integrated Security=True;Connect Timeout=30;Encrypt=False;");
        }

    }
}