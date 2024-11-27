using Microsoft.AspNetCore.Identity.UI.Services;
using System.Threading.Tasks;

namespace IS4439_Project_1.Services
{
    public class DummyEmailSender : IEmailSender
    {
        public Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            // Do nothing, as we don't want to send emails
            return Task.CompletedTask;
        }
    }
}
