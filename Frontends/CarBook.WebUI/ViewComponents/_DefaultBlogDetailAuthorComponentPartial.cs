using CarBookProject.Dto.AboutDtos;
using CarBookProject.Dto.AuthorDtos;
using CarBookProject.Dto.BlogDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.ViewComponents
{
    public class _DefaultBlogDetailAuthorComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultBlogDetailAuthorComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7286/api/Blogs/GetBlogWithAllInfoById/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var value = JsonConvert.DeserializeObject<BlogListDto>(jsonData);

                var responseMessage2 = await client.GetAsync($"https://localhost:7286/api/Authors/{value.AuthorId}");
                var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
                var value2 = JsonConvert.DeserializeObject<AuthorListDto>(jsonData2);
                return View(value2);
            }
            return View();
        }
    }
}
