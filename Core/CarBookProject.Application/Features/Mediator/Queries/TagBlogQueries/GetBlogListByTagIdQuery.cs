using CarBookProject.Application.Features.Mediator.Results.TagBlogResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Queries.TagBlogQueries
{
    public class GetBlogListByTagIdQuery : IRequest<List<GetBlogListByTagIdQueryResult>>
    {
        public int Id { get; set; }

        public GetBlogListByTagIdQuery(int id)
        {
            Id = id;
        }
    }
}