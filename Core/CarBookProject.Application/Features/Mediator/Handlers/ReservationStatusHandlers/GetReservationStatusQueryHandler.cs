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
    public class GetReservationStatusQueryHandler : IRequestHandler<GetReservationStatusQuery, List<GetReservationStatusQueryResult>>
    {
        private readonly IRepository<ReservationStatus> _repository;

        public GetReservationStatusQueryHandler(IRepository<ReservationStatus> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetReservationStatusQueryResult>> Handle(GetReservationStatusQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetReservationStatusQueryResult()
            {
                ReservationStatusId = x.ReservationStatusId,
                Name = x.Name,
                Icon=x.Icon,
            }).ToList();
        }
    }
}
