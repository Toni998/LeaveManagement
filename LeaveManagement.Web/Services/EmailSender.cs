using Microsoft.AspNetCore.Identity.UI.Services;
using System.Net.Mail;

namespace LeaveManagement.Web.Services
{
    public class EmailSender : IEmailSender
    {

        public string smpHost { get; }
        public int smptPort { get; set; }
        public string smptMail { get; set; }
        public EmailSender(string smpHost, int smptPort, string smptMail)
        {
            this.smpHost = smpHost;
            this.smptPort = smptPort;
            this.smptMail = smptMail;
        }

        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            var message = new MailMessage
            {
                From = new MailAddress(smptMail),
                Subject = subject,
                Body = htmlMessage,
                IsBodyHtml = true
            };
            
            message.To.Add(new MailAddress(email));

            //create client
            using var client = new SmtpClient(smpHost, smptPort);
           client.Send(message);

            return Task.CompletedTask;
        }
    }
}
