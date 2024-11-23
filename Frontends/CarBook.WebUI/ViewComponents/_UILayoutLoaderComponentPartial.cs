using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents
{
    public class _UILayoutLoaderComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
