using CarBookProject.Application.Features.Mediator.Commands.AuthorCommands;
using CarBookProject.Application.Interfaces;
using CarBookProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Handlers.AuthorHandlers
{
    public class UpdateAuthorCommandHandler : IRequestHandler<UpdateAuthorCommand>
    {
        private readonly IRepository<Author> _repository;

        public UpdateAuthorCommandHandler(IRepository<Author> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateAuthorCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.AuthorId);
            value.Surname = request.Surname;
            value.Name = request.Name;
            value.Description = request.Description;
            value.ImageUrl = request.ImageUrl;
            await _repository.UpdateAsync(value);
        }
    }
}
