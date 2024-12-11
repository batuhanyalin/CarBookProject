using CarBookProject.Application.Features.Mediator.Commands.CarFeatureCommands;
using CarBookProject.Application.Features.Mediator.Queries.CarFeatureQueries;
using CarBookProject.Application.Features.Mediator.Queries.TestimonialQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBookProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarFeaturesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CarFeaturesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet("GetCarFeatureListByCarId/{id:int}")]
        public async Task<IActionResult> GetCarFeatureListByCarId(int id)
        {
            var value = await _mediator.Send(new GetCarFeatureByCarIdQuery(id));
            return Ok(value);
        }
        [HttpPut]
        public async Task<IActionResult> UpdateCarFeature(UpdateCarFeatureAvailableChangeToFalseCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }
        [HttpGet("CarFeatureChangeAvailableToFalse/{id:int}")]
        public async Task<IActionResult> CarFeatureChangeAvailableToFalse(int id)
        {
            await _mediator.Send(new UpdateCarFeatureAvailableChangeToFalseCommand(id));
            return Ok();
        }
        [HttpGet("CarFeatureChangeAvailableToTrue/{id:int}")]
        public async Task<IActionResult> CarFeatureChangeAvailableToTrue(int id)
        {
            await _mediator.Send(new UpdateCarFeatureAvailableChangeToTrueCommand(id));
            return Ok();
        }
        [HttpPost]
        public async Task<IActionResult> CreateCarFeatureByCarId(CreateCarFeatureByCarCommand command)
        {
            _mediator.Send(command);
            return Ok();
        }
    }
}
