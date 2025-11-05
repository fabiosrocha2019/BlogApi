using BlogApi.Dto;
using BlogApi.Models;

namespace BlogApi.Interfaces
{
    public interface IBlogPostService : IRepository<BlogPost>
    {
        Task<BlogPostDto?> Adicionar(BlogPostCreateDto dto);
        Task<IEnumerable<BlogPostPartialDto?>> BuscarTodos();
        Task<BlogPostDto?> BuscarPorId(long id);
    }
}
