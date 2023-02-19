using Microsoft.EntityFrameworkCore;

namespace SurvManager.Models
{
    public class ManagerContext : DbContext
    {
        public ManagerContext(DbContextOptions<ManagerContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasMany(c => c.Projects)
                .WithOne(a => a.Category)
                .HasForeignKey(a => a.CategoryId);
        }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
