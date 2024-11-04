using CompanyEFCode.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyEFCode.Data
{
    internal class CompanyContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Workstation> Workstations { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.AppSettings["connstring"]);
        }
    }
}
