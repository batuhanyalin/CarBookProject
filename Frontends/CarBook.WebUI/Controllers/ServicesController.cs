using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
