using CarBookProject.Application.Features.Mediator.Queries.RentACarQueries;
using CarBookProject.Application.Features.Mediator.Results.RentACarResults;
using CarBookProject.Application.Interfaces.RentACarInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CarBookProject.Application.Features.Mediator.Handlers.RentACarHandlers
{
    public class GetRentACarQueryHandler : IRequestHandler<GetRentACarQuery, List<GetRentACarQueryResult>>
    {
        private readonly IRentACarRepository _repository;

        public GetRentACarQueryHandler(IRentACarRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetRentACarQueryResult>> Handle(GetRentACarQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByFilterAsync(x => x.LocationId == request.LocationId && x.Available == request.Available);
            var results = values.Select(x => new GetRentACarQueryResult
            {
                CarId = x.CarId,
                BigImageUrl=x.Car.BigImageUrl,
                BrandId = x.Car.BrandId,
                BrandName=x.Car.Brand.Name,
                CoverImageUrl=x.Car.CoverImageUrl,
                Fuel = x.Car.Fuel,
                Km= x.Car.Km,
                Luggage= x.Car.Luggage,
                Model=x.Car.Model,
                Seat = x.Car.Seat,
                Transmission = x.Car.Transmission,
            }).ToList();
            return results;
        }
    }

}
