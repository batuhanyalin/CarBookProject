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
    public class DeleteTagBlogCommandHandler : IRequestHandler<DeleteTagBlogCommand>
    {
        private readonly IRepository<TagBlog> _repository;

        public DeleteTagBlogCommandHandler(IRepository<TagBlog> repository)
        {
            _repository = repository;
        }

        public async Task Handle(DeleteTagBlogCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.DeleteAsync(value);
        }
    }
}