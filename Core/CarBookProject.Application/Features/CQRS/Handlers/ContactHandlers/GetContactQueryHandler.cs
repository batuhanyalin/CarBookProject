using CarBookProject.Application.Features.CQRS.Results.ContactResults;
using CarBookProject.Application.Interfaces;
using CarBookProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.CQRS.Handlers.ContactHandlers
{
    public class GetContactQueryHandler
    {
        private readonly IRepository<Contact> _repository;

        public GetContactQueryHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }
        public async Task<List<GetContactQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x=>new GetContactQueryResult()
            {
                ContactCategoryId = x.ContactCategoryId,
                ContactId = x.ContactId,
                Email = x.Email,
                IsApproved = x.IsApproved,Name = x.Name,
                Phone = x.Phone,
                SendingDate=x.SendingDate,
                Subject=x.Subject,
                Surname=x.Surname,
                Text=x.Text,
            }).ToList();
        }
    }
}
