using CarBookProject.Application.Features.Mediator.Commands.ReservationCommands;
using CarBookProject.Application.Interfaces;
using CarBookProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Handlers.ReservationHandlers
{
    public class UpdateReservationCommandHandler : IRequestHandler<UpdateReservationCommand>
    {
        private readonly IRepository<Reservation> _repository;

        public UpdateReservationCommandHandler(IRepository<Reservation> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateReservationCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.ReservationId);
            value.Name = request.Name;
            value.Surname = request.Surname;
            value.Description = request.Description;
            value.ReservationStatusId = request.ReservationStatusId;
            value.Age = request.Age;
            value.Email = request.Email;
            value.PickUpLocationId = request.PickUpLocationId;
            value.DropOffLocationId = request.DropOffLocationId;
            value.Phone = request.Phone;
            value.CarId = request.CarId;
            await _repository.UpdateAsync(value);
        }
    }
}
