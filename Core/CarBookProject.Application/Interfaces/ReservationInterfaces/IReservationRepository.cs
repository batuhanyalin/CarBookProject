using CarBookProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Interfaces.ReservationInterfaces
{
    public interface IReservationRepository
    {
        public List<Reservation> GetReservationListWithAllInfo();
        public Reservation GetReservationById(int id);
    }
}
