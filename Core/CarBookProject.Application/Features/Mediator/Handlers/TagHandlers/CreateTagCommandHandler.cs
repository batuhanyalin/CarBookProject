using CarBookProject.Application.Features.Mediator.Commands.TagCommands;
using CarBookProject.Application.Interfaces;
using CarBookProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Handlers.TagHandlers
{
    public class CreateTagCommandHandler : IRequestHandler<CreateTagCommand>
    {
        private readonly IRepository<Tag> _repository;

        public CreateTagCommandHandler(IRepository<Tag> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateTagCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Tag
            {
               TagName = request.TagName,
            });
        }
    }
}