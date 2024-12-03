using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Interfaces.StatisticInterfaces
{
    public interface IStatisticRepository
    {
        int GetCarCount();
        int GetLocationCount();
        int GetAuthorCount();
        int GetBlogCount();
        int GetBrandCount();
        decimal GetAvgRentPriceForDaily();
        decimal GetAvgRentPriceForWeekly();
        decimal GetAvgRentPriceForMonthly();
        int GetCarCountByTransmissionAuto();
        string GetBrandNameByMaxCar();
        string GetMostHaveCommentBlog();
        int GetCarCountByKmSmallerThen10000();
        int GetCarCountByFuelGasolineOrDiesel();
        int GetCarCountByFuelElectric();
        string GetCarBrandAndModelByMostExpensiveRentPriceDaily();
        string GetCarBrandAndModelByCheapestRentPriceDaily();

    }
}
