using AutoMapper;
using BlogApi.Dto;
using BlogApi.Interfaces;
using BlogApi.Models;
using BlogApi.Repositories;

namespace BlogApi.Services
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository commentRepository;
        private readonly IMapper mapper;
        private readonly IBlogPostRepository blogPostRepository;
        public CommentService(ICommentRepository commentRepository, IMapper mapper, IBlogPostRepository blogPostRepository)
        {
            this.commentRepository = commentRepository;
            this.mapper = mapper;
            this.blogPostRepository = blogPostRepository;

        }

        public async Task<CommentDto?> AdicionarComentario(long postId, CommentCreateDto dto)
        {
            var post = await blogPostRepository.BuscarPorId(postId);
            if (post == null)
                return null;

            var comment = mapper.Map<Comment>(dto);
            post.Comentarios.Add(comment);
            await blogPostRepository.Atualizar(post);

            return mapper.Map<CommentDto>(comment);
        }
    }
}
