using CarBookProject.Dto.CommentDtos;
using CarBookProject.Dto.ContactDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace CarBook.WebUI.Controllers
{
    public class CommentController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CommentController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [HttpPost]
        public async Task<IActionResult> Index(CommentCreateDto dto)
        {
            dto.CreatedDate = DateTime.Now;
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(dto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7286/api/Comments", stringContent);
            if (responseMessage.IsSuccessStatusCode) 
            { 
                return RedirectToAction("BlogDetail", "Blog", new { id=dto.BlogId }); 
            }
            return View();
        }
    }
}
