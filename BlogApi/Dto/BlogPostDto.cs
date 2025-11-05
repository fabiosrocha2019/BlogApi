using BlogApi.Models;

namespace BlogApi.Dto
{
    public class BlogPostDto
    {
        public long Id { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public IList<CommentDto> Comentarios { get; set; }
        public int QtdComentarios { get; set; }
    }
}
