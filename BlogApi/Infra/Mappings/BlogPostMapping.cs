using BlogApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogApi.Infra.Mappings
{
    public class BlogPostMapping : IEntityTypeConfiguration<BlogPost>
    {
        public void Configure(EntityTypeBuilder<BlogPost> builder)
        {
            builder.ToTable("BlogPost");

            builder.HasKey(b => b.Id);

            builder.Property(b => b.Titulo)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(b => b.Conteudo)
                .IsRequired();

            builder.HasMany(b => b.Comentarios)
                .WithOne(c => c.BlogPost)
                .HasForeignKey(c => c.BlogPostId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
