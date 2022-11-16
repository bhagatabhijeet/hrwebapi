using hrweb.api.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace hrweb.api.Data
{
    public class HrDbContext:DbContext
    {
        public HrDbContext(DbContextOptions<HrDbContext> options):base(options)
        {          

        }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Dependent> Dependents { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Location> Locations { get; set; }
    }
}
