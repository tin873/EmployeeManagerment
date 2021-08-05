using EmployeeManagerment.Model;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagerment.DataAccessLayer
{
    public class EmployeeManagermentDbContext : DbContext
    {
        public EmployeeManagermentDbContext(DbContextOptions<EmployeeManagermentDbContext> options) : base(options)
        { }
        //public EmployeeManagermentDbContext() { }
        public virtual DbSet<Employee> Employees { get; set; }

        public virtual DbSet<Department> Departments { get; set; }

    }
}
