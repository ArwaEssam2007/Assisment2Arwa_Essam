using Assisment2Arwa_Essam.Models;
using Microsoft.EntityFrameworkCore;
namespace Assisment2Arwa_Essam.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet <Cinema> Cinema { get; set; }
    }
}
