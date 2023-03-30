using Microsoft.EntityFrameworkCore;

namespace KenparkAPI.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}

        public DbSet<Employee> Employees { get; set; }
        public DbSet<SalaryPayments> SalaryPayments { get; set; }
    }
}
