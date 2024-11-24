using CarBookProject.Application.Features.CQRS.Queries.ContactQueries;
using CarBookProject.Application.Features.CQRS.Results.ContactResults;
using CarBookProject.Application.Interfaces;
using CarBookProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.CQRS.Handlers.ContactHandlers
{
    public class GetContactWithCategoryQueryHandler : IRequestHandler<GetContactWithCategoryQuery, List<GetContactWithCategoryQueryResult>>
    {
        private readonly IRepository<Contact> _repository;

        public GetContactWithCategoryQueryHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetContactWithCategoryQueryResult>> Handle(GetContactWithCategoryQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetContactWithCategoryQueryResult
            {
                CategoryName = x.ContactCategory.Name,
                Name = x.Name,
                Surname = x.Surname,
                Email = x.Email,
                Phone = x.Phone,
                IsApproved = x.IsApproved,
                SendingDate = x.SendingDate,
                Text = x.Text,
                Subject = x.Subject,
                ContactId = x.ContactId,
                ContactCategoryId=x.ContactCategoryId
            }).ToList();
        }
    }
}
