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
    public class GetCarLast5WithBrandQueryHandler
    {
        private readonly ICarRepository _carRepository;

        public GetCarLast5WithBrandQueryHandler(ICarRepository carRepository)
        {
            _carRepository = carRepository;
        }
        public List<GetCarLast5WithBrandQueryResult> Handle()
        {
            var values = _carRepository.GetCarLast5WithBrand();
            return values.Select(x => new GetCarLast5WithBrandQueryResult
            {
                BigImageUrl = x.BigImageUrl,
                BrandId = x.BrandId,
                BrandName = x.Brand.Name,
                CarId = x.CarId,
                CoverImageUrl = x.CoverImageUrl,
                Fuel = x.Fuel,
                Km = x.Km,
                Luggage = x.Luggage,
                Model = x.Model,
                Seat = x.Seat,
                Transmission = x.Transmission,
            }).ToList();
        }
    }
}
