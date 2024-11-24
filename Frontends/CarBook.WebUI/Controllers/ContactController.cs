using CarBookProject.Dto.ContactCategoryDtos;
using CarBookProject.Dto.ContactDtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Text;

namespace CarBook.WebUI.Controllers
{
    public class ContactController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ContactController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7286/api/ContactCategories");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<List<ContactCategoryListDto>>(jsonData);

                List<SelectListItem> list = (from x in value
                                             select new SelectListItem
                                             {
                                                 Text = x.Name,
                                                 Value = x.ContactCategoryId.ToString()
                                             }).ToList();
                ViewBag.categoryList = list;
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(ContactCreateDto dto)
        {
            dto.SendingDate = DateTime.Now;
            dto.IsApproved = false;
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(dto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7286/api/Contacts", stringContent);
            if (responseMessage.IsSuccessStatusCode) { return RedirectToAction("Index"); }
            return View();
        }
    }
}
