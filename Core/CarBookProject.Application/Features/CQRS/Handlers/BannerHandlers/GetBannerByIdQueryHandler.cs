using CarBookProject.Application.Features.CQRS.Queries.BannerQueries;
using CarBookProject.Application.Features.CQRS.Results.BannerResults;
using CarBookProject.Application.Interfaces;
using CarBookProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.CQRS.Handlers.BannerHandlers
{
    public class GetBannerByIdQueryHandler 
    {
        private readonly IRepository<Banner> _repository;

        public GetBannerByIdQueryHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }

        public async Task<GetBannerByIdQueryResult> Handle(GetBannerByIdQuery query)
        {
            var value= await _repository.GetByIdAsync(query.Id);
            return new GetBannerByIdQueryResult
            {
                BannerId = value.BannerId,
                VideoDescription = value.VideoDescription,
                Description = value.Description,
                Title = value.Title,
                VideoUrl = value.VideoUrl,
               ImageUrl=value.ImageUrl
            };

        }
    }
}
