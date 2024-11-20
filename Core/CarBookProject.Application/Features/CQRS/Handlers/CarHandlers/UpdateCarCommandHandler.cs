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
    public class UpdateCarCommandHandler
    {
        private readonly IRepository<Car> _repository;

        public UpdateCarCommandHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCarCommand command)
        {
            var value = await _repository.GetByIdAsync(command.CarId);

            value.Fuel = command.Fuel;
            value.Transmission = command.Transmission;
            value.BigImageUrl = command.BigImageUrl;
            value.CoverImageUrl = command.CoverImageUrl;
            value.Km = command.Km;
            value.Seat = command.Seat;
            value.Luggage = command.Luggage;
            value.Model = command.Model;
            value.BrandId = command.BrandId;
            await _repository.UpdateAsync(value);
        }
    }
}
