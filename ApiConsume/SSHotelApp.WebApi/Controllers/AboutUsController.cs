using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SSHotelApp.BusinessLayer.Abstract;
using SSHotelApp.EntityLayer.Concrete;

namespace SSHotelApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutUsController : ControllerBase
    {
        private readonly IAboutUsService _aboutUsService;

        public AboutUsController(IAboutUsService aboutUsService)
        {
            _aboutUsService = aboutUsService;
        }

        [HttpGet]
        public IActionResult AboutUsList()
        {
            var values = _aboutUsService.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult AddAboutUs(AboutUs aboutUs)
        {
            _aboutUsService.TInsert(aboutUs);
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteAboutUs(int id)
        {
            var values = _aboutUsService.TGetById(id);
            _aboutUsService.TDelete(values);
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateAboutUs(AboutUs aboutUs)
        {
            _aboutUsService.TUpdate(aboutUs);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetAboutUs(int id)
        {
            var values = _aboutUsService.TGetById(id);
            return Ok(values);
        }
    }
}
