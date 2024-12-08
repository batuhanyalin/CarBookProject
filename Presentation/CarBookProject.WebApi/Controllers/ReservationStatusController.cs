using CarBookProject.Application.Features.Mediator.Commands.ReservationStatusCommands;
using CarBookProject.Application.Features.Mediator.Queries.ReservationStatusQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBookProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationStatusController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ReservationStatusController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> ListReservationStatus()
        {
            var values = await _mediator.Send(new GetReservationStatusQuery()); //Send Metodu handlerlara istekte bulunmayı sağlıyor.
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetReservationStatus(int id)
        {
            var value = await _mediator.Send(new GetReservationStatusByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateReservationStatus(CreateReservationStatusCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateReservationStatus(UpdateReservationStatusCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReservationStatus(int id)
        {
            await _mediator.Send(new DeleteReservationStatusCommand(id));
            return Ok();
        }
    }
}
    