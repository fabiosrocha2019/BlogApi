using BlogApi.Models;

namespace BlogApi.Interfaces
{
    public interface IBlogPostRepository : IRepository<BlogPost>
    {
        Task<BlogPost> Adicionar(BlogPost blogPost);
        Task<IEnumerable<BlogPost?>> BuscarTodos();
        Task<BlogPost> BuscarPorId(long id);

        Task<BlogPost> Atualizar(BlogPost blogPost);

    }
}
