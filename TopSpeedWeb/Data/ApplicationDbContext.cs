using Microsoft.EntityFrameworkCore;
using TopSpeedWeb.Models;

namespace TopSpeedWeb.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<BrandModel> Brand { get; set; }
    }
}
