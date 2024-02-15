namespace SSHotelApp.WebUI.Dtos.ContactDto
{
    public class InboxContactDto
    {
        public int ContactId { get; set; }
        public string Name { get; set; } = null!;
        public string Mail { get; set; } = null!;
        public string Subject { get; set; } = null!;
        public string Message { get; set; } = null!;
        public DateTime Date { get; set; }
    }
}
