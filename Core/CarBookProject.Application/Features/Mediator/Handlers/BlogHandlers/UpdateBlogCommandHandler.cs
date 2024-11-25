using CarBookProject.Application.Features.Mediator.Commands.BlogCommands;
using CarBookProject.Application.Interfaces;
using CarBookProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class UpdateBlogCommandHandler 
    {
        private readonly IRepository<Blog> _repository;

        public UpdateBlogCommandHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBlogCommand request)
        {
            var value = await _repository.GetByIdAsync(request.BlogId);
            value.Title = request.Title;
            value.Text = request.Text;
            value.CreatedDate = request.CreatedDate;
            value.AuthorId = request.AuthorId;
            value.CategoryId = request.CategoryId;
            value.CoverImageUrl = request.CoverImageUrl;
            await _repository.UpdateAsync(value);
        }
    }
}
