using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NuGet.Packaging;
using SSHotelApp.WebUI.Dtos.DashboardDto;

namespace SSHotelApp.WebUI.ViewComponents.Dashboard
{
    public class _DashboardSubscribeCountPartial : ViewComponent
    {

        public async Task<IViewComponentResult> InvokeAsync()
        {
            List<ResultSocialMediaDto> apiSocialMedia = new List<ResultSocialMediaDto>();

            var instagramData = await GetInstagramDataAsync();
            apiSocialMedia.Add(instagramData);

            var twitterData = await GetTwitterDataAsync();
            apiSocialMedia.Add(twitterData);

            return View(apiSocialMedia);
        }

        private async Task<ResultSocialMediaDto> GetTwitterDataAsync()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://twitter241.p.rapidapi.com/user?username=MrBeast"),
                Headers =
                    {
                        { "X-RapidAPI-Key", "db7426085amsh6a5d8b0152ec77ap18fb65jsnbdc7e43aa5db" },
                        { "X-RapidAPI-Host", "twitter241.p.rapidapi.com" },
                    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var apiTwitter = JsonConvert.DeserializeObject<ResultTwitterDto>(body);
                return new ResultSocialMediaDto
                {
                    twitterDto = apiTwitter
                };
            }
        }

        private async Task<ResultSocialMediaDto> GetInstagramDataAsync()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://instagram210.p.rapidapi.com/ig_profile?ig=incerceron"),
                Headers =
                    {
                        { "X-RapidAPI-Key", "db7426085amsh6a5d8b0152ec77ap18fb65jsnbdc7e43aa5db" },
                        { "X-RapidAPI-Host", "instagram210.p.rapidapi.com" },
                    },
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var apiInstagram = JsonConvert.DeserializeObject<List<ResultInstagramDto>>(body);
                return new ResultSocialMediaDto
                {
                    instagramDto = apiInstagram
                };
            }
        }
    }
}
