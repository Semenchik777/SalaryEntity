using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryEntity
{
    public class MyDbContext : DbContext
    {
        public MyDbContext() : base("MyDbSalary")
        {
            
        }

        public DbSet<Profession> Professions { get; set; }
        public DbSet<Salary> Salaries { get; set; }


    }
}