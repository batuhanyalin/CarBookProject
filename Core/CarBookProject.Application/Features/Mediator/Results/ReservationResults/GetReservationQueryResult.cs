using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Results.ReservationResults
{
    public class GetReservationQueryResult
    {
        public int ReservationId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int? PickUpLocationId { get; set; }
        public string PicUpLocationName { get; set; }
        public int? DropOffLocationId { get; set; }
        public string DropOffLocationName { get; set; }
        public int CarId { get; set; }
        public string BrandName { get; set; }
        public string ModelName { get; set; }
        public int Age { get; set; }
        public int DriverLicenseYear { get; set; }
        public string Description { get; set; }
    }
}
