using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Results.ReservationStatusResults
{
    public class GetReservationStatusByIdQueryResult
    {
        public int ReservationStatusId { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
    }
}
