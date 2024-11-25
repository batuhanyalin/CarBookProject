using CarBookProject.Dto.CarDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.Controllers
{
    public class PricingController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public PricingController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client= _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7286/api/Cars/GetCarListWithPricing");
            if (responseMessage.IsSuccessStatusCode) {
                var jsonData= await responseMessage.Content.ReadAsStringAsync();
                var values= JsonConvert.DeserializeObject<List<CarListDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
