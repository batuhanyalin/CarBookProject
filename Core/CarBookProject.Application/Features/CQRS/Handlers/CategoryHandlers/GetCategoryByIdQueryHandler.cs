using CarBookProject.Application.Features.CQRS.Queries.CategoryQueries;
using CarBookProject.Application.Features.CQRS.Results.CategoryResults;
using CarBookProject.Application.Interfaces;
using CarBookProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class GetCategoryByIdQueryHandler
    {
        private readonly IRepository<Category> _repository;

        public GetCategoryByIdQueryHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task<GetCategoryByIdQueryResult> Handle(GetCategoryByIdQuery query)
        {
            var value= await _repository.GetByIdAsync(query.Id);
            return new GetCategoryByIdQueryResult
            {
                CategoryId = value.CategoryId,
                Name = value.Name,
            };
        }
    }
}
