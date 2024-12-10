using CarBookProject.Dto.BrandDtos;
using CarBookProject.Dto.CarDtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Text;

namespace CarBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]")]
    public class CarController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CarController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7286/api/Cars/GetCarWithBrand");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<CarListDto>>(jsonData);
                return View(values);
            }
            return View();
        }

        [Route("DeleteCar/{id:int}")]
        public async Task<IActionResult> DeleteCar(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7286/api/Cars?id={id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        [Route("CreateCar")]
        [HttpGet]
        public async Task<IActionResult> CreateCar()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7286/api/Brands");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<BrandListDto>>(jsonData);


            List<SelectListItem> list = (from x in values
                                         select new SelectListItem
                                         {
                                             Text = x.Name,
                                             Value = x.BrandId.ToString()
                                         }).ToList();
            ViewBag.brandList = list;
            return View();

        }
        [Route("CreateCar")]
        [HttpPost]
        public async Task<IActionResult> CreateCar(CarCreateDto dto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(dto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/Json");
            var responseMessage = await client.PostAsync("https://localhost:7286/api/Cars", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(dto);
        }

        [Route("UpdateCar/{id:int}")]
        [HttpGet]
        public async Task<IActionResult> UpdateCar(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7286/api/Cars/{id}");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<CarUpdateDto>(jsonData);

            var responseMessage2 = await client.GetAsync("https://localhost:7286/api/Brands");
            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            var values2 = JsonConvert.DeserializeObject<List<BrandListDto>>(jsonData2);

            List<SelectListItem> list = (from x in values2
                                         select new SelectListItem
                                         {
                                             Text = x.Name,
                                             Value = x.BrandId.ToString()
                                         }).ToList();
            ViewBag.brandList = list;
            return View(values);

        }
        [Route("UpdateCar/{id:int}")]
        [HttpPost]
        public async Task<IActionResult> UpdateCar(CarUpdateDto dto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(dto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7286/api/Cars/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(dto);

        }
    }
}
