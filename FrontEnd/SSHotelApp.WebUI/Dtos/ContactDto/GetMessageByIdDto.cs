namespace SSHotelApp.WebUI.Dtos.ContactDto
{
    public class GetMessageByIdDto
    {
        public int SendMessageId { get; set; }
        public string ReceiverName { get; set; } = null!;
        public string ReceiverMail { get; set; } = null!;
        public string SenderName { get; set; } = null!;
        public string SenderMail { get; set; } = null!;
        public string Title { get; set; } = null!;
        public string Content { get; set; } = null!;
        public DateTime Date { get; set; }
    }
}
