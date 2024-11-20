using CarBookProject.Application.Features.CQRS.Commands.BrandCommands;
using CarBookProject.Application.Features.CQRS.Handlers.BrandHandlers;
using CarBookProject.Application.Features.CQRS.Queries.BrandQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BrandBookProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly GetBrandByIdQueryHandler _getBrandByIdQueryHandler;
        private readonly CreateBrandCommandHandler _createBrandCommandHandler;
        private readonly UpdateBrandCommandHandler _updateBrandCommandHandler;
        private readonly DeleteBrandCommandHandler _deleteBrandCommandHandler;
        private readonly GetBrandQueryHandler _getBrandQueryHandler;

        public BrandsController(GetBrandByIdQueryHandler getBrandByIdQueryHandler, CreateBrandCommandHandler createBrandCommandHandler, UpdateBrandCommandHandler updateBrandCommandHandler, DeleteBrandCommandHandler deleteBrandCommandHandler, GetBrandQueryHandler getBrandQueryHandler)
        {
            _getBrandByIdQueryHandler = getBrandByIdQueryHandler;
            _createBrandCommandHandler = createBrandCommandHandler;
            _updateBrandCommandHandler = updateBrandCommandHandler;
            _deleteBrandCommandHandler = deleteBrandCommandHandler;
            _getBrandQueryHandler = getBrandQueryHandler;
        }
        [HttpGet]
        public async Task<IActionResult> ListBrand()
        {
            var values = await _getBrandQueryHandler.Handle();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetBrand(int id)
        {
            var value = _getBrandByIdQueryHandler.Handle(new GetBrandByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateBrand(CreateBrandCommand command)
        {
            await _createBrandCommandHandler.Handle(command);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateBrand(UpdateBrandCommand command)
        {
            await _updateBrandCommandHandler.Handle(command);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteBrand(int id)
        {
            await _deleteBrandCommandHandler.Handle(new DeleteBrandCommand(id));
            return Ok();
        }

    }
}
