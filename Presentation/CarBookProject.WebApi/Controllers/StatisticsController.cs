using CarBookProject.Application.Features.Mediator.Handlers.StatisticHandlers;
using CarBookProject.Application.Features.Mediator.Queries.StatisticQueries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace CarBookProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatisticsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StatisticsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetCarCount()
        {
            var values = await _mediator.Send(new GetAllStatisticQuery()); //Send Metodu handlerlara istekte bulunmayı sağlıyor.
            return Ok(values);
        }
       
    }

}
