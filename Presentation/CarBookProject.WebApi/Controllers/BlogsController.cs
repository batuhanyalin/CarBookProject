using CarBookProject.Application.Features.Mediator.Commands.BlogCommands;
using CarBookProject.Application.Features.Mediator.Handlers.BlogHandlers;
using CarBookProject.Application.Features.Mediator.Queries.BlogQueries;
using CarBookProject.Application.Features.Mediator.Queries.TestimonialQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBookProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsController : ControllerBase
    {

        private readonly GetBlogQueryHandler _getBlogQueryHandler;
        private readonly GetBlogByIdQueryHandler _getBlogByIdQueryHandler;
        private readonly CreateBlogCommandHandler _createBlogCommandHandler;
        private readonly UpdateBlogCommandHandler _updateBlogCommandHandler;
        private readonly DeleteBlogCommandHandler _deleteBlogCommandHandler;
        private readonly GetBlogWithAllInfoByIdQueryHandler _getBlogWithAllInfoByIdQueryHandler;
        private readonly GetBlogLast3WithAllInfoQueryHandler _getBlogLast3WithAllInfoQueryHandler;
        private readonly GetBlogWithAllInfoQueryHandler _getBlogWithAllInfoQueryHandler;

		public BlogsController(GetBlogQueryHandler getBlogQueryHandler, GetBlogByIdQueryHandler getBlogByIdQueryHandler, CreateBlogCommandHandler createBlogCommandHandler, UpdateBlogCommandHandler updateBlogCommandHandler, DeleteBlogCommandHandler deleteBlogCommandHandler, GetBlogWithAllInfoByIdQueryHandler getBlogWithAllInfoByIdQueryHandler, GetBlogLast3WithAllInfoQueryHandler getBlogLast3WithAllInfoQueryHandler, GetBlogWithAllInfoQueryHandler getBlogWithAllInfoQueryHandler)
		{
			_getBlogQueryHandler = getBlogQueryHandler;
			_getBlogByIdQueryHandler = getBlogByIdQueryHandler;
			_createBlogCommandHandler = createBlogCommandHandler;
			_updateBlogCommandHandler = updateBlogCommandHandler;
			_deleteBlogCommandHandler = deleteBlogCommandHandler;
			_getBlogWithAllInfoByIdQueryHandler = getBlogWithAllInfoByIdQueryHandler;
			_getBlogLast3WithAllInfoQueryHandler = getBlogLast3WithAllInfoQueryHandler;
			_getBlogWithAllInfoQueryHandler = getBlogWithAllInfoQueryHandler;
		}

		[HttpGet]
        public IActionResult ListBlog()
        {
            var values = _getBlogQueryHandler.Handle();
            return Ok(values);
        }
		[HttpGet("GetBlogWithAllInfo")]
		public IActionResult GetBlogWithAllInfo()
		{
			var values = _getBlogWithAllInfoQueryHandler.Handle();
			return Ok(values);
		}
		[HttpGet("GetBlogLast3")]
        public IActionResult GetBlogLast3()
        {
            var values = _getBlogLast3WithAllInfoQueryHandler.Handle();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBlog(int id)
        {
            var value = await _getBlogByIdQueryHandler.Handle(new GetBlogByIdQuery(id));
            return Ok(value);
        }
        [HttpGet("GetBlogWithAllInfoById/{id}")]
        public IActionResult GetBlogWithAllInfoById(int id)
        {
            var value = _getBlogWithAllInfoByIdQueryHandler.Handle(id);
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateBlog(CreateBlogCommand command)
        {
            await _createBlogCommandHandler.Handle(command);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBlog(UpdateBlogCommand command)
        {
            await _updateBlogCommandHandler.Handle(command);
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBlog(int id)
        {
            await _deleteBlogCommandHandler.Handle(new DeleteBlogCommand(id));
            return Ok();
        }
    }
}
