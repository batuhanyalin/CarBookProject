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
    public class DeleteReservationStatusCommandHandler : IRequestHandler<DeleteReservationStatusCommand>
    {
        private readonly IRepository<ReservationStatus> _repository;

        public DeleteReservationStatusCommandHandler(IRepository<ReservationStatus> repository)
        {
            _repository = repository;
        }

        public async Task Handle(DeleteReservationStatusCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(value);
        }
    }
}
