
using AutoMapper;
using BlogApi.Dto;
using BlogApi.Interfaces;
using BlogApi.Models;
using BlogApi.Repositories;

namespace BlogApi.Services
{
    public class BlogPostService : IBlogPostService
    {
        private readonly IBlogPostRepository blogPostRepository;
        private readonly IMapper mapper;
        public BlogPostService(IBlogPostRepository blogPostRepository, IMapper mapper) 
        {
            this.blogPostRepository = blogPostRepository;
            this.mapper = mapper;
        }

        public async Task<IEnumerable<BlogPostPartialDto>> BuscarTodos()
        {
            var posts = await blogPostRepository.BuscarTodos();
            return mapper.Map<IEnumerable<BlogPostPartialDto>>(posts);
        }

        public async Task<BlogPostDto?> BuscarPorId(long id)
        {
            var post = await blogPostRepository.BuscarPorId(id);
            return mapper.Map<BlogPostDto>(post);
        }

        public async Task<BlogPostDto?> Adicionar(BlogPostCreateDto dto)
        {
            var entity = mapper.Map<BlogPost>(dto);
            await blogPostRepository.Adicionar(entity);
            return mapper.Map<BlogPostDto>(entity);
        }
    }
}
