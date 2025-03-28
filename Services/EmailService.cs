using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheBlogProject.ViewModels;

namespace TheBlogProject.Services
{
    public class EmailService : IBlogEmailSender
    {
        private readonly MailSettings mailSettings;

        public EmailService(IOptions<MailSettings> mailSettings)
        {
            this.mailSettings = mailSettings.Value;
        }

        public Task SendContactEmailAsync(string emailFrom, string name, string subject, string htmlMessage)
        {
            throw new NotImplementedException();
        }

        public async Task SendEmailAsync(string emailTo, string subject, string htmlMessage)
        {
            var email = new MimeMessage();
            email.Sender = MailboxAddress.Parse(this.mailSettings.Mail);
            email.To.Add(MailboxAddress.Parse(emailTo));

            //var builder = new BodyBuilder();
            //builder.HtmlBody = htmlMessage;
            var builder = new BodyBuilder()
            {
                HtmlBody = htmlMessage
            };

            email.Body = builder.ToMessageBody();

            using var smtp = new SmtpClient();
            smtp.Connect(this.mailSettings.Host, this.mailSettings.Port, SecureSocketOptions.StartTls);
            smtp.Authenticate(this.mailSettings.Mail, this.mailSettings.Password);

            await smtp.SendAsync(email);

            smtp.Disconnect(true);

        }
    }
}
