using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
