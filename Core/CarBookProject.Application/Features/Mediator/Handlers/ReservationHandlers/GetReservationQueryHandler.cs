using CarBookProject.Application.Features.Mediator.Queries.ReservationQueries;
using CarBookProject.Application.Features.Mediator.Results.ReservationResults;
using CarBookProject.Application.Interfaces;
using CarBookProject.Application.Interfaces.ReservationInterfaces;
using CarBookProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Handlers.ReservationHandlers
{
    public class GetReservationQueryHandler : IRequestHandler<GetReservationQuery, List<GetReservationQueryResult>>
    {
        public IReservationRepository _repository;

        public GetReservationQueryHandler(IReservationRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetReservationQueryResult>> Handle(GetReservationQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetReservationListWithAllInfo();
            return values.Select(x => new GetReservationQueryResult
            {
                ReservationId = x.ReservationId,
                Age = x.Age,
                CarId = x.CarId,
                Description = x.Description,
                DriverLicenseYear = x.DriverLicenseYear,
                DropOffLocationId = x.DropOffLocationId,
                Email = x.Email,
                Name = x.Name,
                Phone = x.Phone,
                PickUpLocationId = x.PickUpLocationId,
                Surname = x.Surname,
                BrandName= x.Car.Brand.Name,
                ModelName=x.Car.Model,
                PicUpLocationName=x.PickUpLocation.Name,
                DropOffLocationName=x.DropOffLocation.Name,
            }).ToList();
        }
    }
}
