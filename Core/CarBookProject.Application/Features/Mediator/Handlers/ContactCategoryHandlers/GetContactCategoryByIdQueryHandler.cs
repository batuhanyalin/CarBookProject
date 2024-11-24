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
    public class GetContactCategoryByIdQueryHandler : IRequestHandler<GetContactCategoryByIdQuery, GetContactCategoryByIdQueryResult>
    {
        private readonly IRepository<ContactCategory> _repository;

        public GetContactCategoryByIdQueryHandler(IRepository<ContactCategory> repository)
        {
            _repository = repository;
        }

        public async Task<GetContactCategoryByIdQueryResult> Handle(GetContactCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetContactCategoryByIdQueryResult
            {
                ContactCategoryId = value.ContactCategoryId,
                Name = value.Name
            };
        }
    }
}
