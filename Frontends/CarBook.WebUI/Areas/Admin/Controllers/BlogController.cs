
using CarBookProject.Dto.AuthorDtos;
using CarBookProject.Dto.BlogDtos;
using CarBookProject.Dto.BrandDtos;
using CarBookProject.Dto.CategoryDtos;
using CarBookProject.Dto.CommentDtos;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using System.Text;

namespace BlogBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]")]
    public class BlogController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BlogController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [Route("Index")]
        public async Task<IActionResult> Index()
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

        [Route("DeleteBlog/{id:int}")]
        public async Task<IActionResult> DeleteBlog(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7286/api/Blogs/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }


        [Route("CreateBlog")]
        [HttpGet]
        public async Task<IActionResult> CreateBlog()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7286/api/Categories");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<CategoryListDto>>(jsonData);


            List<SelectListItem> list = (from x in values
                                         select new SelectListItem
                                         {
                                             Text = x.Name,
                                             Value = x.CategoryId.ToString()
                                         }).ToList();
            ViewBag.categoryList = list;

            var responseMessage2 = await client.GetAsync("https://localhost:7286/api/Authors");
            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            var values2 = JsonConvert.DeserializeObject<List<AuthorListDto>>(jsonData2);


            List<SelectListItem> list2 = (from x in values2
                                          select new SelectListItem
                                          {
                                              Text = $"{x.Name} {x.Surname}",
                                              Value = x.AuthorId.ToString()
                                          }).ToList();
            ViewBag.authorList = list2;



            return View();

        }
        [Route("CreateBlog")]
        [HttpPost]
        public async Task<IActionResult> CreateBlog(BlogCreateDto dto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(dto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/Json");
            var responseMessage = await client.PostAsync("https://localhost:7286/api/Blogs", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(dto);
        }

        [Route("UpdateBlog/{id:int}")]
        [HttpGet]
        public async Task<IActionResult> UpdateBlog(int id)
        {

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7286/api/Blogs/{id}");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<BlogUpdateDto>(jsonData);



            var responseMessage2 = await client.GetAsync("https://localhost:7286/api/Categories");
            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            var values2 = JsonConvert.DeserializeObject<List<CategoryListDto>>(jsonData2);


            List<SelectListItem> list = (from x in values2
                                         select new SelectListItem
                                         {
                                             Text = x.Name,
                                             Value = x.CategoryId.ToString()
                                         }).ToList();
            ViewBag.categoryList = list;



            var responseMessage3 = await client.GetAsync("https://localhost:7286/api/Authors");
            var jsonData3 = await responseMessage3.Content.ReadAsStringAsync();
            var values3 = JsonConvert.DeserializeObject<List<AuthorListDto>>(jsonData3);


            List<SelectListItem> list3 = (from x in values3
                                          select new SelectListItem
                                          {
                                              Text = $"{x.Name} {x.Surname}",
                                              Value = x.AuthorId.ToString()
                                          }).ToList();
            ViewBag.authorList = list3;

            return View(values);

        }
        [Route("UpdateBlog/{id:int}")]
        [HttpPost]
        public async Task<IActionResult> UpdateBlog(BlogUpdateDto dto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(dto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7286/api/Blogs/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View(dto);

        }

        [Route("BlogComment/{id:int}")]
        [HttpGet]
        public async Task<IActionResult> BlogComment(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7286/api/Comments/GetCommentByBlogId/{id}");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<CommentListDto>>(jsonData);
            ViewBag.blogTitle = values.Select(x => x.BlogTitle).FirstOrDefault();
            return View(values);

        }
    }
}
