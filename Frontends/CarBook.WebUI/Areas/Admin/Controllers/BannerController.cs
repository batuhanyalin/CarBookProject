
using CarBookProject.Dto.BannerDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace BannerBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]")]
    public class BannerController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BannerController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [Route("UpdateBanner")]
        [HttpGet]
        public async Task<IActionResult> UpdateBanner()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage2 = await client.GetAsync("https://localhost:7286/api/Banners/");

            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            var values2 = JsonConvert.DeserializeObject<List<BannerListDto>>(jsonData2).FirstOrDefault();
            var bannerId = values2.BannerId;



            var responseMessage = await client.GetAsync($"https://localhost:7286/api/Banners/{bannerId}");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<BannerUpdateDto>(jsonData);

            return View(values);

        }
        [Route("UpdateBanner")]
        [HttpPost]
        public async Task<IActionResult> UpdateBanner(BannerUpdateDto dto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(dto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7286/api/Banners/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("UpdateBanner");
            }
            return View(dto);

        }
    }
}
