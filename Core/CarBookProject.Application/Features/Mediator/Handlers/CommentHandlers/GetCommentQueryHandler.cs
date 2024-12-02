using CarBookProject.Application.Features.Mediator.Queries.CommentQueries;
using CarBookProject.Application.Features.Mediator.Results.CommentResults;
using CarBookProject.Application.Interfaces;
using CarBookProject.Application.Interfaces.CommentInterfaces;
using CarBookProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Handlers.CommentHandlers
{
    public class GetCommentQueryHandler : IRequestHandler<GetCommentQuery, List<GetCommentQueryResult>>
    {
        private readonly ICommentRepository _repository;

        public GetCommentQueryHandler(ICommentRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCommentQueryResult>> Handle(GetCommentQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetCommentListWithAllInfo();
            return values.Select(x=>new GetCommentQueryResult
            {
                BlogId = x.BlogId,
                CommentId = x.CommentId,
                CreatedDate=x.CreatedDate,
                Name = x.Name,
                Surname = x.Surname,
                Text=x.Text,
                BlogTitle=x.Blog.Title,
            }).ToList();
        }
    }
}
