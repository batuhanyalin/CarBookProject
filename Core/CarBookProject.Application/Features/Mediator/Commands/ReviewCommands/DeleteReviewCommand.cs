using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Commands.ReviewCommands
{
    public class DeleteReviewCommand : IRequest
    {
        public int Id { get; set; }

        public DeleteReviewCommand(int id)
        {
            Id = id;
        }
    }
}