using CarBookProject.Application.Features.Mediator.Commands.CommentCommands;
using CarBookProject.Application.Features.Mediator.Queries.CommentQueries;
using CarBookProject.Application.Features.Mediator.Queries.TestimonialQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBookProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CommentsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> ListComment()
        {
            var values = await _mediator.Send(new GetCommentQuery());
            return Ok(values);
        }
        [HttpGet("GetCommentByBlogId/{id}")]
        public async Task<IActionResult> GetCommentByBlogId(int id)
        {
            var values = await _mediator.Send(new GetCommentByBlogIdQuery(id));
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetComment(int id)
        {
            var value = await _mediator.Send(new GetCommentByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateComment(CreateCommentCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateComment(UpdateCommentCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteComment(int id)
        {
            await _mediator.Send(new DeleteCommentCommand(id));
            return Ok();
        }
    }
}
