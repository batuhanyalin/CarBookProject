using CarBookProject.Application.Features.Mediator.Results.ReservationResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Queries.ReservationQueries
{
    public class GetReservationByIdQuery:IRequest<GetReservationQueryResult>
    {
        public int Id { get; set; }

        public GetReservationByIdQuery(int id)
        {
            Id = id;
        }
    }
}
