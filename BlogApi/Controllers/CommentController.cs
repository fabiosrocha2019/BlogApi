using BlogApi.Dto;
using BlogApi.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BlogApi.Controllers
{
    [Route("api/posts/{postId}/comments")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly ICommentService commentService;

        public CommentsController(ICommentService commentService)
        {
            this.commentService = commentService;
        }

        /// <summary>
        /// Adiciona um novo comentário a um post.
        /// </summary>
        [HttpPost]
        [ProducesResponseType(typeof(CommentDto), (int)HttpStatusCode.Created)]
        [ProducesResponseType((int)HttpStatusCode.NotFound)]
        public async Task<IActionResult> AddComment(int postId, [FromBody] CommentCreateDto commentDto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var comment = await commentService.AdicionarComentario(postId, commentDto);
            if (comment == null)
                return NotFound($"Post com ID {postId} não encontrado.");

            return CreatedAtAction(nameof(AddComment), new { postId = postId }, comment);
        }
    }
}
