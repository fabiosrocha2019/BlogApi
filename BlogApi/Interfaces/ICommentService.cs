using BlogApi.Dto;
using BlogApi.Models;

namespace BlogApi.Interfaces
{
    public interface ICommentService : IRepository<Comment>
    {
        Task<CommentDto?> AdicionarComentario(long postId, CommentCreateDto dto);
    }
}
