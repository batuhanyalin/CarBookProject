using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Results.StatisticResult
{
    public class GetAllStatisticQueryResult
    {
        public int CarCount { get; set; }
        public int BlogCount { get; set; }
        public int AuthorCount { get; set; }
        public int BrandCount { get; set; }
        public int LocationCount { get; set; }
        public int GetCarCountByFuelGasolineOrDiesel { get; set; }
        public int GetCarCountByKmSmallerThen10000 { get; set; }
        public int GetCarCountByTransmissionAuto { get; set; }
        public int GetCarCountByFuelElectric { get; set; }
        public decimal GetAvgRentPriceForDaily { get; set; }
        public decimal GetAvgRentPriceForMonthly { get; set; }
        public decimal GetAvgRentPriceForWeekly { get; set; }
        public string GetCarBrandAndModelByMostExpensiveRentPriceDaily { get; set; }
        public string GetCarBrandAndModelByCheapestRentPriceDaily { get; set; }
        public string GetBrandNameByMaxCar { get; set; }
        public string GetMostHaveCommentBlog { get; set; }

    }
}
