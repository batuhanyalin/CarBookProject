using CarBookProject.Application.Features.CQRS.Commands.CarCommands;
using CarBookProject.Application.Features.CQRS.Commands.CarCommands;
using CarBookProject.Application.Features.CQRS.Handlers.CarHandlers;
using CarBookProject.Application.Features.CQRS.Queries.CarQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBookProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly GetCarByIdQueryHandler _getCarByIdQueryHandler;
        private readonly CreateCarCommandHandler _createCarCommandHandler;
        private readonly UpdateCarCommandHandler _updateCarCommandHandler;
        private readonly DeleteCarCommandHandler _deleteCarCommandHandler;
        private readonly GetCarQueryHandler _getCarQueryHandler;
        private readonly GetCarWithBrandQueryHandler _getCarWithBrandQueryHandler;

        public CarsController(GetCarByIdQueryHandler getCarByIdQueryHandler, CreateCarCommandHandler createCarCommandHandler, UpdateCarCommandHandler updateCarCommandHandler, DeleteCarCommandHandler deleteCarCommandHandler, GetCarQueryHandler getCarQueryHandler, GetCarWithBrandQueryHandler getCarWithBrandQueryHandler)
        {
            _getCarByIdQueryHandler = getCarByIdQueryHandler;
            _createCarCommandHandler = createCarCommandHandler;
            _updateCarCommandHandler = updateCarCommandHandler;
            _deleteCarCommandHandler = deleteCarCommandHandler;
            _getCarQueryHandler = getCarQueryHandler;
            _getCarWithBrandQueryHandler = getCarWithBrandQueryHandler;
        }
        [HttpGet]
        public async Task<IActionResult> ListCar()
        {
            var values = await _getCarQueryHandler.Handle();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCar(int id)
        {
            var value = await _getCarByIdQueryHandler.Handle(new GetCarByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateCar(CreateCarCommand command)
        {
            await _createCarCommandHandler.Handle(command);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCar(UpdateCarCommand command)
        {
            await _updateCarCommandHandler.Handle(command);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteCar(int id)
        {
            await _deleteCarCommandHandler.Handle(new DeleteCarCommand(id));
            return Ok();
        }
        [HttpGet("GetCarWithBrand")]
        public IActionResult GetCarWithBrand()
        {
            var values = _getCarWithBrandQueryHandler.Handle();
            return Ok(values);
        }
    }
}
