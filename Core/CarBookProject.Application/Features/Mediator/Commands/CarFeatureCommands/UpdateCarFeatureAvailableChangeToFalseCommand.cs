using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Commands.CarFeatureCommands
{
    public class UpdateCarFeatureAvailableChangeToFalseCommand : IRequest
    {
        public int Id { get; set; }

        public UpdateCarFeatureAvailableChangeToFalseCommand(int id)
        {
            Id = id;
        }
    }
}