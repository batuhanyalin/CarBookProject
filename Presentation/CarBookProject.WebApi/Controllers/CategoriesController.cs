using CarBookProject.Application.Features.CQRS.Commands.CategoryCommands;
using CarBookProject.Application.Features.CQRS.Handlers.CategoryHandlers;
using CarBookProject.Application.Features.CQRS.Queries.CategoryQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBookProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly CreateCategoryCommandHandler _createCommandHandler;
        private readonly UpdateCategoryCommandHandler _updateCommandHandler;
        private readonly DeleteCategoryCommandHandler _deleteCommandHandler;
        private readonly GetCategoryByIdQueryHandler _getCategoryByIdQueryHandler;
        private readonly GetCategoryQueryHandler _getCategoryQueryHandler;

        public CategoriesController(CreateCategoryCommandHandler createCommandHandler, UpdateCategoryCommandHandler updateCommandHandler, DeleteCategoryCommandHandler deleteCommandHandler, GetCategoryByIdQueryHandler getCategoryByIdQueryHandler, GetCategoryQueryHandler getCategoryQueryHandler)
        {
            _createCommandHandler = createCommandHandler;
            _updateCommandHandler = updateCommandHandler;
            _deleteCommandHandler = deleteCommandHandler;
            _getCategoryByIdQueryHandler = getCategoryByIdQueryHandler;
            _getCategoryQueryHandler = getCategoryQueryHandler;
        }
        [HttpGet]
        public async Task<IActionResult> ListCategory()
        {
            var values = await _getCategoryQueryHandler.Handle();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategory(int id)
        {
            var value = await _getCategoryByIdQueryHandler.Handle(new GetCategoryByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryCommand command)
        {
            await _createCommandHandler.Handle(command);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCategory(UpdateCategoryCommand command)
        {
            await _updateCommandHandler.Handle(command);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteCategory(int id)
        {
            await _deleteCommandHandler.Handle(new DeleteCategoryCommand(id));
            return Ok();
        }
    }
}
