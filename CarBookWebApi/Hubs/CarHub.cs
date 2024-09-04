using Microsoft.AspNetCore.SignalR;

namespace CarBookWebApi.Hubs
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
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7065/api/Statistics/GetCarCount");
            var value = await responseMessage.Content.ReadAsStringAsync();
            await Clients.All.SendAsync("ReceiveCarCount", value);
        }

    }
}
