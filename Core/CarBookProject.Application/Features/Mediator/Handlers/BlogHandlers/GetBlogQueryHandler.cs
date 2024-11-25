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
    public class GetBlogQueryHandler
    {
        private readonly IBlogRepository _repository;

        public GetBlogQueryHandler(IBlogRepository repository)
        {
            _repository = repository;
        }

        public List<GetBlogQueryResult> Handle()
        {
            var values =  _repository.GetBlogListWithAllInfo();
            return values.Select(x => new GetBlogQueryResult()
            {
                BlogId = x.BlogId,
                AuthorId = x.AuthorId,
                AuthorName = x.Author.Name + " " + x.Author.Surname,
                CategoryName = x.Category.Name,
                CategoryId = x.CategoryId,
                CoverImageUrl = x.CoverImageUrl,
                CreatedDate = x.CreatedDate,
                Text = x.Text,
                Title = x.Title,
                CommentCount=x.Comments.Count
            }).ToList();
        }
    }
}
