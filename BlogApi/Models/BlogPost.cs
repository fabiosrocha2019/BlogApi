using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogApi.Models
{
    public class BlogPost
    {
        public long Id { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public virtual ICollection<Comment> Comentarios { get; set; } = new Collection<Comment>();

        [NotMapped]
        public int QtdComentarios => Comentarios?.Count ?? 0;
    }
}
