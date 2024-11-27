using CarBookProject.Application.Features.Mediator.Commands.TagBlogCommands;
using CarBookProject.Application.Features.Mediator.Queries.TagBlogQueries;
using CarBookProject.Application.Features.Mediator.Queries.TestimonialQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBookProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagBlogsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public TagBlogsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> ListTagBlog()
        {
            var values = await _mediator.Send(new GetTagBlogQuery());
            return Ok(values);
        }
        [HttpGet("GetBlogListByTagId/{id}")]
        public async Task<IActionResult> GetBlogListByTagId(int id)
        {
            var values = await _mediator.Send(new GetBlogListByTagIdQuery(id));
            return Ok(values);
        }
        [HttpGet("GetTagListByBlogId/{id}")]
        public async Task<IActionResult> GetTagListByBlogId(int id)
        {
            var values = await _mediator.Send(new GetTagBlogByBlogIdQuery(id));
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetTagBlog(int id)
        {
            var value = await _mediator.Send(new GetTagBlogByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateTagBlog(CreateTagBlogCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateTagBlog(UpdateTagBlogCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteTagBlog(DeleteTagBlogCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }
    }
}
