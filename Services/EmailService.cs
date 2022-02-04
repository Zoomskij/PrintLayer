using PrintLayer.Services.Interfaces;
using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace PrintLayer.Services
{
    public class EmailService : IEmailService
    {
        #region Settings
        private const string EMAIL = "example@example.com";
        private const string PASSWORD = "example_password";
        private const string NAME = "John Doe";
        #endregion

        public async Task Send()
        {
            MailAddress from = new MailAddress(EMAIL, NAME);
            MailAddress to = new MailAddress("somemail@gmail.com");
            MailMessage m = new MailMessage(from, to);
            m.Subject = "Test";
            m.Body = "Check smtp-client";
            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
            smtp.Credentials = new NetworkCredential(EMAIL, PASSWORD);
            smtp.EnableSsl = true;
            await smtp.SendMailAsync(m);
        }
    }
}
