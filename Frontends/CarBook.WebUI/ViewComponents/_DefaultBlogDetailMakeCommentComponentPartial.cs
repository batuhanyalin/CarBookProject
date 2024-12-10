using CarBookProject.Dto.AboutDtos;
using CarBookProject.Dto.BlogDtos;
using CarBookProject.Dto.CommentDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CarBook.WebUI.ViewComponents
{
    public class _DefaultBlogDetailMakeCommentComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultBlogDetailMakeCommentComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7286/api/Blogs/GetBlogWithAllInfoById/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                CommentCreateDto commentCreateDto = new CommentCreateDto();
                commentCreateDto.BlogId = id;
                return View(commentCreateDto);
            }
           return View();
        }
    }
}
