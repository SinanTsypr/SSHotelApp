using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SSHotelApp.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FileImageController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> UploadImage([FromForm] IFormFile file)
        {
            var fileName = Guid.NewGuid() + Path.GetExtension(file.FileName);
            var path = Path.Combine(Directory.GetCurrentDirectory(), "img" + fileName);
            var stream = new FileStream(path, FileMode.Create);
            await file.CopyToAsync(stream);
            return Created("", file); 
        }
    }
}
