using CarBookProject.Application.Interfaces.StatisticInterfaces;
using CarBookProject.Domain.Entities;
using CarBookProject.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Persistence.Repositories.StatisticRepositories
{
    public class StatisticRepository : IStatisticRepository
    {
        private readonly CarBookContext _context;

        public StatisticRepository(CarBookContext context)
        {
            _context = context;
        }

        public int GetAuthorCount()
        {
            var value = _context.Authors.Count();
            return value;
        }
        public int GetLocationCount()
        {
            var value = _context.Locations.Count();
            return value;
        }
        public int GetBlogCount()
        {
            var value = _context.Blogs.Count();
            return value;
        }

        public int GetBrandCount()
        {
            var value = _context.Brands.Count();
            return value;
        }

        public int GetCarCount()
        {
            var value = _context.Cars.Count();
            return value;
        }

        public decimal GetAvgRentPriceForDaily()
        {
            //select Avg(Price) from CarPricings where PricingId=(select PricingId from Pricings where Name='Günlük')
            int id = _context.Pricings.Where(x => x.Name == "Günlük").Select(x => x.PricingId).FirstOrDefault();
            var value = _context.CarPricings.Where(x => x.PricingId == id).Average(x => x.Price);
            return value;
        }

        public decimal GetAvgRentPriceForMonthly()
        {

            int id = _context.Pricings.Where(x => x.Name == "Aylık").Select(x => x.PricingId).FirstOrDefault();
            var value = _context.CarPricings.Where(x => x.PricingId == id).Average(x => x.Price);
            return value;
        }

        public decimal GetAvgRentPriceForWeekly()
        {
            //select Avg(Price) from CarPricings where PricingId=(select PricingId from Pricings where Name='Günlük')
            int id = _context.Pricings.Where(x => x.Name == "Haftalık").Select(x => x.PricingId).FirstOrDefault();
            var value = _context.CarPricings.Where(x => x.PricingId == id).Average(x => x.Price);
            return value;
        }

        public int GetCarCountByFuelElectric()
        {
            var value = _context.Cars.Where(x => x.Fuel == "Elektrik").Count();
            return value;
        }

        public int GetCarCountByFuelGasolineOrDiesel()
        {
            var value = _context.Cars.Where(x => x.Fuel == "Benzin" || x.Fuel == "Dizel").Count();
            return value;
        }

        public int GetCarCountByKmSmallerThen10000()
        {
            var value = _context.Cars.Where(x => x.Km <= 1000).Count();
            return value;
        }

        public int GetCarCountByTransmissionAuto()
        {
            var value = _context.Cars.Where(x => x.Transmission == "Otomatik").Count();
            return value;
        }



        public string GetBrandNameByMaxCar()
        {
            //select Top(1) Brands.Name,Count(*) as 'ToplamArac' from cars inner join Brands on Cars.BrandId = Brands.BrandId group by Brands.Name Order By ToplamArac Desc
            var values = _context.Cars.GroupBy(x => x.BrandId).
                Select(y => new
                {
                    BrandId = y.Key,
                    Count = y.Count()
                }).OrderByDescending(z => z.Count).Take(1).FirstOrDefault();

            var brandName = _context.Brands.Where(x => x.BrandId == values.BrandId).Select(x => x.Name).FirstOrDefault();
            return brandName;

        }
        public string GetCarBrandAndModelByCheapestRentPriceDaily()
        {

            int pricingId = _context.Pricings.Where(x => x.Name == "Günlük").Select(x => x.PricingId).FirstOrDefault();
            decimal price = _context.CarPricings.Where(x => x.PricingId == pricingId).Min(x => x.Price);
            int carId = _context.CarPricings.Where(x => x.Price == price).Select(x => x.CarId).FirstOrDefault();
            string brandModel = _context.Cars.Where(x => x.CarId == carId).Include(x => x.Brand).Select(x => x.Brand.Name + " " + x.Model).FirstOrDefault();

            return brandModel;
        }
        public string GetCarBrandAndModelByMostExpensiveRentPriceDaily()
        {

            //select * From CarPricings wHERE Price=(Select Max(Price) From CarPricings where PricingId=2)

            int pricingId = _context.Pricings.Where(x => x.Name == "Günlük").Select(x => x.PricingId).FirstOrDefault();
            decimal price = _context.CarPricings.Where(x => x.PricingId == pricingId).Max(x => x.Price);
            int carId = _context.CarPricings.Where(x => x.Price == price).Select(x => x.CarId).FirstOrDefault();
            string brandModel = _context.Cars.Where(x => x.CarId == carId).Include(x => x.Brand).Select(x => x.Brand.Name + " " + x.Model).FirstOrDefault();

            return brandModel;
        }
        public string GetMostHaveCommentBlog()
        {
            var values = _context.Comments.GroupBy(x => x.BlogId).
       Select(y => new
       {
           BlogId = y.Key,
           Count = y.Count()
       }).OrderByDescending(z => z.Count).Take(1).FirstOrDefault();

            var blogTitle = _context.Blogs.Where(x => x.BlogId == values.BlogId).Select(x => x.Title).FirstOrDefault();
            return blogTitle;
        }
    }
}
