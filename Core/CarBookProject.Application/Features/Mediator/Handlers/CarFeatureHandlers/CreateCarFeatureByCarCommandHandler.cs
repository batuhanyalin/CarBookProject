using CarBookProject.Application.Features.Mediator.Commands.CarFeatureCommands;
using CarBookProject.Application.Interfaces.CarFeatureInterfaces;
using CarBookProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Handlers.CarFeatureHandlers
{
    public class CreateCarFeatureByCarCommandHandler : IRequestHandler<CreateCarFeatureByCarCommand>
    {
        private readonly ICarFeatureRepository _repository;

        public CreateCarFeatureByCarCommandHandler(ICarFeatureRepository repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateCarFeatureByCarCommand request, CancellationToken cancellationToken)
        {
            _repository.CreateCarFeatureByCarId(new CarFeature
            {
                Available = false,
                CarId = request.CarId,
                FeatureId = request.FeatureId,
            });
        }
    }
}
