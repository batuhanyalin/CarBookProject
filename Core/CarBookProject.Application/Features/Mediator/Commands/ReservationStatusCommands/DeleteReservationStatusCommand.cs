using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Commands.ReservationStatusCommands
{
    public class DeleteReservationStatusCommand : IRequest
    {
        public int Id { get; set; }

        public DeleteReservationStatusCommand(int id)
        {
            Id = id;
        }
    }
}
