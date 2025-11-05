using BlogApi.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace BlogApi.Infra
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }

        public DbSet<Comment> Comment { get; set; }
        public DbSet<BlogPost> BlogPost { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<BlogPost>()
                .HasMany(b => b.Comentarios)
                .WithOne(c => c.BlogPost)
                .HasForeignKey(c => c.BlogPostId)
                .OnDelete(DeleteBehavior.Cascade);
        }

    }
}
