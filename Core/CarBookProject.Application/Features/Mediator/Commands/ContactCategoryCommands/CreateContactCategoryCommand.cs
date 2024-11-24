using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Commands.ContactCategoryCommands
{
    public class CreateContactCategoryCommand : IRequest
    {
        public string Name { get; set; }
    }
}
