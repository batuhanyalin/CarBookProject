using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Commands.ReservationCommands
{
    public class DeleteReservationCommand:IRequest
    {
        public int Id { get; set; }

        public DeleteReservationCommand(int id)
        {
            Id = id;
        }
    }
}
