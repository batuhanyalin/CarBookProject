using CarBookProject.Application.Interfaces.CarInterfaces;
using CarBookProject.Domain.Entities;
using CarBookProject.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Persistence.Repositories.CarRepositories
{
    public class CarRepository : ICarRepository
    {
        private readonly CarBookContext _context;

        public CarRepository(CarBookContext context)
        {
            _context = context;
        }

        public Car GetCarById(int id)
        {
            var value= _context.Cars.Where(x=>x.CarId==id).Include(x=>x.Brand).Include(x=>x.RentACarProcesses).Include(x=>x.RentACars).FirstOrDefault();
            return value;
        }

        public List<Car> GetCarLast5WithBrand()
        {
            var values = _context.Cars.Include(x => x.Brand).Take(5).OrderByDescending(x => x.CarId).ToList();
            return values;
        }

        public List<Car> GetCarListWithBrands()
        {
            var values = _context.Cars.Include(x => x.Brand).ToList();
            return values;
        }
    }
}
