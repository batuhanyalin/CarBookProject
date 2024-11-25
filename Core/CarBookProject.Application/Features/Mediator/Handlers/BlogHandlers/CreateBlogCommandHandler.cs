using CarBookProject.Application.Features.CQRS.Commands.CarCommands;
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
    public class CreateBlogCommandHandler
    {
        private readonly IRepository<Blog> _repository;

        public CreateBlogCommandHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateBlogCommand request)
        {
            await _repository.CreateAsync(new Blog
            {
                AuthorId = request.AuthorId,
                Title = request.Title,
                Text = request.Text,
                CategoryId = request.CategoryId,
                CoverImageUrl = request.CoverImageUrl,
                CreatedDate = request.CreatedDate,
            });
        }
    }
}
