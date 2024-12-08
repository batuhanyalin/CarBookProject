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
    public class CreateReservationStatusCommandHandler : IRequestHandler<CreateReservationStatusCommand>
    {
        private readonly IRepository<ReservationStatus> _repository;

        public CreateReservationStatusCommandHandler(IRepository<ReservationStatus> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateReservationStatusCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new ReservationStatus
            {
                Name = request.Name,
                Icon = request.Icon,

            });
        }
    }
}
