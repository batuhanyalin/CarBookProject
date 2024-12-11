using CarBookProject.Application.Features.CQRS.Results.CarResults;
using CarBookProject.Application.Interfaces;
using CarBookProject.Application.Interfaces.CarInterfaces;
using CarBookProject.Application.Interfaces.ICarPricingInterfaces;
using CarBookProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarWithPricingQueryHandler
    {
        private readonly ICarPricingRepository _repository;

		public GetCarWithPricingQueryHandler(ICarPricingRepository repository)
		{
			_repository = repository;
		}

		public List<GetCarWithPricingQueryResult> Handle()
        {
            var values = _repository.GetCarPricingWithAllInfo();
            return values.Select(x => new GetCarWithPricingQueryResult
            {
                BrandName = x.Car.Brand.Name,
                BigImageUrl = x.Car.BigImageUrl,
                BrandId = x.Car.BrandId,
                CarId = x.Car.CarId,
                CoverImageUrl = x.Car.CoverImageUrl,
                Fuel = x.Car.Fuel,
                Km = x.Car.Km,
                Luggage = x.Car.Luggage,
                Model = x.Car.Model,
                Seat = x.Car.Seat,
                Transmission = x.Car.Transmission,
                PricingName= x.Pricing.Name,
                PricingAmount=x.Price,
                Description = x.Car.Description,
            }).ToList();
        }
    }
}
