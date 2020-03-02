using MimeKit;
using MailKit.Net.Smtp;
using System.Threading.Tasks;
using University.Models;
using Microsoft.Extensions.Options;

namespace University.Services
{
    public class EmailSenderService
    {
        public IOptions<ApplicationEmailModel> applicationConfig;

        private static string emailHost;
        private static string hostPassword;

        public EmailSenderService()
        {
            emailHost = applicationConfig.Value.Email;
            hostPassword = applicationConfig.Value.Password;
        }
        public async Task SendEmailAsync(string email, string subject, string message)
        {

            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("UNIVERSITY", emailHost));
            emailMessage.To.Add(new MailboxAddress("", email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            };

            using (var client = new SmtpClient())   
            {
                await client.ConnectAsync("smtp.gmail.com", 465, true);   
                await client.AuthenticateAsync(emailHost, hostPassword);
                await client.SendAsync(emailMessage);

                await client.DisconnectAsync(true);
            }
        }
    }
}
