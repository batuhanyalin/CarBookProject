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
    public class GetReviewQueryHandler : IRequestHandler<GetReviewQuery, List<GetReviewQueryResult>>
    {
        private readonly IRepository<Review> _repository;

        public GetReviewQueryHandler(IRepository<Review> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetReviewQueryResult>> Handle(GetReviewQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetReviewQueryResult()
            {
                ReviewId = x.ReviewId,
                Name = x.Name,
                Email = x.Email,
                ImageUrl = x.ImageUrl,
                IsApproved = x.IsApproved,
                Surname = x.Surname,
                Text = x.Text,
                CreatedDate = x.CreatedDate,
                CarId=x.CarId,
            }).ToList();
        }
    }
}