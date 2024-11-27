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
    public class GetTagByIdQueryHandler : IRequestHandler<GetTagByIdQuery, GetTagByIdQueryResult>
    {
        private readonly IRepository<Tag> _repository;

        public GetTagByIdQueryHandler(IRepository<Tag> repository)
        {
            _repository = repository;
        }

        public async Task<GetTagByIdQueryResult> Handle(GetTagByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetTagByIdQueryResult
            {
                TagId = value.TagId,
               TagName= value.TagName,
            };
        }
    }
}