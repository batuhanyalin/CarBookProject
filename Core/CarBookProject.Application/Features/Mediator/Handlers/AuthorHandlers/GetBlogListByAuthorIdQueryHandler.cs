using CarBookProject.Application.Features.Mediator.Queries.AuthorQueries;
using CarBookProject.Application.Features.Mediator.Results.AuthorResults;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Handlers.AuthorHandlers
{
    public class GetBlogListByAuthorIdQueryHandler : IRequestHandler<GetBlogListByAuthorIdQuery, List<GetBlogListByAuthorIdQueryResult>>
    {

        public Task<List<GetBlogListByAuthorIdQueryResult>> Handle(GetBlogListByAuthorIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }


    }
}
