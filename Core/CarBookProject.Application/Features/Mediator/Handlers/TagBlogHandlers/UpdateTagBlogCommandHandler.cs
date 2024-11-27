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
    public class UpdateTagBlogCommandHandler : IRequestHandler<UpdateTagBlogCommand>
    {
        private readonly IRepository<TagBlog> _repository;

        public UpdateTagBlogCommandHandler(IRepository<TagBlog> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateTagBlogCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.TagId);
            value.TagId = request.TagId;
            value.BlogId = request.BlogId;
            await _repository.UpdateAsync(value);
        }
    }
}