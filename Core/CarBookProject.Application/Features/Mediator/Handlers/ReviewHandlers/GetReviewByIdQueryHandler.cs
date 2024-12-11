using CarBookProject.Application.Features.Mediator.Queries.ReviewQueries;
using CarBookProject.Application.Features.Mediator.Results.ReviewResults;
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
    public class GetReviewByIdQueryHandler : IRequestHandler<GetReviewByIdQuery, GetReviewByIdQueryResult>
    {
        private readonly IRepository<Review> _repository;

        public GetReviewByIdQueryHandler(IRepository<Review> repository)
        {
            _repository = repository;
        }

        public async Task<GetReviewByIdQueryResult> Handle(GetReviewByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetReviewByIdQueryResult
            {
                ReviewId = value.ReviewId,
                Name = value.Name,
                CreatedDate = value.CreatedDate,
                Text = value.Text,
                Surname = value.Surname,
                IsApproved = value.IsApproved,
                ImageUrl = value.ImageUrl,
                Email = value.Email
            };
        }
    }
}