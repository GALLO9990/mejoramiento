using Employee.Models;
using System.Collections.Generic;

namespace Employee.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<EmployeeModel> employee { get; set; } // Nombres en plural por convención

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Verificamos si ya está configurado antes de añadir opciones
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql(
                    "Server=localhost;Database=planmejoramiento;User=root;Password=tolima80;Port=3306",
                    new MySqlServerVersion(new Version(8, 0, 40))
                );
            }
        }
    }
}
