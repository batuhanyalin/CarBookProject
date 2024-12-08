using CarBookProject.Application.Features.Mediator.Results.ReservationStatusResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Queries.ReservationStatusQueries
{
    public class GetReservationStatusQuery : IRequest<List<GetReservationStatusQueryResult>>
    {
    }
}
