using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSHotelApp.EntityLayer.Concrete
{
    public class SendMessage
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
