using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
