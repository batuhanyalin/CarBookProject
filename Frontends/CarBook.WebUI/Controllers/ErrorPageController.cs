using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult AccessDenied()
        {
            return View();
        }
        public IActionResult error404() 
        {
            return View();
        }
    }
}
