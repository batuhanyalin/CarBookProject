using CarBookProject.Application.Features.Mediator.Queries.BlogQueries;
using CarBookProject.Application.Features.Mediator.Results.BlogResults;
using CarBookProject.Application.Interfaces.BlogInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetBlogWithAllInfoByIdQueryHandler
    {
        private readonly IBlogRepository _repository;

        public GetBlogWithAllInfoByIdQueryHandler(IBlogRepository repository)
        {
            _repository = repository;
        }

        public GetBlogWithAllInfoByIdQueryResult Handle(int id)
        {
            var value = _repository.GetBlogWithAllInfoById(id);
            return new GetBlogWithAllInfoByIdQueryResult
            {
                AuthorId = value.AuthorId,
                AuthorName = value.Author.Name + " " + value.Author.Surname,
                BlogId = value.BlogId,
                CategoryId = value.CategoryId,
                CategoryName = value.Category.Name,
                CoverImageUrl = value.CoverImageUrl,
                CreatedDate = value.CreatedDate,
                Text = value.Text,
                Title = value.Title
            };
        }
    }
}
