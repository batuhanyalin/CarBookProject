using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers
{
    public class PricingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
