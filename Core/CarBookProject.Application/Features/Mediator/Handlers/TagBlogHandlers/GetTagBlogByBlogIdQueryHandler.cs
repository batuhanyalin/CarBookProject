using CarBookProject.Application.Features.Mediator.Queries.TagBlogQueries;
using CarBookProject.Application.Features.Mediator.Results.TagBlogResults;
using CarBookProject.Application.Interfaces;
using CarBookProject.Application.Interfaces.TagBlogInterfaces;
using CarBookProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Handlers.TagBlogHandlers
{
    public class GetTagBlogByBlogIdQueryHandler : IRequestHandler<GetTagBlogByBlogIdQuery, List<GetTagBlogByBlogIdQueryResult>>
    {
        private readonly ITagBlogRepository _repository;

        public GetTagBlogByBlogIdQueryHandler(ITagBlogRepository repository)
        {
            _repository = repository;
        }

        public Task<List<GetTagBlogByBlogIdQueryResult>> Handle(GetTagBlogByBlogIdQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetTagBlogByBlogId(request.Id);
            var task = values.Select(x => new GetTagBlogByBlogIdQueryResult
            {
                BlogId = x.BlogId,
                TagId = x.TagId,
                TagName = x.Tag.TagName,
                TagBlogId=x.TagBlogId,
            }).ToList();
            return Task.FromResult(task);
        }
    }
}