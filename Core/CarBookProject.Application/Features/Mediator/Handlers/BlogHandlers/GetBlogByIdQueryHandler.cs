using CarBookProject.Application.Features.Mediator.Queries.BlogQueries;
using CarBookProject.Application.Features.Mediator.Results.BlogResults;
using CarBookProject.Application.Interfaces;
using CarBookProject.Application.Interfaces.BlogInterfaces;
using CarBookProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetBlogByIdQueryHandler 
    {
        private readonly IRepository<Blog> _repository;

        public GetBlogByIdQueryHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task<GetBlogByIdQueryResult> Handle(GetBlogByIdQuery request)
        {
           var value= await _repository.GetByIdAsync(request.Id);
            return new GetBlogByIdQueryResult
            {
                AuthorId = value.AuthorId,
                BlogId = value.BlogId,
                CategoryId = value.CategoryId,
                CoverImageUrl = value.CoverImageUrl,
                CreatedDate = value.CreatedDate,
                Text = value.Text,
                Title = value.Title,
            };
        }
    }
}
