using CarBookProject.Application.Features.Mediator.Results.TagBlogResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Queries.TagBlogQueries
{
    public class GetTagBlogByIdQuery : IRequest<GetTagBlogByIdQueryResult>
    {
        public int Id { get; set; }

        public GetTagBlogByIdQuery(int id)
        {
            Id = id;
        }
    }
}