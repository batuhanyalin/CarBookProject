using CarBookProject.Dto.LoginDtos;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers
{
    public class LoginController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public LoginController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(LoginDto dto)
        {
            return View();
        }
    }
}
