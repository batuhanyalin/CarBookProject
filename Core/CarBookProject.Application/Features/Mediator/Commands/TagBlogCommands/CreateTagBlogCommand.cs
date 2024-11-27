using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Commands.TagBlogCommands
{
    public class CreateTagBlogCommand : IRequest
    {
        public int BlogId { get; set; }
        public int TagId { get; set; }
    }
}