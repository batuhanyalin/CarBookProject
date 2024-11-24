using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Commands.ContactCategoryCommands
{
    public class DeleteContactCategoryCommand:IRequest
    {
        public int Id { get; set; }

        public DeleteContactCategoryCommand(int id)
        {
            Id = id;
        }
    }
}
