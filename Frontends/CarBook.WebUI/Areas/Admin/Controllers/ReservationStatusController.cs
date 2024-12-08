using CarBookProject.Dto.ReservationStatusDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace CarBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]")]
    public class ReservationStatusController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ReservationStatusController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7286/api/ReservationStatus/");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ReservationStatusListDto>>(jsonData);
                return View(values);
            }
            return View();
        }

        [Route("DeleteReservationStatus/{id:int}")]
        public async Task<IActionResult> DeleteReservationStatus(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7286/api/ReservationStatus/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }


        [Route("CreateReservationStatus")]
        [HttpGet]
        public IActionResult CreateReservationStatus()
        {
            return View();

        }
        [Route("CreateReservationStatus")]
        [HttpPost]
        public async Task<IActionResult> CreateReservationStatus(ReservationStatusCreateDto dto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(dto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/Json");
            var responseMessage = await client.PostAsync("https://localhost:7286/api/ReservationStatus", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(dto);
        }

        [Route("UpdateReservationStatus/{id:int}")]
        [HttpGet]
        public async Task<IActionResult> UpdateReservationStatus(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7286/api/ReservationStatus/{id}");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<ReservationStatusUpdateDto>(jsonData);

            return View(values);

        }
        [Route("UpdateReservationStatus/{id:int}")]
        [HttpPost]
        public async Task<IActionResult> UpdateReservationStatus(ReservationStatusUpdateDto dto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(dto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7286/api/ReservationStatus/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(dto);

        }
    }
}
