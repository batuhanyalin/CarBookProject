using CarBookProject.Application.Interfaces.ReservationInterfaces;
using CarBookProject.Domain.Entities;
using CarBookProject.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Persistence.Repositories.ReservationRepositories
{
    public class ReservationRepository : IReservationRepository
    {
        private readonly CarBookContext _context;

        public ReservationRepository(CarBookContext context)
        {
            _context = context;
        }

        public List<Reservation> GetReservationListWithAllInfo()
        {
            var values = _context.Reservations.Include(x => x.Car).ThenInclude(x => x.Brand).Include(x => x.PickUpLocation).Include(x => x.DropOffLocation).Include(x=>x.ReservationStatus).ToList();
            return values;
        }
        public Reservation GetReservationById(int id)
        {
            var values = _context.Reservations.Where(x => x.ReservationId == id).Include(x=>x.ReservationStatus).Include(x => x.Car).ThenInclude(x => x.Brand).Include(x => x.PickUpLocation).Include(x => x.DropOffLocation).FirstOrDefault();
            return values;
        }
    }
}
