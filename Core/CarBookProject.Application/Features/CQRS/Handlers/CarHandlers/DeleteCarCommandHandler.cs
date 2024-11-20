using CarBookProject.Application.Features.CQRS.Commands.CarCommands;
using CarBookProject.Application.Interfaces;
using CarBookProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.CQRS.Handlers.CarHandlers
{
    public class DeleteCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public DeleteCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task Handle(DeleteCarCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            await _repository.DeleteAsync(value);
        }

    }
}
