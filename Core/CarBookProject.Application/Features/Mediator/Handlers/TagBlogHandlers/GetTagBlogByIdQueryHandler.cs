using CarBookProject.Application.Features.Mediator.Queries.TagBlogQueries;
using CarBookProject.Application.Features.Mediator.Results.TagBlogResults;
using CarBookProject.Application.Interfaces;
using CarBookProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Handlers.TagBlogHandlers
{
    public class GetTagBlogByIdQueryHandler : IRequestHandler<GetTagBlogByIdQuery, GetTagBlogByIdQueryResult>
    {
        private readonly IRepository<TagBlog> _repository;

        public GetTagBlogByIdQueryHandler(IRepository<TagBlog> repository)
        {
            _repository = repository;
        }

        public async Task<GetTagBlogByIdQueryResult> Handle(GetTagBlogByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetTagBlogByIdQueryResult
            {
                TagBlogId = value.TagBlogId,
                BlogId = value.BlogId,
                TagId = value.TagId,
            };
        }
    }
}