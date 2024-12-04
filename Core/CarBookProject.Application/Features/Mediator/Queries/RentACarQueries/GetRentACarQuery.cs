using CarBookProject.Application.Features.Mediator.Results.RentACarResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Queries.RentACarQueries
{
    public class GetRentACarQuery:IRequest<List<GetRentACarQueryResult>>
    {
        public int LocationId { get; set; }
        public bool Available { get; set; }
    }
}
