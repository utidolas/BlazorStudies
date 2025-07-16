using BlazorSyncFusion.Shared.Entities;
using Microsoft.EntityFrameworkCore;
namespace BlazorSyncFusion.Data
{
    public class ApplicationDbContext : DbContext
    {
        // DbSet properties for each entity
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options) : base (options)
        {
        }

        // Represents the Users table in the database
        public DbSet<User> Users { get; set; } = default!; // Initialize to default to avoid null reference issues

    }
}
