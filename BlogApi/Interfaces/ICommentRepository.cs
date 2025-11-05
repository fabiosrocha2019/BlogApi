using BlogApi.Models;

namespace BlogApi.Interfaces
{
    public interface ICommentRepository : IRepository<Comment>
    {
        Task<Comment> Adicionar(Comment comment);
        Task<Comment> BuscarPorId(long id);
    }
}
