using Microsoft.EntityFrameworkCore;
using AssignmentTracker.Server.Models;

namespace AssignmentTracker.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Assignment> Assignments { get; set; } = null!;
    }
}
