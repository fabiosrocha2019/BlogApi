using BlogApi.Models;

namespace BlogApi.Dto
{
    public class BlogPostPartialDto
    {
        public long Id { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public int QtdComentarios { get; set; }
    }
}
