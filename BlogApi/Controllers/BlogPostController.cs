using BlogApi.Dto;
using BlogApi.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BlogApi.Controllers
{
    [Route("api/BlogPost")]
    [ApiController]
    public class BlogPostController : ControllerBase
    {
        private readonly IBlogPostService blogPostService;

        public BlogPostController(IBlogPostService blogPostService)
        {
            this.blogPostService = blogPostService;
        }

        /// <summary>
        /// Retorna todos os posts do blog, com número de coment´arios.
        /// </summary>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<BlogPostPartialDto>), (int)HttpStatusCode.OK)]
        public async Task<IActionResult> GetAll()
        {
            var posts = await blogPostService.BuscarTodos();
            return Ok(posts);
        }

        /// <summary>
        /// Cria um novo post.
        /// </summary>
        [HttpPost]
        [ProducesResponseType(typeof(BlogPostDto), (int)HttpStatusCode.Created)]
        public async Task<IActionResult> Create([FromBody] BlogPostCreateDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var post = await blogPostService.Adicionar(dto);
            return CreatedAtAction(nameof(GetById), new { id = post.Id }, post);
        }

        /// <summary>
        /// Retorna um post do Blog com todos os comentários.
        /// </summary>
        [HttpGet("id")]
        [ProducesResponseType(typeof(BlogPostDto), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> GetById(long id)
        {
            var post = await blogPostService.BuscarPorId(id);
            if (post == null)
                return NotFound($"Post com ID {id} não encontrado.");


            return Ok(post);
        }
    }
}
