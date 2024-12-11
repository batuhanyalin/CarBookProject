using CarBookProject.Dto.BlogDtos;
using CarBookProject.Dto.CarDtos;
using CarBookProject.Dto.CarPricingDtos;
using CarBookProject.Dto.StatisticDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.Areas.Admin.ViewComponents.DashboardComponents
{
    public class _DashboardChart3ComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DashboardChart3ComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7286/api/Blogs/GetBlogWithAllInfo");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<BlogListDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
