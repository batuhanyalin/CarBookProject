
using CarBookProject.Dto.AboutDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace AboutBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]")]
    public class AboutController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AboutController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [Route("UpdateAbout")]
        [HttpGet]
        public async Task<IActionResult> UpdateAbout()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage2 = await client.GetAsync("https://localhost:7286/api/Abouts/");

            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            var values2 = JsonConvert.DeserializeObject<List<AboutListDto>>(jsonData2).FirstOrDefault();
            var AboutId = values2.AboutId;



            var responseMessage = await client.GetAsync($"https://localhost:7286/api/Abouts/{AboutId}");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<AboutUpdateDto>(jsonData);

            return View(values);

        }
        [Route("UpdateAbout")]
        [HttpPost]
        public async Task<IActionResult> UpdateAbout(AboutUpdateDto dto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(dto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7286/api/Abouts/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("UpdateAbout");
            }
            return View(dto);

        }
    }
}
