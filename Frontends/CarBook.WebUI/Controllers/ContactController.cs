using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
