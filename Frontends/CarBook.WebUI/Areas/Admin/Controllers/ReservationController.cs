using CarBookProject.Dto.CarDtos;
using CarBookProject.Dto.LocationDtos;
using CarBookProject.Dto.ReservationDtos;
using CarBookProject.Dto.ReservationStatusDtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Text;

namespace CarBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]")]
    public class ReservationController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ReservationController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7286/api/Reservations/");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ReservationListDto>>(jsonData);
                return View(values);
            }
            return View();
        }

        [Route("DeleteReservation/{id:int}")]
        public async Task<IActionResult> DeleteReservation(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7286/api/Reservations/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }


        [Route("CreateReservation")]
        [HttpGet]
        public async Task<IActionResult> CreateReservation()
        {
            var client = _httpClientFactory.CreateClient();

            var carResponseMessage = await client.GetAsync($"https://localhost:7286/api/Cars/GetCarWithBrand");
            var carData = await carResponseMessage.Content.ReadAsStringAsync();
            var carValues = JsonConvert.DeserializeObject<List<CarListDto>>(carData);

            var locationRepsonseMessage = await client.GetAsync($"https://localhost:7286/api/Locations/");
            var locationData = await locationRepsonseMessage.Content.ReadAsStringAsync();
            var locationValues = JsonConvert.DeserializeObject<List<LocationListDto>>(locationData);

            var reservationStatusRepsonseMessage = await client.GetAsync($"https://localhost:7286/api/ReservationStatus/");
            var reservationStatusData = await reservationStatusRepsonseMessage.Content.ReadAsStringAsync();
            var reservationStatusValues = JsonConvert.DeserializeObject<List<ReservationStatusListDto>>(reservationStatusData);


            List<SelectListItem> locationList = (from x in locationValues
                                                 select new SelectListItem
                                                 {
                                                     Text = x.Name,
                                                     Value = x.LocationId.ToString(),
                                                 }).ToList();
            List<SelectListItem> carList = (from x in carValues
                                            select new SelectListItem
                                            {
                                                Text = $"{x.BrandName} - {x.Model}",
                                                Value = x.CarId.ToString(),
                                            }).ToList();

            List<SelectListItem> reservationStatusList = (from x in reservationStatusValues
                                                          select new SelectListItem
                                                          {
                                                              Text = x.Name,
                                                              Value = x.ReservationStatusId.ToString(),
                                                          }).ToList();


            ViewBag.LocationList = locationList;
            ViewBag.CarList = carList;
            ViewBag.ReservationStatusList = reservationStatusList;
            return View();

        }
        [Route("CreateReservation")]
        [HttpPost]
        public async Task<IActionResult> CreateReservation(ReservationCreateDto dto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(dto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/Json");
            var responseMessage = await client.PostAsync("https://localhost:7286/api/Reservations", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(dto);
        }

        [Route("UpdateReservation/{id:int}")]
        [HttpGet]
        public async Task<IActionResult> UpdateReservation(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7286/api/Reservations/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<ReservationUpdateDto>(jsonData);

                var carResponseMessage = await client.GetAsync($"https://localhost:7286/api/Cars/GetCarWithBrand");
                var carData = await carResponseMessage.Content.ReadAsStringAsync();
                var carValues = JsonConvert.DeserializeObject<List<CarListDto>>(carData);

                var locationRepsonseMessage = await client.GetAsync($"https://localhost:7286/api/Locations/");
                var locationData = await locationRepsonseMessage.Content.ReadAsStringAsync();
                var locationValues = JsonConvert.DeserializeObject<List<LocationListDto>>(locationData);

                var reservationStatusRepsonseMessage = await client.GetAsync($"https://localhost:7286/api/ReservationStatus/");
                var reservationStatusData = await reservationStatusRepsonseMessage.Content.ReadAsStringAsync();
                var reservationStatusValues = JsonConvert.DeserializeObject<List<ReservationStatusListDto>>(reservationStatusData);


                List<SelectListItem> locationList= (from x in locationValues
                                                    select new SelectListItem
                                                    {
                                                        Text = x.Name,
                                                        Value=x.LocationId.ToString(),
                                                    }).ToList();
                List<SelectListItem> carList = (from x in carValues
                                                     select new SelectListItem
                                                     {
                                                         Text = $"{x.BrandName} - {x.Model}",
                                                         Value = x.CarId.ToString(),
                                                     }).ToList();

                List<SelectListItem> reservationStatusList = (from x in reservationStatusValues
                                                     select new SelectListItem
                                                     {
                                                         Text = x.Name,
                                                         Value = x.ReservationStatusId.ToString(),
                                                     }).ToList();


                ViewBag.LocationList = locationList;
                ViewBag.CarList = carList;
                ViewBag.ReservationStatusList = reservationStatusList;

                return View(values);
            }

            return View();

        }
        [Route("UpdateReservation/{id:int}")]
        [HttpPost]
        public async Task<IActionResult> UpdateReservation(ReservationUpdateDto dto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(dto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7286/api/Reservations/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(dto);

        }
    }
}
