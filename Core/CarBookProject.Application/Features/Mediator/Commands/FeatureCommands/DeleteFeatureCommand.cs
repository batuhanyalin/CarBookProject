using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Commands.FeatureCommands
{
    public class DeleteFeatureCommand : IRequest
    {
        public int Id { get; set; }

        public DeleteFeatureCommand(int id)
        {
            Id = id;
        }
    }
}
