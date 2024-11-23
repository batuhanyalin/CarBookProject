using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers
{
    public class CarsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CarDetail()
        {
            return View();
        }
    }
}
