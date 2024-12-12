using CarBookProject.Application.Features.Mediator.Commands.ReviewCommands;
using CarBookProject.Application.Features.Mediator.Queries.ReviewQueries;
using CarBookProject.Application.Features.Mediator.Queries.TestimonialQueries;
using CarBookProject.Application.Validators.ReviewValidators;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBookProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReviewsController : ControllerBase
    {
        private readonly IMediator _mediator;
            
        public ReviewsController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> ListReview()
        {
            var values = await _mediator.Send(new GetReviewQuery());
            return Ok(values);
        }
        [HttpGet("GetReviewListByCarId/{id:int}")]
        public async Task<IActionResult> GetReviewListByCarId(int id)
        {
            var value = await _mediator.Send(new GetReviewByCarIdQuery(id));
            return Ok(value);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetReview(int id)
        {
            var value = await _mediator.Send(new GetReviewByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateReview(CreateReviewCommand command)
        {
            CreateReviewValidator validator=new CreateReviewValidator();
            var validationResult=validator.Validate(command);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }
            await _mediator.Send(command);
            return Ok("Ekleme işlemi gerçekleşti.");
        }
        [HttpPut]
        public async Task<IActionResult> UpdateReview(UpdateReviewCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReview(int id)
        {
            await _mediator.Send(new DeleteReviewCommand(id));
            return Ok();
        }
    }
}
