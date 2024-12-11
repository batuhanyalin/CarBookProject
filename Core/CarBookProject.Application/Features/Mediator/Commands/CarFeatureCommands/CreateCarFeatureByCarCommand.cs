using CarBookProject.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Commands.CarFeatureCommands
{
    public class CreateCarFeatureByCarCommand:IRequest
    {
        public int CarId { get; set; }
        public int FeatureId { get; set; }
        public bool Available { get; set; }
    }
}
