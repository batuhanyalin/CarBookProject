using CarBookProject.Application.Interfaces.ICarPricingInterfaces;
using CarBookProject.Domain.Entities;
using CarBookProject.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Persistence.Repositories.CarPricingRepositories
{
	public class CarPricingRepository : ICarPricingRepository
	{
		private readonly CarBookContext _context;

		public CarPricingRepository(CarBookContext context)
		{
			_context = context;
		}

		public List<CarPricing> GetCarPricingWithAllInfo()
		{
			var values = _context.CarPricings.Where(x => x.PricingId == 2).Include(x => x.Car).ThenInclude(x => x.Brand).Include(x => x.Pricing).ToList();
			return values;
		}
	}
}
