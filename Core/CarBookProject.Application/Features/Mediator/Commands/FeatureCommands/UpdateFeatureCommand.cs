using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Commands.FeatureCommands
{
    public class UpdateFeatureCommand
    {
        public int FeatureId { get; set; }
        public string Name { get; set; }
    }
}
