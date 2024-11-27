using CarBookProject.Dto.BlogDtos;
using CarBookProject.Dto.TagDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.Controllers
{
    public class BlogController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BlogController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7286/api/Blogs/GetBlogWithAllInfo");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<List<BlogListDto>>(jsonData);
                return View(value);
            }
            return View();
        }
        [HttpGet]
        public IActionResult BlogDetail(int id)
        {
            ViewBag.id = id;
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> BlogListForTagId(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7286/api/TagBlogs/GetBlogListByTagId/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<List<BlogListDto>>(jsonData);

                var responseMessage2 = await client.GetAsync($"https://localhost:7286/api/Tags/{id}");
                var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
                var value2 = JsonConvert.DeserializeObject<TagListDto>(jsonData2);
                ViewBag.tagName = value2.TagName;
                return View(value);
            }
            return View();
        }
    }
}
