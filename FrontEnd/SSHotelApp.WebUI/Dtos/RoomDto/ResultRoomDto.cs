namespace SSHotelApp.WebUI.Dtos.RoomDto
{
    public class ResultRoomDto
    {
        public int RoomId { get; set; }
        public string RoomNumber { get; set; } = null!;
        public string RoomCoverImage { get; set; } = null!;
        public int Price { get; set; }
        public string Title { get; set; } = null!;
        public string BedCount { get; set; } = null!;
        public string BathCount { get; set; } = null!;
        public string Wifi { get; set; } = null!;
        public string Description { get; set; } = null!;
    }
}
