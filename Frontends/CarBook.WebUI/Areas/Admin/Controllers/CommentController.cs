
using CarBookProject.Dto.BlogDtos;
using CarBookProject.Dto.CommentDtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Text;

namespace CommentBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]")]
    public class CommentController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CommentController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [Route("Index")]
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7286/api/Comments/");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<CommentListDto>>(jsonData);
                return View(values);
            }
            return View();
        }

        [Route("DeleteComment/{id:int}")]
        public async Task<IActionResult> DeleteComment(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7286/api/Comments/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }


        [Route("CreateComment")]
        [HttpGet]
        public async Task<IActionResult> CreateComment()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7286/api/Blogs/");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<BlogListDto>>(jsonData);
                List<SelectListItem> list = (from x in values
                                             select new SelectListItem
                                             {
                                                 Text = x.Title,
                                                 Value = x.BlogId.ToString()
                                             }).ToList();
                ViewBag.blogList = list;
            }

            return View();

        }
        [Route("CreateComment")]
        [HttpPost]
        public async Task<IActionResult> CreateComment(CommentCreateDto dto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(dto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/Json");
            var responseMessage = await client.PostAsync("https://localhost:7286/api/Comments", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(dto);
        }

        [Route("UpdateComment/{id:int}")]
        [HttpGet]
        public async Task<IActionResult> UpdateComment(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7286/api/Comments/{id}");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<CommentUpdateDto>(jsonData);
           
            var responseMessage2 = await client.GetAsync("https://localhost:7286/api/Blogs/");
            if (responseMessage2.IsSuccessStatusCode)
            {
                var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
                var values2 = JsonConvert.DeserializeObject<List<BlogListDto>>(jsonData2);
                List<SelectListItem> list = (from x in values2
                                             select new SelectListItem
                                             {
                                                 Text = x.Title,
                                                 Value = x.BlogId.ToString()
                                             }).ToList();
                ViewBag.blogList = list;
            }
            return View(values);

        }
        [Route("UpdateComment/{id:int}")]
        [HttpPost]
        public async Task<IActionResult> UpdateComment(CommentUpdateDto dto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(dto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7286/api/Comments/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(dto);

        }
    }
}
