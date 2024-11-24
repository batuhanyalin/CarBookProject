using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Commands.ContactCategoryCommands
{
    public class UpdateContactCategoryCommand : IRequest
    {
        public int ContactCategoryId { get; set; }
        public string Name { get; set; }
    }
}
