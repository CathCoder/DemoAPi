using DemoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoApi.DBContext
{
    public class ProjectDbContext : DbContext
    {
        public ProjectDbContext(DbContextOptions<ProjectDbContext> options) : base(options)
        {
        }

        public virtual DbSet<Project> Projects { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema("demo");

            modelBuilder.Entity<Project>(entity =>
            {
                entity.HasKey(e => e.ProjectId); // Define primary key
                 
            });
        }
    }
}
