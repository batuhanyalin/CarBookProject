using CarBookProject.Application.Features.Mediator.Results.BlogResults;
using CarBookProject.Application.Interfaces.BlogInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Handlers.BlogHandlers
{
	public class GetBlogWithAllInfoQueryHandler
	{
		private readonly IBlogRepository _repository;

		public GetBlogWithAllInfoQueryHandler(IBlogRepository repository)
		{
			_repository = repository;
		}

		public List<GetBlogQueryResult> Handle()
		{
			var values = _repository.GetBlogListWithAllInfo();
			return values.Select(x => new GetBlogQueryResult
			{
				BlogId = x.BlogId,
				AuthorId = x.AuthorId,
				AuthorName = x.Author.Name + " " + x.Author.Surname,
				CategoryId = x.CategoryId,
				CategoryName = x.Category.Name,
				CommentCount = x.Comments.Count,
				CoverImageUrl = x.CoverImageUrl,
				CreatedDate = x.CreatedDate,
				Text = x.Text,
				Title = x.Title
			}).ToList();
		}
	}
}
