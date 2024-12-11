using CarBookProject.Application.Features.Mediator.Results.ReviewResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Queries.ReviewQueries
{
    public class GetReviewByCarIdQuery : IRequest<List<GetReviewByCarIdQueryResult>>
    {
        public int Id { get; set; }

        public GetReviewByCarIdQuery(int ıd)
        {
            Id = ıd;
        }
    }
}