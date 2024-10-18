using Microsoft.EntityFrameworkCore;

namespace backend.Models
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options) { }

        //protected override void OnConfiguring(DbContextOptionsBuilder options)
        //{
        //    string? connectionString = _configuration.GetConnectionString("DefaultConnection");
        //    if (options.IsConfigured && connectionString != null) {
        //        options.UseMySQL(connectionString);
        //    }

        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        { }
    }
}
