using System.ComponentModel.DataAnnotations;

namespace SSHotelApp.WebUI.Dtos.RegisterDto
{
    public class CreateNewUserDto
    {
        [Required(ErrorMessage ="Ad Alanı Gereklidir..")]
        public string Name { get; set; } = null!;

        [Required(ErrorMessage = "Soyad Alanı Gereklidir..")]
        public string SurName { get; set; } = null!;

        [Required(ErrorMessage = "Kullanıcı Adı Alanı Gereklidir..")]
        public string Username { get; set; } = null!;

        [Required(ErrorMessage = "Mail Alanı Gereklidir..")]
        public string Mail { get; set; } = null!;

        [Required(ErrorMessage = "Şifre Alanı Gereklidir..")]
        public string Password { get; set; } = null!;

        [Required(ErrorMessage = "Şifre Tekrarı Alanı Gereklidir..")]
        [Compare("Password", ErrorMessage = "Şifreler Eşleşmiyor")]
        public string ConfirmPassword { get; set; } = null!;
    }
}
