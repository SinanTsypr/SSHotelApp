namespace SSHotelApp.WebUI.Dtos.SendMessageDto
{
    public class CreateSendMessageDto
    {
        public string ReceiverName { get; set; } = null!;
        public string ReceiverMail { get; set; } = null!;
        public string SenderName { get; set; } = null!;
        public string SenderMail { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Content { get; set; } = null!;
        public DateTime Date { get; set; }
    }
}
