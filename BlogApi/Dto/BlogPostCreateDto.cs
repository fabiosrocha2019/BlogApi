using BlogApi.Models;

namespace BlogApi.Dto
{
    public class BlogPostCreateDto
    {
        public string Titulo { get; set; } = string.Empty;
        public string Conteudo { get; set; } = string.Empty;
    }
}
