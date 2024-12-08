using CarBookProject.Application.Features.Mediator.Commands.ReservationStatusCommands;
using CarBookProject.Application.Interfaces;
using CarBookProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Handlers.ReservationStatusHandlers
{
    public class UpdateReservationStatusCommandHandler : IRequestHandler<UpdateReservationStatusCommand>
    {
        private readonly IRepository<ReservationStatus> _repository;

        public UpdateReservationStatusCommandHandler(IRepository<ReservationStatus> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateReservationStatusCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.ReservationStatusId);
            value.Name = request.Name;
            value.Icon = request.Icon;
            await _repository.UpdateAsync(value);
        }
    }
}
