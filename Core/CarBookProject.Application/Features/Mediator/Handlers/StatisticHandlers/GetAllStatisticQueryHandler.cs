using CarBookProject.Application.Features.Mediator.Queries.StatisticQueries;
using CarBookProject.Application.Features.Mediator.Results.StatisticResult;
using CarBookProject.Application.Interfaces;
using CarBookProject.Application.Interfaces.CarInterfaces;
using CarBookProject.Application.Interfaces.StatisticInterfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Features.Mediator.Handlers.StatisticHandlers
{
    public class GetAllStatisticQueryHandler : IRequestHandler<GetAllStatisticQuery, GetAllStatisticQueryResult>
    {
        private readonly IStatisticRepository _repository;

        public GetAllStatisticQueryHandler(IStatisticRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetAllStatisticQueryResult> Handle(GetAllStatisticQuery request, CancellationToken cancellationToken)
        {
            var CarCount = _repository.GetCarCount();
            var BlogCount= _repository.GetBlogCount();
            var AuthorCount = _repository.GetAuthorCount();
            var BrandCount = _repository.GetBrandCount();
            var LocationCount = _repository.GetLocationCount();
            var GetCarCountByFuelGasolineOrDiesel = _repository.GetCarCountByFuelGasolineOrDiesel();
            var GetCarCountByKmSmallerThen10000 = _repository.GetCarCountByKmSmallerThen10000();
            var GetCarCountByTransmissionAuto = _repository.GetCarCountByTransmissionAuto();
            var GetCarCountByFuelElectric = _repository.GetCarCountByFuelElectric();
            var GetAvgRentPriceForDaily = _repository.GetAvgRentPriceForDaily();
            var GetAvgRentPriceForWeekly = _repository.GetAvgRentPriceForWeekly();
            var GetAvgRentPriceForMonthly = _repository.GetAvgRentPriceForMonthly();
            var GetCarBrandAndModelByMostExpensiveRentPriceDaily = _repository.GetCarBrandAndModelByMostExpensiveRentPriceDaily();
            var GetCarBrandAndModelByCheapestRentPriceDaily = _repository.GetCarBrandAndModelByCheapestRentPriceDaily();
            var GetBrandNameByMaxCar = _repository.GetBrandNameByMaxCar();
            var GetMostHaveCommentBlog = _repository.GetMostHaveCommentBlog();

            return new GetAllStatisticQueryResult
            {
                CarCount = CarCount,
                BlogCount = BlogCount,
                AuthorCount = AuthorCount,
                BrandCount = BrandCount,
                LocationCount = LocationCount,
                GetCarCountByFuelGasolineOrDiesel = GetCarCountByFuelGasolineOrDiesel,
                GetAvgRentPriceForDaily = GetAvgRentPriceForDaily,
                GetAvgRentPriceForWeekly = GetAvgRentPriceForWeekly,
                GetCarCountByFuelElectric = GetCarCountByFuelElectric,
                GetCarCountByKmSmallerThen10000 = GetCarCountByKmSmallerThen10000,
                GetCarCountByTransmissionAuto = GetCarCountByTransmissionAuto,
                GetAvgRentPriceForMonthly=GetAvgRentPriceForMonthly,
                GetCarBrandAndModelByMostExpensiveRentPriceDaily=GetCarBrandAndModelByMostExpensiveRentPriceDaily,
                GetCarBrandAndModelByCheapestRentPriceDaily= GetCarBrandAndModelByCheapestRentPriceDaily,
                GetBrandNameByMaxCar= GetBrandNameByMaxCar,
                GetMostHaveCommentBlog = GetMostHaveCommentBlog,
                
            };
        }
    }
}
