using CarBookProject.Application.Interfaces.CarFeatureInterfaces;
using CarBookProject.Domain.Entities;
using CarBookProject.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Persistence.Repositories.CarFeatureRepositories
{
    public class CarFeatureRepository : ICarFeatureRepository
    {
        private readonly CarBookContext _context;

        public CarFeatureRepository(CarBookContext context)
        {
            _context = context;
        }

        public void ChangeCarFeatureAvaiableToFalse(int id)
        {
            var values= _context.CarFeatures.Where(x=>x.CarFeatureId==id).FirstOrDefault();
            values.Available = false;
            _context.SaveChanges();
        }

        public void ChangeCarFeatureAvaiableToTrue(int id)
        {
            var values = _context.CarFeatures.Where(x => x.CarFeatureId == id).FirstOrDefault();
            values.Available = true;
            _context.SaveChanges();
        }

        public void CreateCarFeatureByCarId(CarFeature carFeature)
        {
            _context.CarFeatures.Add(carFeature);
            _context.SaveChanges();
        }

        public List<CarFeature> GetCarFeatureListByCarId(int id)
        {
           var values= _context.CarFeatures.Where(x=>x.CarId == id).Include(x=>x.Feature).Include(x=>x.Car).ToList();
            return values;
        }
    }
}
