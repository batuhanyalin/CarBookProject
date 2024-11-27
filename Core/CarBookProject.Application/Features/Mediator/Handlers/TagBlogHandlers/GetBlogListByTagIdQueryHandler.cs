using CarBookProject.Application.Features.Mediator.Queries.TagBlogQueries;
using CarBookProject.Application.Features.Mediator.Results.TagBlogResults;
using CarBookProject.Application.Interfaces;
using CarBookProject.Application.Interfaces.TagBlogInterfaces;
using CarBookProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Handlers.TagBlogHandlers
{
    public class GetBlogListByTagIdQueryHandler : IRequestHandler<GetBlogListByTagIdQuery, List<GetBlogListByTagIdQueryResult>>
    {
        private readonly ITagBlogRepository _repository;

        public GetBlogListByTagIdQueryHandler(ITagBlogRepository repository)
        {
            _repository = repository;
        }

        public Task<List<GetBlogListByTagIdQueryResult>> Handle(GetBlogListByTagIdQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetBlogListByTagId(request.Id);
            var task = values.Select(x => new GetBlogListByTagIdQueryResult()
            {
                AuthorId = x.Blog.AuthorId,
                BlogId = x.Blog.BlogId,
                CategoryId = x.Blog.CategoryId,
                CoverImageUrl = x.Blog.CoverImageUrl,
                CreatedDate = x.Blog.CreatedDate,
                Text = x.Blog.Text,
                Title = x.Blog.Title,
                AuthorName=x.Blog.Author.Name+" "+x.Blog.Author.Surname,
                CategoryName=x.Blog.Category.Name,
                CommentCount=x.Blog.Comments.Count,
                
            }).ToList();
            return Task.FromResult(task);
        }
    }
}