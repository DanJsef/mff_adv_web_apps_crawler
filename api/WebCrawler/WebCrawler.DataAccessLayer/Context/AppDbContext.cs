using Microsoft.EntityFrameworkCore;
using WebCrawler.DataAccessLayer.Models;

namespace WebCrawler.DataAccessLayer.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer();
            }
        }

        public DbSet<WebsiteRecord> Records { get; set; }
        public DbSet<Tag> Tags { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
    
}
