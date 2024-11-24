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
    public class DeleteContactCategoryCommandHandler : IRequestHandler<DeleteContactCategoryCommand>
    {
        private readonly IRepository<ContactCategory> _repository;

        public DeleteContactCategoryCommandHandler(IRepository<ContactCategory> repository)
        {
            _repository = repository;
        }
        public async Task Handle(DeleteContactCategoryCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(value);
        }
    }
}
