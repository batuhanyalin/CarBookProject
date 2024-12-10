using CarBookProject.Application.Models;
using CarBookProject.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBookProject.Application.Interfaces.ICarPricingInterfaces
{
	public interface ICarPricingRepository
	{
		public List<CarPricing> GetCarPricingWithAllInfo();
		public List<CarPricing> GetCarPricingWithTimePeriod();
		public List<CarPricingViewModel> GetCarPricingWithTimePeriod1();
		public List<CarPricing> GetCarLast5WithAllInfo();

    }
}
