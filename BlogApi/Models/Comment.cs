namespace BlogApi.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Autor { get; set; } = string.Empty;
        public string Conteudo { get; set; } = string.Empty;

        public long BlogPostId { get; set; }
        public BlogPost BlogPost { get; set; } = null!;
    }
}
