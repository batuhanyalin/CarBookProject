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
    public class UpdateContactCommandHandler
    {
        private readonly IRepository<Contact> _repository;

        public UpdateContactCommandHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateContactCommand command)
        {
            var value= await _repository.GetByIdAsync(command.ContactId);
            value.Surname = command.Surname;
            value.Text = command.Text;
            value.Email = command.Email;
            value.Phone = command.Phone;
            value.Subject = command.Subject;
            value.ContactCategoryId = command.ContactCategoryId;
            value.Name = command.Name;
            value.IsApproved = command.IsApproved;
        }

    }
}
