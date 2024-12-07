using CarBookProject.Dto.CarDtos;
using CarBookProject.Dto.FilterRentACarDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace CarBook.WebUI.Controllers
{
    public class RentACarController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public RentACarController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> List(FilterRentACarDto dto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(dto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7286/api/RentACars", stringContent);
            if (responseMessage.IsSuccessStatusCode) 
            {
                var jsonDats= await responseMessage.Content.ReadAsStringAsync();
                var values= JsonConvert.DeserializeObject<List<CarListDto>>(jsonDats);
                return View(values);
            }
            return View();
        }
    }
}
