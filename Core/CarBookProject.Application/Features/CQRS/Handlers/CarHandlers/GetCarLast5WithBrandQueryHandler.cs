using CarBookProject.Application.Features.CQRS.Results.CarResults;
using CarBookProject.Application.Interfaces.ICarPricingInterfaces;
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
        private readonly ICarPricingRepository _carRepository;

        public GetCarLast5WithBrandQueryHandler(ICarPricingRepository carRepository)
        {
            _carRepository = carRepository;
        }
        public List<GetCarLast5WithBrandQueryResult> Handle()
        {
            var values = _carRepository.GetCarLast5WithAllInfo();
            return values.Select(x => new GetCarLast5WithBrandQueryResult
            {
                BigImageUrl = x.Car.BigImageUrl,
                BrandId = x.Car.BrandId,
                BrandName = x.Car.Brand.Name,
                CarId = x.CarId,
                CoverImageUrl = x.Car.CoverImageUrl,
                Fuel = x.Car.Fuel,
                Km = x.Car.Km,
                Luggage = x.Car.Luggage,
                Model = x.Car.Model,
                Seat = x.Car.Seat,
                Transmission = x.Car.Transmission,
                PricingAmount=x.Price,
                PricingName =x.Pricing.Name,
            }).ToList();
        }
    }
}
