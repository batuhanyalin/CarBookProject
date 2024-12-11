using CarBookProject.Application.Features.CQRS.Queries.CarQueries;
using CarBookProject.Application.Features.CQRS.Results.CarResults;
using CarBookProject.Application.Interfaces;
using CarBookProject.Application.Interfaces.CarInterfaces;
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
        private readonly ICarRepository _repository;

        public GetCarByIdQueryHandler(ICarRepository repository)
        {
            _repository = repository;
        }
        public async Task<GetCarByIdQueryResult> Handle(GetCarByIdQuery query)
        {
            var value = _repository.GetCarById(query.Id);
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
                BrandName=value.Brand.Name,
                Description = value.Description,
            };
        }
    }
}
