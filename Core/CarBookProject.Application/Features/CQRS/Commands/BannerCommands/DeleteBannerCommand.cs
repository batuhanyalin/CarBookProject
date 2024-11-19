using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.CQRS.Commands.BannerCommands
{
    public class DeleteBannerCommand
    {
        public int Id { get; set; }

        public DeleteBannerCommand(int id)
        {
            Id = id;
        }
    }
}
