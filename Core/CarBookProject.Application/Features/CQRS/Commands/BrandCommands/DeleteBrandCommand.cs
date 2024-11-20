using CarBookProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.CQRS.Commands.BrandCommands
{
    public class DeleteBrandCommand
    {
        public int Id { get; set; }

        public DeleteBrandCommand(int id)
        {
            Id = id;
        }
    }
}
