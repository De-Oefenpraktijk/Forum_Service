using Forum.Application.Contracts.Services;
using Forum.Application.Dto.Comment;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Forum_Service.Controller
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class CommentController : ControllerBase
    {
        private readonly ICommentLogic _commentLogic;
        public CommentController(ICommentLogic commentLogic)
        {
            _commentLogic = commentLogic;
        }

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<Guid>> PostComment([FromBody] NewCommentDto commentDto)
        {
            var result = await _commentLogic.addCommentToFormPost(commentDto);

            if (result == null)
            {
                return BadRequest();
            }

            return Ok(result);
        }
    }
}
