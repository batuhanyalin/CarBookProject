using CarBookProject.Application.Features.Mediator.Commands.TagBlogCommands;
using CarBookProject.Application.Interfaces;
using CarBookProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Handlers.TagBlogHandlers
{
    public class CreateTagBlogCommandHandler : IRequestHandler<CreateTagBlogCommand>
    {
        private readonly IRepository<TagBlog> _repository;

        public CreateTagBlogCommandHandler(IRepository<TagBlog> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateTagBlogCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new TagBlog
            {
              BlogId = request.BlogId,
              TagId = request.TagId,
            });
        }
    }
}