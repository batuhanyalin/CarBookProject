using CarBookProject.Application.Features.CQRS.Queries.CarQueries;
using CarBookProject.Application.Features.CQRS.Results.CarResults;
using CarBookProject.Application.Interfaces;
using CarBookProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarByIdQueryHandler
    {
        private readonly IRepository<Car> _repository;

        public GetCarByIdQueryHandler(IRepository<Car> repository)
        {
            _repository = repository;
        }
        public async Task<GetCarByIdQueryResult> Handle(GetCarByIdQuery query)
        {
            var value = await _repository.GetByIdAsync(query.Id);
            return new GetCarByIdQueryResult
            {
                BigImageUrl= value.BigImageUrl,
                BrandId= value.BrandId,
                CarId= value.CarId,
                CoverImageUrl= value.CoverImageUrl,
                Fuel = value.Fuel,
                Km = value.Km,
                Luggage = value.Luggage,
                Model = value.Model,
                Seat = value.Seat,
                Transmission = value.Transmission,
                Brand = value.Brand
            };
        }
    }
}
