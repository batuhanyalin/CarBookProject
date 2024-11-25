using CarBookProject.Application.Features.Mediator.Results.BlogResults;
using CarBookProject.Application.Interfaces.BlogInterfaces;
using CarBookProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetBlogLast3WithAllInfoQueryHandler
    {
        private readonly IBlogRepository _repository;

        public GetBlogLast3WithAllInfoQueryHandler(IBlogRepository repository)
        {
            _repository = repository;
        }
        public List<GetBlogQueryResult> Handle()
        {
            var values = _repository.GetBlogLast3WithAllInfo();
            return values.Select(x => new GetBlogQueryResult
            {
                AuthorId = x.AuthorId,
                AuthorName = x.Author.Name + " " + x.Author.Surname,
                BlogId = x.BlogId,
                CategoryId = x.CategoryId,
                CategoryName = x.Category.Name,
                CoverImageUrl = x.CoverImageUrl,
                CreatedDate = x.CreatedDate,
                Text = x.Text,
                Title = x.Title,
                CommentCount= x.Comments.Count,
            }).ToList();
        }
    }
}
