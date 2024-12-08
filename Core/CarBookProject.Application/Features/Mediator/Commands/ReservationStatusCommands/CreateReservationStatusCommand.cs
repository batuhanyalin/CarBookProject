using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Commands.ReservationStatusCommands
{
    public class CreateReservationStatusCommand : IRequest
    {
        public string Name { get; set; }
        public string Icon { get; set; }

    }
}
