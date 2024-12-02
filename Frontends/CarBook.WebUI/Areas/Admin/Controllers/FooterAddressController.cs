
using CarBookProject.Dto.FooterAddressDtos;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace FooterAddressBook.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Route("Admin/[controller]")]
    public class FooterAddressController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public FooterAddressController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [Route("UpdateFooterAddress")]
        [HttpGet]
        public async Task<IActionResult> UpdateFooterAddress()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage2 = await client.GetAsync("https://localhost:7286/api/FooterAddresses/");

            var jsonData2 = await responseMessage2.Content.ReadAsStringAsync();
            var values2 = JsonConvert.DeserializeObject<List<FooterAddressListDto>>(jsonData2).FirstOrDefault();
            var FooterAddressId = values2.FooterAddressId;



            var responseMessage = await client.GetAsync($"https://localhost:7286/api/FooterAddresses/{FooterAddressId}");
            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<FooterAddressUpdateDto>(jsonData);

            return View(values);

        }
        [Route("UpdateFooterAddress")]
        [HttpPost]
        public async Task<IActionResult> UpdateFooterAddress(FooterAddressUpdateDto dto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(dto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7286/api/FooterAddresses/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("UpdateFooterAddress");
            }
            return View(dto);

        }
    }
}
