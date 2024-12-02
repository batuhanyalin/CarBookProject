
using CarBookProject.Dto.TagDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace TagBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]")]
    public class TagController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public TagController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7286/api/Tags/");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<TagListDto>>(jsonData);
                return View(values);
            }
            return View();
        }

        [Route("DeleteTag/{id:int}")]
        public async Task<IActionResult> DeleteTag(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7286/api/Tags/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }


        [Route("CreateTag")]
        [HttpGet]
        public IActionResult CreateTag()
        {
            return View();

        }
        [Route("CreateTag")]
        [HttpPost]
        public async Task<IActionResult> CreateTag(TagCreateDto dto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(dto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/Json");
            var responseMessage = await client.PostAsync("https://localhost:7286/api/Tags", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(dto);
        }

        [Route("UpdateTag/{id:int}")]
        [HttpGet]
        public async Task<IActionResult> UpdateTag(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7286/api/Tags/{id}");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<TagUpdateDto>(jsonData);

            return View(values);

        }
        [Route("UpdateTag/{id:int}")]
        [HttpPost]
        public async Task<IActionResult> UpdateTag(TagUpdateDto dto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(dto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7286/api/Tags/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(dto);

        }
    }
}
