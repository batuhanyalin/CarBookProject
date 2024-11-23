using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
