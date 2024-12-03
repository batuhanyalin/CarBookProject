using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Dto.StatisticDtos
{
    public class StatisticDto
    {
        public int carCount { get; set; }
        public int blogCount { get; set; }
        public int authorCount { get; set; }
        public int brandCount { get; set; }
        public int locationCount { get; set; }
        public int getCarCountByFuelGasolineOrDiesel { get; set; }
        public int getCarCountByKmSmallerThen10000 { get; set; }
        public int getCarCountByTransmissionAuto { get; set; }
        public int getCarCountByFuelElectric { get; set; }
        public decimal getAvgRentPriceForDaily { get; set; }
        public decimal getAvgRentPriceForMonthly { get; set; }
        public decimal getAvgRentPriceForWeekly { get; set; }
        public string GetCarBrandAndModelByMostExpensiveRentPriceDaily { get; set; }
        public string GetCarBrandAndModelByCheapestRentPriceDaily { get; set; }
        public string GetBrandNameByMaxCar { get; set; }
        public string GetMostHaveCommentBlog { get; set; }

    }
}
