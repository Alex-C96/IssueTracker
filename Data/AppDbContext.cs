using IssueTracker.Models;
using Microsoft.EntityFrameworkCore;

namespace IssueTracker.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Issue> Issues { get; set; } = null!;

        public string DbPath { get; }

        public AppDbContext()
        {
            DbPath = "IssueTracker.db";
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            DbPath = "IssueTracker.db";
        }
    }
}
