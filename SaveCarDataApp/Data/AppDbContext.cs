using Microsoft.EntityFrameworkCore;
using SaveCarDataApp.Models;

namespace SaveCarDataApp.Data
{
    public class AppDbContext : DbContext
    {
        protected IConfiguration Configuration;
        public AppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(Configuration.GetConnectionString("DatabaseConnectionString"));
        }

        public DbSet<Car> Cars { get; set; }    
    }
}
