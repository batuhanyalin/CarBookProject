using CarBookProject.Application.Features.CQRS.Results.CategoryResults;
using CarBookProject.Application.Interfaces;
using CarBookProject.Application.Interfaces.CategoryInterfaces;
using CarBookProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.CQRS.Handlers.CategoryHandlers
{
    public class GetCategoryWithBlogCountQueryHandler
    {
        private readonly ICategoryRepository _repository;

        public GetCategoryWithBlogCountQueryHandler(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public Task<List<GetCategoryWithBlogCountQueryResult>> Handle()
        {
            var values = _repository.GetCategoryListWithBlogCount();
            var task = values.Select(x => new GetCategoryWithBlogCountQueryResult()
            {
                CategoryId = x.CategoryId,
                BlogCount = x.Blogs.Count,
                Name = x.Name,
            }).ToList();
            return Task.FromResult(task);
        }
    }
}
