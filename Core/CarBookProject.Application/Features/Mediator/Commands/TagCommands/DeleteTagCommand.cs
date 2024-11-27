using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Commands.TagCommands
{
    public class DeleteTagCommand : IRequest
    {
        public int Id { get; set; }

        public DeleteTagCommand(int id)
        {
            Id = id;
        }
    }
}