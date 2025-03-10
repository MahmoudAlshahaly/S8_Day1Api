using Microsoft.EntityFrameworkCore;

namespace S8_Day1Api.Models
{
    public class CompanyContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("SERVER = .;DATABASE = S8COMPANYAPI ; INTEGRATED SECURITY = TRUE; TRUSTSERVERCERTIFICATE = TRUE;");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
