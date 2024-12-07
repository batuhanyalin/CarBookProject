using CarBookProject.Application.Features.Mediator.Commands.ReservationCommands;
using CarBookProject.Application.Features.Mediator.Queries.ReservationQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBookProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ReservationsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> ListReservation()
        {
            var values = await _mediator.Send(new GetReservationQuery()); //Send Metodu handlerlara istekte bulunmayı sağlıyor.
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetReservation(int id)
        {
            var value = await _mediator.Send(new GetReservationByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateReservation(CreateReservationCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateReservation(UpdateReservationCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReservation(int id)
        {
            await _mediator.Send(new DeleteReservationCommand(id));
            return Ok();
        }
    }
}
