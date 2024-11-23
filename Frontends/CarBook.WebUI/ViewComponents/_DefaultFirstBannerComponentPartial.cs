using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents
{
    public class _DefaultFirstBannerComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
