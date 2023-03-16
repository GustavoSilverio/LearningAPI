using ApiCarros.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiCarros.Context
{
    public class AppDbContext : DbContext

    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)

        { }


        public DbSet<Car> Cars { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IConfiguration configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false, true)
                .Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("ServerConnection"));
        }
    }
}