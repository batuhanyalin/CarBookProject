using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers
{
    public class RentADriverController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
