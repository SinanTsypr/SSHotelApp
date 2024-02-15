using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using SSHotelApp.WebUI.Models.Mail;

namespace SSHotelApp.WebUI.Controllers
{
    public class AdminMailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(AdminMailViewModel adminMailViewModel)
        {
            MimeMessage mimeMessage = new MimeMessage();

            //Kimden
            MailboxAddress mailboxAddressFrom = new MailboxAddress("SSHotelAdmin", "sinantasyapar@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);
            //Kime
            MailboxAddress mailboxAddressTo = new MailboxAddress("User", adminMailViewModel.ReceiverMail);
            mimeMessage.To.Add(mailboxAddressTo);
            //Mail'in içeriği
            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = adminMailViewModel.Body;
            mimeMessage.Body = bodyBuilder.ToMessageBody();
            //Mail'in başlığı
            mimeMessage.Subject = adminMailViewModel.Subject;

            SmtpClient smtpClient = new SmtpClient();
            smtpClient.Connect("smtp.gmail.com", 587, false);
            smtpClient.Authenticate("sinantasyapar@gmail.com", "xzkj rhaq fkyn qqvw");
            smtpClient.Send(mimeMessage);
            smtpClient.Disconnect(true);

            return View();
        }
    }
}
