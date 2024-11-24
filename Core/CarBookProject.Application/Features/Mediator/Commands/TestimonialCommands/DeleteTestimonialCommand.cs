using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Commands.TestimonialCommands
{
    public class DeleteTestimonialCommand : IRequest
    {
        public int Id { get; set; }

        public DeleteTestimonialCommand(int id)
        {
            Id = id;
        }
    }
}
