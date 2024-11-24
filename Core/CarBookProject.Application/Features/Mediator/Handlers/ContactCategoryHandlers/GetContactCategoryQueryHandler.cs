using CarBookProject.Application.Features.Mediator.Queries.ContactCategoryQuieries;
using CarBookProject.Application.Features.Mediator.Results.ContactCategoryResults;
using CarBookProject.Application.Interfaces;
using CarBookProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Handlers.ContactCategoryHandlers
{
    public class GetContactCategoryQueryHandler : IRequestHandler<GetContactCategoryQuery, List<GetContactCategoryQueryResult>>
    {
        private readonly IRepository<ContactCategory> _repository;

        public GetContactCategoryQueryHandler(IRepository<ContactCategory> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetContactCategoryQueryResult>> Handle(GetContactCategoryQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetContactCategoryQueryResult
            {
                ContactCategoryId = x.ContactCategoryId,
                Name = x.Name

            }).ToList();
        }
    }
}
