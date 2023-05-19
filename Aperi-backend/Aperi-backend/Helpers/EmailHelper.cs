using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;

namespace Aperi_backend.Helpers
{
    public static class EmailHelper
    {
        public static void SendEmail(MailMessage message)
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("appsettings.json");
            var config = builder.Build();
            var smtpClient = new SmtpClient(config["Smtp:Host"])
            {
                Port = int.Parse(config["Smtp:Port"]),
                Credentials = new NetworkCredential(config["Smtp:Username"], config["Smtp:Password"]),
                EnableSsl = true,
            };
            smtpClient.Send(message);
        }
    }
}
