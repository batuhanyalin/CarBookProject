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
    public class GetTagBlogQueryHandler : IRequestHandler<GetTagBlogQuery, List<GetTagBlogQueryResult>>
    {
        private readonly IRepository<TagBlog> _repository;

        public GetTagBlogQueryHandler(IRepository<TagBlog> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetTagBlogQueryResult>> Handle(GetTagBlogQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetTagBlogQueryResult()
            {
                TagBlogId = x.TagBlogId,
               TagId = x.TagId,
               BlogId = x.BlogId,              
            }).ToList();
        }
    }
}