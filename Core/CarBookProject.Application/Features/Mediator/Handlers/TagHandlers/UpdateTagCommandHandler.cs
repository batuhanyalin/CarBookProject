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
    public class UpdateTagCommandHandler:IRequestHandler<UpdateTagCommand>
    {
        private readonly IRepository<Tag> _repository;

        public UpdateTagCommandHandler(IRepository<Tag> repository)
        {
            _repository = repository;
        }

        public Task Handle(UpdateTagCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}