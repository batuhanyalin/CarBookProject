using CarBookProject.Application.Features.Mediator.Commands.ContactCategoryCommands;
using CarBookProject.Application.Features.Mediator.Queries.ContactCategoryQuieries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarBookProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactCategoriesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ContactCategoriesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> ListContactCategory()
        {
            var values = await _mediator.Send(new GetContactCategoryQuery());
            return Ok(values);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetContactCategory(int id)
        {
            var value = await _mediator.Send(new GetContactCategoryByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateContactCategory(CreateContactCategoryCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateContactCategory(UpdateContactCategoryCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteContactCategory(DeleteContactCategoryCommand command)
        {
            await _mediator.Send(command);
            return Ok();
        }
    }
}
