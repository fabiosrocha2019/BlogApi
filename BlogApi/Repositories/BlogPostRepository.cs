using BlogApi.Infra;
using BlogApi.Interfaces;
using BlogApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BlogApi.Repositories
{
    public class BlogPostRepository : Repository<BlogPost>, IBlogPostRepository
    {
        public BlogPostRepository(ApplicationDbContext context) : base(context)
        { }

        public async Task<BlogPost> Adicionar(BlogPost blogPost)
        {
            return await AddAsync(blogPost);
        }

        public async Task<IEnumerable<BlogPost?>> BuscarTodos()
        {
            return await _dbSet
                .Include(b => b.Comentarios) 
                .ToListAsync();
        }

        public async Task<BlogPost?> BuscarPorId(long id)
        {
            return await _dbSet
                .Include(b => b.Comentarios) 
                .FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task<BlogPost> Atualizar(BlogPost blogPost)
        {
            return await UpdateAsync(blogPost);
        }
    }
}
