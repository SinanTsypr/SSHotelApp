using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SSHotelApp.WebUI.Dtos.RoomDto;
using SSHotelApp.WebUI.Dtos.WorkLocationDto;

namespace SSHotelApp.WebUI.Controllers
{
    public class AdminWorkLocationController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public AdminWorkLocationController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetFromJsonAsync<List<ResultWorkLocationDto>>($"https://localhost:7198/api/WorkLocation");
            //var responseMessage = await client.GetAsync("https://localhost:7198/api/WorkLocation");
            //if (responseMessage.IsSuccessStatusCode)
            //{
            //    var jsonData = await responseMessage.Content.ReadAsStringAsync();
            //    var values = JsonConvert.DeserializeObject<List<ResultWorkLocationDto>>(jsonData);
            //    return View(values);
            //}
            return View(responseMessage);
        }

        [HttpGet]
        public IActionResult AddWorkLocation()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddWorkLocation(CreateWorkLocationDto createWorkLocationDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createWorkLocationDto);
            var responseMessage = await client.PostAsJsonAsync("https://localhost:7198/api/WorkLocation", jsonData);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> DeleteWorkLocation(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7198/api/WorkLocation/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> UpdateWorkLocation(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetFromJsonAsync<UpdateWorkLocationDto>($"https://localhost:7198/api/WorkLocation/{id}");
            return View(responseMessage);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateWorkLocation(UpdateWorkLocationDto updateWorkLocationDto)
        {
            var client = _httpClientFactory.CreateClient();
            var values = await client.PutAsJsonAsync("https://localhost:7198/api/WorkLocation", updateWorkLocationDto);
            return View("Index");
        }
    }
}
