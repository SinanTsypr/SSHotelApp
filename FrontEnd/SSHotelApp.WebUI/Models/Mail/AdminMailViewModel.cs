namespace SSHotelApp.WebUI.Models.Mail
{
    public class AdminMailViewModel
    {
        public int Name { get; set; }
        public string SenderMail { get; set; } = null!;
        public string ReceiverMail { get; set; } = null!;
        public string Subject { get; set; } = null!;
        public string Body { get; set; } = null!;
    }
}
