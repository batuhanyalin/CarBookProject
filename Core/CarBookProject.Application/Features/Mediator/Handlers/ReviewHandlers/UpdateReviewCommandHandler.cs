using CarBookProject.Application.Features.Mediator.Commands.ReviewCommands;
using CarBookProject.Application.Interfaces;
using CarBookProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Handlers.ReviewHandlers
{
    public class UpdateReviewCommandHandler : IRequestHandler<UpdateReviewCommand>
    {
        private readonly IRepository<Review> _repository;

        public UpdateReviewCommandHandler(IRepository<Review> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateReviewCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.ReviewId);
            value.ReviewId = request.ReviewId;
            value.Name = request.Name;
            value.Surname = request.Surname;
            value.Email = request.Email;
            value.Text = request.Text;
            value.IsApproved = request.IsApproved;
            value.CreatedDate = request.CreatedDate;
            value.ImageUrl = request.ImageUrl;
            value.CarId = request.CarId;
            await _repository.UpdateAsync(value);
        }
    }
}