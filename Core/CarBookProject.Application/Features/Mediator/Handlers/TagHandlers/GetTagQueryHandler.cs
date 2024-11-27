using CarBookProject.Application.Features.Mediator.Queries.TagQueries;
using CarBookProject.Application.Features.Mediator.Results.TagResults;
using CarBookProject.Application.Interfaces;
using CarBookProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Handlers.TagHandlers
{
    public class GetTagQueryHandler : IRequestHandler<GetTagQuery, List<GetTagQueryResult>>
    {
        private readonly IRepository<Tag> _repository;

        public GetTagQueryHandler(IRepository<Tag> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetTagQueryResult>> Handle(GetTagQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetTagQueryResult()
            {
                TagId = x.TagId,
               TagName= x.TagName,
            }).ToList();
        }
    }
}