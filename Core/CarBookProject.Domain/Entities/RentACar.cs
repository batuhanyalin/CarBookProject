using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Domain.Entities
{
    public class RentACar
    {
        public int RentACarId { get; set; }
        public int LocationId { get; set; }
        public Location Location { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
        public bool Available { get; set; }
    }
}
