using CarBookProject.Application.Features.Mediator.Results.AuthorResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Queries.AuthorQueries
{
    public class GetBlogListByAuthorIdQuery:IRequest<List<GetBlogListByAuthorIdQueryResult>>
    {
        public int Id { get; set; }
        public GetBlogListByAuthorIdQuery(int id)
        {
            Id = id;
        }
    }
}
