using CarBookProject.Dto.CarDtos;
using CarBookProject.Dto.LocationDtos;
using CarBookProject.Dto.ReservationDtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;

namespace CarBook.WebUI.Controllers
{
    public class ReservationController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ReservationController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [HttpGet]
        public async Task<IActionResult> Index(int id)
        {
            var client = _httpClientFactory.CreateClient();

            var carResponseMessage = await client.GetAsync($"https://localhost:7286/api/Cars/{id}");
            if (carResponseMessage.IsSuccessStatusCode)
            {
                var carJsonData = await carResponseMessage.Content.ReadAsStringAsync();
                var carValue = JsonConvert.DeserializeObject<CarListDto>(carJsonData);
                ReservationCreateDto dto = new ReservationCreateDto();
                dto.CarId = id;
                ViewBag.car = $"{carValue.BrandName} {carValue.Model}";
                ViewBag.carImage=carValue.CoverImageUrl;
                var responseMessage = await client.GetAsync("https://localhost:7286/api/Locations");
                if (responseMessage.IsSuccessStatusCode)
                {
                    var jsonData = await responseMessage.Content.ReadAsStringAsync();
                    var values = JsonConvert.DeserializeObject<List<LocationListDto>>(jsonData);
                    List<SelectListItem> list = (from x in values
                                                 select new SelectListItem
                                                 {
                                                     Text = x.Name,
                                                     Value = x.LocationId.ToString()
                                                 }).ToList();
                    ViewBag.pickUpLocation = list;
                    List<SelectListItem> list2 = (from x in values
                                                  select new SelectListItem
                                                  {
                                                      Text = x.Name,
                                                      Value = x.LocationId.ToString()
                                                  }).ToList();
                    ViewBag.dropOffLocation = list2;
                }
                return View(dto);
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(ReservationCreateDto dto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(dto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7286/api/Reservations", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "Cars");
            }
            return View(dto);
        }
    }
}
