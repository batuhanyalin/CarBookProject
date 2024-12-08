using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Dto.ReservationDtos
{
    public class ReservationListDto
    {
        public int reservationId { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public int pickUpLocationId { get; set; }
        public string picUpLocationName { get; set; }
        public int dropOffLocationId { get; set; }
        public string dropOffLocationName { get; set; }
        public int carId { get; set; }
        public string brandName { get; set; }
        public string modelName { get; set; }
        public int age { get; set; }
        public int driverLicenseYear { get; set; }
        public string description { get; set; }
        public int reservationStatusId { get; set; }
        public object reservationStatusName { get; set; }
        public string ReservationStatusIcon { get; set; }
    }
}
