using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SSHotelApp.WebUI.Dtos.GuestDto;
using SSHotelApp.WebUI.Dtos.StaffDto;

namespace SSHotelApp.WebUI.ViewComponents.Dashboard
{
    public class _DashboardLast4Staff : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DashboardLast4Staff(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync() 
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7198/api/Staff/Last4Staff");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultLast4StaffDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
