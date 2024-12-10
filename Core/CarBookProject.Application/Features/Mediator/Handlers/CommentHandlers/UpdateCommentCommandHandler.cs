using CarBookProject.Application.Features.Mediator.Commands.CommentCommands;
using CarBookProject.Application.Interfaces;
using CarBookProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Handlers.CommentHandlers
{
    public class UpdateCommentCommandHandler : IRequestHandler<UpdateCommentCommand>
    {
        private readonly IRepository<Comment> _repository;

        public UpdateCommentCommandHandler(IRepository<Comment> repository)
        {
            _repository = repository;
        }
        public async Task Handle(UpdateCommentCommand request, CancellationToken cancellationToken)
        {

            var value = await _repository.GetByIdAsync(request.CommentId);
            value.Surname = request.Surname;
            value.Name = request.Name;
            value.Text = request.Text;
            value.BlogId = request.BlogId;
            value.Email = request.Email;
            await _repository.UpdateAsync(value);
        }
    }
}
