using CarBookProject.Dto.CarFeatureDtos;
using CarBookProject.Dto.FeatureDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http;
using System.Text;

namespace CarBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]")]
    public class CarFeatureDetailController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CarFeatureDetailController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [Route("Index/{id:int}")]
        [HttpGet]
        public async Task<IActionResult> Index(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7286/api/CarFeatures/GetCarFeatureListByCarId/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<CarFeatureListByCarIdDto>>(jsonData);
                return View(values);
            }
            return View();
        }

        [Route("Index/{id:int}")]
        [HttpPost]
        public async Task<IActionResult> Index(List<CarFeatureListByCarIdDto> dto)
        {
            var x = dto.Select(x => x.carId).FirstOrDefault();
            foreach (var item in dto)
            {
                if (item.available)
                {
                    CarFeatureListByCarIdDto model = new CarFeatureListByCarIdDto();
                    var client = _httpClientFactory.CreateClient();
                    await client.GetAsync($"https://localhost:7286/api/CarFeatures/CarFeatureChangeAvailableToTrue/{item.carFeatureId}");

                }
                else
                {
                    CarFeatureListByCarIdDto model = new CarFeatureListByCarIdDto();
                    var client = _httpClientFactory.CreateClient();
                    await client.GetAsync($"https://localhost:7286/api/CarFeatures/CarFeatureChangeAvailableToFalse/{item.carFeatureId}");

                }
            }
            return RedirectToAction("Index", "Car", new { area = "Admin" });
        }
        [Route("CreateFeatureByCarId/{id:int}")]
        [HttpGet]
        public async Task<IActionResult> CreateFeatureByCarId(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7286/api/Features");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<FeatureListDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
