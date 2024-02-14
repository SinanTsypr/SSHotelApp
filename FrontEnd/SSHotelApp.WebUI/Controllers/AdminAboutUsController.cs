using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SSHotelApp.WebUI.Dtos.AboutDto;
using System.Text;

namespace SSHotelApp.WebUI.Controllers
{
    public class AdminAboutUsController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminAboutUsController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }


        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7198/api/AboutUs");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultAboutUsDto>>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> UpdateAboutUs(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7198/api/AboutUs/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateAboutUsDto>(jsonData);
                return View(values);
            }
            return View();
        }

        public async Task<IActionResult> UpdateAboutUs(UpdateAboutUsDto updateAboutUsDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateAboutUsDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7198/api/AboutUs", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}
