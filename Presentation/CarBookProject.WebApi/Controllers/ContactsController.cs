using CarBookProject.Application.Features.CQRS.Commands.ContactCommands;
using CarBookProject.Application.Features.CQRS.Handlers.ContactHandlers;
using CarBookProject.Application.Features.CQRS.Queries.ContactQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContactBookProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly GetContactByIdQueryHandler _getContactByIdQueryHandler;
        private readonly CreateContactCommandHandler _createContactCommandHandler;
        private readonly UpdateContactCommandHandler _updateContactCommandHandler;
        private readonly DeleteContactCommandHandler _deleteContactCommandHandler;
        private readonly GetContactQueryHandler _getContactQueryHandler;

        public ContactsController(GetContactByIdQueryHandler getContactByIdQueryHandler, CreateContactCommandHandler createContactCommandHandler, UpdateContactCommandHandler updateContactCommandHandler, DeleteContactCommandHandler deleteContactCommandHandler, GetContactQueryHandler getContactQueryHandler)
        {
            _getContactByIdQueryHandler = getContactByIdQueryHandler;
            _createContactCommandHandler = createContactCommandHandler;
            _updateContactCommandHandler = updateContactCommandHandler;
            _deleteContactCommandHandler = deleteContactCommandHandler;
            _getContactQueryHandler = getContactQueryHandler;
        }
        [HttpGet]
        public async Task<IActionResult> ListContact()
        {
            var values = await _getContactQueryHandler.Handle();
            return Ok(values);
        }
        [HttpGet("{id}")]
        public IActionResult GetContact(int id)
        {
            var value = _getContactByIdQueryHandler.Handle(new GetContactByIdQuery(id));
            return Ok(value);
        }
        [HttpPost]
        public async Task<IActionResult> CreateContact(CreateContactCommand command)
        {
            await _createContactCommandHandler.Handle(command);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateContact(UpdateContactCommand command)
        {
            await _updateContactCommandHandler.Handle(command);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> DeleteContact(int id)
        {
            await _deleteContactCommandHandler.Handle(new DeleteContactCommand(id));
            return Ok();
        }

    }
}
