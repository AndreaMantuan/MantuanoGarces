using MantuanoGarces.model;
using Microsoft.EntityFrameworkCore;


namespace MantuanoGarces.model
{
    public class AplicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // El connectionString debe venir de un archivo de configuraciones
            optionsBuilder.UseSqlServer("Server=LAPTOP-K4PVUIK8;Database=MantuanoGarces;Trusted_Connection=True")
                .EnableSensitiveDataLogging(true)
                .UseLoggerFactory(LoggerFactory.Create(builder =>
                {
                    builder.AddConsole().SetMinimumLevel(LogLevel.Information);
                }));
        }
        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<Genero> generos { get; set; }
    }
}
