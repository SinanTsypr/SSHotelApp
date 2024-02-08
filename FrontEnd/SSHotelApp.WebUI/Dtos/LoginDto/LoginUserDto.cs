using System.ComponentModel.DataAnnotations;

namespace SSHotelApp.WebUI.Dtos.LoginDto
{
    public class LoginUserDto
    {
        [Required(ErrorMessage ="Kullanıcı Adınız Giriniz")]
        public string Username { get; set; } = null!;

        [Required(ErrorMessage ="Şifrenizi Giriniz")]
        public string Password { get; set; } = null!;
    }
}
