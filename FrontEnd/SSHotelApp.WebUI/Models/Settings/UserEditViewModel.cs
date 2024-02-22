namespace SSHotelApp.WebUI.Models.Settings
{
    public class UserEditViewModel
    {
        public string Name { get; set; } = null!;
        public string SurName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string ConfirmPassword { get; set; } = null!;
    }
}
