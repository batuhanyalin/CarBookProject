using CarBookProject.Dto.StatisticDtos;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;

namespace CarBookProject.WebApi.Hubs
{
    public class CarHub:Hub
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public CarHub(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task SendCarCount()
        {
            var client= _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7286/api/Statistics");
            if (responseMessage.IsSuccessStatusCode) 
            {
                var jsonData= await responseMessage.Content.ReadAsStringAsync();
                var values= JsonConvert.DeserializeObject<StatisticDto>(jsonData);
                
                await Clients.All.SendAsync("ReceiveStatistic",values.brandCount);
            }
        }
    }
}
