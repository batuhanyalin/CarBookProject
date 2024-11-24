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
    public class UpdateContactCategoryCommandHandler : IRequestHandler<UpdateContactCategoryCommand>
    {
        private readonly IRepository<ContactCategory> _repository;

        public UpdateContactCategoryCommandHandler(IRepository<ContactCategory> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateContactCategoryCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.ContactCategoryId);
            value.Name = request.Name;
            await _repository.UpdateAsync(value);
        }
    }
}
