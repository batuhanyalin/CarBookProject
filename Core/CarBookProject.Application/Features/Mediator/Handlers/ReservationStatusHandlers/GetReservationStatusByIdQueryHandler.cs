using CarBookProject.Application.Features.Mediator.Queries.ReservationStatusQueries;
using CarBookProject.Application.Features.Mediator.Results.ReservationStatusResults;
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
    public class GetReservationStatusByIdQueryHandler : IRequestHandler<GetReservationStatusByIdQuery, GetReservationStatusByIdQueryResult>
    {
        private readonly IRepository<ReservationStatus> _repository;

        public GetReservationStatusByIdQueryHandler(IRepository<ReservationStatus> repository)
        {
            _repository = repository;
        }

        public async Task<GetReservationStatusByIdQueryResult> Handle(GetReservationStatusByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetReservationStatusByIdQueryResult
            {
                ReservationStatusId = value.ReservationStatusId,
                Name = value.Name,
                Icon= value.Icon,
            };
        }
    }
}
