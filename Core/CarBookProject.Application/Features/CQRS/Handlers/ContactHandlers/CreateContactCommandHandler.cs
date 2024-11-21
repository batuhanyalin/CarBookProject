using CarBookProject.Application.Features.CQRS.Commands.ContactCommands;
using CarBookProject.Application.Interfaces;
using CarBookProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.CQRS.Handlers.ContactHandlers
{
    public class CreateContactCommandHandler
    {
        private readonly IRepository<Contact> _repository;

        public CreateContactCommandHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateContactCommand command)
        {
            await _repository.CreateAsync(new Contact
            {
                ContactCategoryId = command.ContactCategoryId,
                Email = command.Email,
                IsApproved = command.IsApproved,
                Name = command.Name,
                Phone = command.Phone,
                SendingDate = command.SendingDate,
                Subject = command.Subject,
                Surname = command.Surname,
                Text = command.Text,
            });
        }
    }
}
