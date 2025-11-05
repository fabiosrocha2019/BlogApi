using BlogApi.Infra;
using BlogApi.Interfaces;
using BlogApi.Models;

namespace BlogApi.Repositories
{
    public class CommentRepository : Repository<Comment>, ICommentRepository
    {
        public CommentRepository(ApplicationDbContext context) : base(context)
        {
        }

        public async Task<Comment> Adicionar(Comment comment)
        {
            return await AddAsync(comment);
        }

        public async Task<Comment?> BuscarPorId(long id)
        {
            return await GetByIdAsync(id);
        }
    }
}
