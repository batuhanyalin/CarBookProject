using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Dto.CarFeatureDtos
{
    public class CarFeatureListByCarIdDto
    {
        public int carFeatureId { get; set; }
        public int carId { get; set; }
        public int featureId { get; set; }
        public string featureName { get; set; }
        public bool available { get; set; }
    }
}
