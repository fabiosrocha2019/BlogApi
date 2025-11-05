using BlogApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogApi.Infra.Mappings
{
    public class CommentMapping : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("Comment");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Autor)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(c => c.Conteudo)
                .IsRequired();

            builder.Property(c => c.BlogPostId)
                .IsRequired();
        }
    }
}
