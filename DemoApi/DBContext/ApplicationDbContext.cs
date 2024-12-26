using DemoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoApi.DBContext
{
    public class ApplicationDbContext :  DbContext
    {
        public ApplicationDbContext(DbContextOptions <ApplicationDbContext> options) : base (options)
        {
            
        }
        public virtual DbSet<Product> Products { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.HasDefaultSchema("demo");

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ProductId);
            });


        }



    }
}
