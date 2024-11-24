using CarBookProject.Application.Features.Mediator.Commands.ContactCategoryCommands;
using CarBookProject.Application.Interfaces;
using CarBookProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Handlers.ContactCategoryHandlers
{
    public class CreateContactCategoryCommandHandler:IRequestHandler<CreateContactCategoryCommand>
    {
        private readonly IRepository<ContactCategory> _repository;

        public CreateContactCategoryCommandHandler(IRepository<ContactCategory> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateContactCategoryCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new ContactCategory
            {
                Name = request.Name,
            });
        }
    }
}
