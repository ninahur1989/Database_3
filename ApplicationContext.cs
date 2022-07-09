using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Database_3
{
    public class ApplicationContext : DbContext
    {
        private readonly string _connectionString = " Data Source=DESKTOP-D9VSSPS;Initial Catalog = Application;Integrated Security=True";
        public DbSet<Project> Projects { get; set; }

        public DbSet<EmployeeProject> EmployeeProjects { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Office> Offices { get; set; }
        public DbSet<Title> Titles { get; set; }
        public DbSet<Client> Clients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Configuraions.EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new Configuraions.EmployeeProjectConfiguration());
            modelBuilder.ApplyConfiguration(new Configuraions.OfficeConfiguration());
            modelBuilder.ApplyConfiguration(new Configuraions.TitleConfiguration());
            modelBuilder.ApplyConfiguration(new Configuraions.ProjectConfiguration());
        }
    }
}
