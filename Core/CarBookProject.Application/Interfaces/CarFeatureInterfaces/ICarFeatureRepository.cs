using CarBookProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Interfaces.CarFeatureInterfaces
{
    public interface ICarFeatureRepository
    {
        public List<CarFeature> GetCarFeatureListByCarId(int id);
        void ChangeCarFeatureAvaiableToFalse(int id);
        void ChangeCarFeatureAvaiableToTrue(int id);
    }
}
