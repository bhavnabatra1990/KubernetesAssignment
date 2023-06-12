using Microsoft.EntityFrameworkCore;

namespace DatabaseService
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> options)
               : base(options)
        {
        }

        public DbSet<Employee> Employee { get; set; }
    }
}