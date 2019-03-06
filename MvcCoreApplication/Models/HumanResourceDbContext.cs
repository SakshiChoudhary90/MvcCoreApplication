using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreApplication.Models
{
    public class HumanResourceDbContext: DbContext
    {
        //multi touple at a time.....
        //Departments is table name... Department is class name.....
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Manager> Managers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=TRD-512;Initial Catalog=demodb2;Integrated Security=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
