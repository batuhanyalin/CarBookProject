using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.CQRS.Commands.CarCommands
{
    public class DeleteCarCommand
    {
        public int Id { get; set; }

        public DeleteCarCommand(int id)
        {
            Id = id;
        }
    }
}
