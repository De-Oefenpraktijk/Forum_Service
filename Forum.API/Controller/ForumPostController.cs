using System.Net;
using Forum.Application.Contracts.Services;
using Forum.Application.Dto;
using Microsoft.AspNetCore.Mvc;

namespace Forum.API.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ForumPostController : ControllerBase
    {
        private readonly IForumLogic _forumLogic;
        public ForumPostController(IForumLogic forumLogic)
        {
            _forumLogic = forumLogic;
        }

        [HttpGet("{formPostId}")]
        [ProducesResponseType(typeof(FormPostDto), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<FormPostDto>> GetFormPostById(Guid formPostId)
        {
            var formPost = await _forumLogic.getFormPostById(formPostId);

            if (formPost == null)
            {
                return NotFound();
            }

            return Ok(formPost);
        }

        [HttpGet]
        [ProducesResponseType(typeof(FormPostDto), (int)HttpStatusCode.OK)]
        public async Task<ActionResult<List<FormPostDto>>> GetFormPosts()
        {
            var formPost = await _forumLogic.getAllAsync();

            if (formPost == null)
            {
                return NotFound();
            }

            return Ok(formPost);
        }

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public async Task<ActionResult<Guid>> CreateFormPost([FromBody] NewFormPostDto formPost)
        {
            var result = await _forumLogic.createFormPost(formPost);

            if (result == null)
            {
                return BadRequest();
            }

            return Ok(result);
        }

        [HttpPut]
        public async Task<ActionResult> UpdateForPost([FromBody] FormPostDto formPost)
        {
            var userId = "TODO";
            await _forumLogic.updateFormPost(formPost, userId);
            return Ok();
        }
    }
}