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
    public class CreateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public CreateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateCarCommand command)
        {
            await _repository.CreateAsync(new Car
            {
                BigImageUrl = command.BigImageUrl,
                CoverImageUrl=command.CoverImageUrl,
                BrandId=command.BrandId,
                Fuel=command.Fuel,
                Km=command.Km,
                Luggage=command.Luggage,
                Model=command.Model,
                Seat=command.Seat,
                Transmission=command.Transmission,              
                Description=command.Description,              
            });
        }
    }
}
