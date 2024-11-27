
using CarBookProject.Application.Features.Mediator.Queries.CommentQueries;
using CarBookProject.Application.Features.Mediator.Results.CommentResults;
using CarBookProject.Application.Interfaces.CommentInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Handlers.CommentHandlers
{
    public class GetCommentByBlogIdQueryHandler : IRequestHandler<GetCommentByBlogIdQuery, List<GetCommentByBlogIdQueryResult>>
    {
        private readonly ICommentRepository _repository;

        public GetCommentByBlogIdQueryHandler(ICommentRepository repository)
        {
            _repository = repository;
        }

        public Task<List<GetCommentByBlogIdQueryResult>> Handle(GetCommentByBlogIdQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetCommentListByBlogId(request.Id);
            var result = value.Select(x => new GetCommentByBlogIdQueryResult
            {
                BlogId = x.BlogId,
                CommentId = x.CommentId,
                CreatedDate = x.CreatedDate,
                Name = x.Name,
                Surname = x.Surname,
                Text = x.Text
            }).ToList();
            return Task.FromResult(result); // #NOT: Task sarmalama 
        }
    }
}
