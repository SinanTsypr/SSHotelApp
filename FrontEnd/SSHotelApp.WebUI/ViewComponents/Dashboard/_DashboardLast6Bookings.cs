using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SSHotelApp.WebUI.Dtos.BookingDto;
using SSHotelApp.WebUI.Dtos.StaffDto;
using System.Net.Http;

namespace SSHotelApp.WebUI.ViewComponents.Dashboard
{
    public class _DashboardLast6Bookings : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DashboardLast6Bookings(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7198/api/Booking/Last6Bookings");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultLast6BookingsDto>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
