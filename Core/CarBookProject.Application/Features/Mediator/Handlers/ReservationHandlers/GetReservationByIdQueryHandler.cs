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
    public class GetReservationByIdQueryHandler : IRequestHandler<GetReservationByIdQuery, GetReservationByIdQueryResult>
    {
        private readonly IReservationRepository _repository;

        public GetReservationByIdQueryHandler(IReservationRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetReservationByIdQueryResult> Handle(GetReservationByIdQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetReservationById(request.Id);
            return new GetReservationByIdQueryResult
            {
                ReservationId = value.ReservationId,
                Name = value.Name,
                ReservationStatusId = value.ReservationStatusId,
                Age = value.Age,
                BrandName = value.Car.Brand.Name,
                Description = value.Description,
                DriverLicenseYear = value.DriverLicenseYear,
                DropOffLocationId = value.DropOffLocationId,
                DropOffLocationName = value.DropOffLocation.Name,
                PickUpLocationId = value.PickUpLocationId,
                PicUpLocationName = value.PickUpLocation.Name,
                CarId = value.CarId,
                Email = value.Email,
                ModelName = value.Car.Model,
                Phone = value.Phone,
                Surname = value.Surname,
                ReservationStatusName = value.ReservationStatus.Name,
                ReservationStatusIcon=value.ReservationStatus.Icon,
            };
        }
    }
}
