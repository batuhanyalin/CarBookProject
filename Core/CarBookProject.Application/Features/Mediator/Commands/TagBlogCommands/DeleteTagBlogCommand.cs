using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Commands.TagBlogCommands
{
    public class DeleteTagBlogCommand : IRequest
    {
        public int Id { get; set; }

        public DeleteTagBlogCommand(int id)
        {
            Id = id;
        }
    }
}