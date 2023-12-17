using GenericTemplateAPI.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace GenericTemplateAPI.API.Context
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Pokemon> Pokemon { get; set; }
        public DbSet<PokemonType> PokemonTypes { get; set; }
        public DbSet<Evolution> Evolutions { get; set; }

        public DatabaseContext() { }
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
            .AddJsonFile($"appsettings.json", true, true);

            string connectionString =
            builder.Build().GetConnectionString("DefaultConnection");

            if (optionsBuilder.IsConfigured == false)
            {
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pokemon>()
                .Property(p => p.Id)
                .ValueGeneratedNever();

            modelBuilder.Entity<Pokemon>()
                .Navigation(p => p.PokemonTypes)
                .AutoInclude();
        }
    }
}
